﻿/*
Name:		Minedrink_MCU.ino
Created:	2017/7/30 20:22:00
Author:	liute
*/
#include <HX711.h>
#include <IRremote.h>
int latchPin = 8;       //D8连接74HC595芯片的使能引脚
int clockPin = 3;       //D3连接时钟引脚
int dataPin = 9;        //D9连接数据引脚
int RECV_Pin = 2;       //D2链接红外接收器
int steelyardPinA_1 = 41;//
int steelyardPinA_2 = 42;
IRrecv irrecv(RECV_Pin);
decode_results results;
//代表数字0~9
byte Tab[] = { 0xc0,0xf9,0xa4,0xb0,0x99,0x92,0x82,0xf8,0x80,0x90 };
int modeNumber = 0;		//Arduino的状态值
float Weight_1 = 0;		//一号秤的读数
bool isConn = false;    //是否成功建立TCP链接
int connTryNum = 0;     //TCP呼叫计数;
String commStr = "";		//通过WIFI接受到的指令
int weightSensorsLenth = 1;	//重量传感器的可用数量
//重量传感器参数,分别为SCK,DT,GapValue,resualt, offset
Hx711_Senor weightSensors[15] =  {
	{ 41,43,430,0,8422741 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 },
	{ 0,0,0,0,0 } };
int ints[5] = { 1,2,3,4,5 };
enum IRCommands         //红外指令对照表
{

	IR_Zero = 0xFD30CF,
	IR_One = 0xFD08F7,
	IR_TWO = 0xFD8877,
	IR_Three = 0xFD48B7
};
void setup()
{
	Serial.begin(115200);
	Serial1.begin(115200);
	while (!Serial);
	delay(100);
	//initSensors();
	Serial.print("XXDT=");
	Serial.println(weightSensors[0].dt);
	Init_Hx711();
	irrecv.enableIRIn();
	pinMode(latchPin, OUTPUT);
	pinMode(dataPin, OUTPUT);
	pinMode(clockPin, OUTPUT);
	pinMode(LED_BUILTIN, OUTPUT);
	delay(1000);
	Get_Maopi(0);
	digitalWrite(LED_BUILTIN, HIGH);
	Serial.write("Welcome to use!");
}

void loop()
{
	checkState();
	switch (modeNumber)
	{
	case 0:
		state_Zero();
		break;
	case 1:
		state_One();
		break;
	case 2:
		state_Two();
		break;
	case 3:
		state_Three();
		break;
	}
}
//检查状态并显示对应数字
void checkState() {
	if (irrecv.decode(&results))
	{
		Serial.println(results.value, HEX);//DEC OTC
		switch (results.value)
		{
		case IR_Zero:
			Serial.println("Mode:0");
			changeNumber(0);
			break;
		case IR_One:
			Serial.println("Mode:1");
			changeNumber(1);
			break;
		case IR_TWO:
			Serial.println("Mode:2");
			changeNumber(2);
			break;
		case IR_Three:
			Serial.println("Mode:3");
			changeNumber(3);
			break;
		default:
			showNumber(modeNumber);
			break;
		}
		irrecv.resume();
	}
}
//模式0：串口互传模式
void state_Zero() {
	while (Serial.available()) {
		Serial1.write(Serial.read());
	}
		
	while (Serial1.available()) {
		Serial.write(Serial1.read());
	}
		
}
//模式1:称重模式
void state_One() {
	Weight_1 = Get_Weight(0);	//计算放在传感器上的重物重量
	float w1 = Weight_1 * 4.44444;
	Serial.print(float(Weight_1 / 1000)*4.44444, 3);	//串口显示重量
	Serial.print(" kg\n");	//显示单位
	Serial.print("\n");		//显示单位
	Serial1.print(w1);
	Serial1.print(" g\n");
	Serial1.println("**********************");
	delay(1000);				//延时1s
}
//模式2:主动与TCP Server建立连接
void state_Two() {
	
	if (!isConn && connTryNum == 0)//如果未执行过AT指令则执行
	{
		Serial.print("BEGIN TCPCONN");
		Serial1.print("+++");
		delay(1000);	//延时过小时(100)会出现失灵的情况
		Serial1.print("AT+TCPCLICONN=192.168.2.193:8080");
		delay(100);
		Serial1.print("AT+EXIT");
	}

	if (!isConn && connTryNum < 10) //呼叫10次直到超时或确定链接建立
	{
		Serial1.println("#TCPOK?");
		connTryNum++;
	}
	/*else if (!isConn && connTryNum > 100)
	{
		Serial.println("#TCP CAN'T CONN");
	}*/
	while (Serial1.available()) {
		int charNum = Serial1.read();
		if (charNum == '#')	//接收到指令
		{
		   	/*commStr = Serial1.readString();*/
			commStr = Serial1.readStringUntil(';');
			Serial.println(commStr);
			if (commStr == "TCPOK")
			{
				isConn = true;
				changeNumber(1);
			}
		}
		Serial.write(charNum);
	}
}
//模式3:
void state_Three() {
	if (isConn)
	{
		isConn = false;
		connTryNum = 0;
	}
}

//记录并改变显示数值
void changeNumber(int nummber) {
	modeNumber = nummber;
	showNumber(modeNumber);
}
//控制LED显示指定数字一定时间
void showNumber(int number) {
	digitalWrite(latchPin, LOW);
	shiftOut(dataPin, clockPin, MSBFIRST, Tab[number]);
	digitalWrite(latchPin, HIGH);
	delay(80);
}
//初始化所有传感器的数据
void initSensors() {
	weightSensorsLenth = 1;
	weightSensors[0].sck = 41;
	weightSensors[0].dt = 43;
	
}

//}
//红色按钮    0xff00|FD00FF
//VOL +       0xfe01|FD807F
//FUNC / STOP 0xfd02|FD40BF
//左2个三角   0xfb04|FD20DF
//暂停键      0xfa05|FDA05F
//右2个三角   0xf906|FD609F
//向下三角    0xf708|FD10EF
//VOL -       0xf609|FD906F
//向上三角    0xf50a|FD50AF
//0           0xf30c|FD30CF
//EQ          0xf20d|FDB04F
//ST / REPT   0xf10e|FD708F
//1           0xef10|FD08F7
//2           0xee11|FD8877
//3           0xed12|FD48B7
//4           0xeb14|FD28D7
//5           0xea15|FDA857
//6           0xe916|FD6897
//7           0xe718|FD18E7
//8           0xe619|FD9867
//9           0xe51a|FD58A7