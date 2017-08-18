﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPShopManagement.Helpers
{
    /// <summary>
    ///与Arduino之间的指令及其处理工具 
    ///▶ 每行指令数≤1。
    ///▶ 含有指令的行必须以"#"开头，"\n"结尾。
    ///▶ 指令格式固定为:# + 7个字符（数字或大小写字母或*）。 如：#Abc123*
    ///▶ #为指令关键字，勿作他用。
    /// </summary>
    public class H_CommandCode
    {
        /// <summary>
        /// 接收指令
        ///▶ 每行指令数≤1。
        ///▶ 含有指令的行必须以"#"开头，"\n"结尾。
        ///▶ 指令格式固定为:# + 7个字符（数字或大小写字母或*）。 如：#Abc123*
        ///▶ #为指令关键字，勿作他用。
        /// </summary>
        public static RXCommCode StringConvertToEnum(string str)
        {
            RXCommCode commCode = RXCommCode.ERROR;
            switch (str)
            {
                case "#TCPDONE":
                    commCode = RXCommCode.TcpDone;
                    break;
                case "#ALLINFO":
                    commCode = RXCommCode.AllInfo;
                    break;
                case "#UPDATEX":
                    commCode = RXCommCode.Update;
                    break;
                default:
                    //TODO:改成异常处理
                    commCode = RXCommCode.ERROR;
                    break;
            }
            return commCode;
        }
        /// <summary>
        /// RX指令转换为字符串
        /// </summary>
        /// <param name="rxCode">接收到的指令</param>
        /// <returns></returns>
        public static string RXCCodeConvertToString(RXCommCode rxCode)
        {
            string result = null;
            switch (rxCode)
            {
                case RXCommCode.TcpDone:
                    break;
                case RXCommCode.AllInfo:
                    break;
                case RXCommCode.ERROR:
                    break;
                default:
                    new NotImplementedException();
                    break;
            }
            return result;
        }
        public static string TXCCodeConverToString(TXCommCode txCode)
        {
            string result = null;
            switch (txCode)
            {
                case TXCommCode.GetAllInfo:
                    result = "#GETINFO";
                    break;
                case TXCommCode.SetSensorsProp:
                    result = "#SETSENP";
                    break;
                case TXCommCode.SetArduinoProp:
                    result = "#SETARDP";
                    break;
                case TXCommCode.TcpConn:
                    result = "#TCPCONN";
                    break;
                case TXCommCode.Error:
                    result = "#ERRORXX";
                    break;
                default:
                    new NotImplementedException();
                    break;
            }
            return result;
        }

        /// <summary>
        /// 接收到的指令枚举
        /// Tcp
        /// 
        /// </summary>
        public enum RXCommCode
        {
            TcpDone,
            AllInfo,
            Update,
            ERROR
        }
        /// <summary>
        /// 发送的指令枚举
        /// </summary>
        public enum TXCommCode
        {
            TcpConn,
            GetAllInfo,
            SetSensorsProp,
            SetArduinoProp,
            Error,
        }
    }

}