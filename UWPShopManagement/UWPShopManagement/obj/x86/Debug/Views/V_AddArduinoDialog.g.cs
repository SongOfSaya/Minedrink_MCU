﻿#pragma checksum "C:\Users\liute\Source\Repos\Minedrink\UWPShopManagement\UWPShopManagement\Views\V_AddArduinoDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94ABB501B3B1EE271CD3DC96059379D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPShopManagement.Views
{
    partial class V_AddArduinoDialog : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ContentDialog_SecondaryButtonCommand(global::Windows.UI.Xaml.Controls.ContentDialog obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.SecondaryButtonCommand = value;
            }
            public static void Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class V_AddArduinoDialog_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IV_AddArduinoDialog_Bindings
        {
            private global::UWPShopManagement.Views.V_AddArduinoDialog dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::System.WeakReference obj1;
            private global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;
            private global::Windows.UI.Xaml.Controls.TextBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            private V_AddArduinoDialog_obj1_BindingsTracking bindingsTracking;

            public V_AddArduinoDialog_obj1_Bindings()
            {
                this.bindingsTracking = new V_AddArduinoDialog_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 1: // Views\V_AddArduinoDialog.xaml line 1
                        this.obj1 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ContentDialog)target);
                        break;
                    case 2: // Views\V_AddArduinoDialog.xaml line 22
                        this.obj2 = (global::Microsoft.Xaml.Interactions.Core.InvokeCommandAction)target;
                        break;
                    case 3: // Views\V_AddArduinoDialog.xaml line 32
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj3).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.IPTextBox = this.obj3.Text;
                            }
                        };
                        break;
                    case 4: // Views\V_AddArduinoDialog.xaml line 33
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj4).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                        {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.PortTextBox = this.obj4.Text;
                            }
                        };
                        break;
                    case 6: // Views\V_AddArduinoDialog.xaml line 36
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IV_AddArduinoDialog_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::UWPShopManagement.Views.V_AddArduinoDialog)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UWPShopManagement.Views.V_AddArduinoDialog obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::UWPShopManagement.ViewModels.VM_ArduinoManagement obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DialogCancelCommand(obj.DialogCancelCommand, phase);
                        this.Update_ViewModel_DialogSubmitCommand(obj.DialogSubmitCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IPTextBox(obj.IPTextBox, phase);
                        this.Update_ViewModel_PortTextBox(obj.PortTextBox, phase);
                        this.Update_ViewModel_ConnectInfo(obj.ConnectInfo, phase);
                    }
                }
            }
            private void Update_ViewModel_DialogCancelCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\V_AddArduinoDialog.xaml line 1
                    if ((this.obj1.Target as global::Windows.UI.Xaml.Controls.ContentDialog) != null)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentDialog_SecondaryButtonCommand((this.obj1.Target as global::Windows.UI.Xaml.Controls.ContentDialog), obj, null);
                    }
                }
            }
            private void Update_ViewModel_DialogSubmitCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\V_AddArduinoDialog.xaml line 22
                    XamlBindingSetters.Set_Microsoft_Xaml_Interactions_Core_InvokeCommandAction_Command(this.obj2, obj, null);
                }
            }
            private void Update_ViewModel_IPTextBox(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\V_AddArduinoDialog.xaml line 32
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_PortTextBox(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\V_AddArduinoDialog.xaml line 33
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_ConnectInfo(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\V_AddArduinoDialog.xaml line 36
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class V_AddArduinoDialog_obj1_BindingsTracking
            {
                private global::System.WeakReference<V_AddArduinoDialog_obj1_Bindings> weakRefToBindingObj; 

                public V_AddArduinoDialog_obj1_BindingsTracking(V_AddArduinoDialog_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<V_AddArduinoDialog_obj1_Bindings>(obj);
                }

                public V_AddArduinoDialog_obj1_Bindings TryGetBindingObject()
                {
                    V_AddArduinoDialog_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    V_AddArduinoDialog_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::UWPShopManagement.ViewModels.VM_ArduinoManagement obj = sender as global::UWPShopManagement.ViewModels.VM_ArduinoManagement;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_IPTextBox(obj.IPTextBox, DATA_CHANGED);
                                bindings.Update_ViewModel_PortTextBox(obj.PortTextBox, DATA_CHANGED);
                                bindings.Update_ViewModel_ConnectInfo(obj.ConnectInfo, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IPTextBox":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IPTextBox(obj.IPTextBox, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "PortTextBox":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_PortTextBox(obj.PortTextBox, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ConnectInfo":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ConnectInfo(obj.ConnectInfo, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::UWPShopManagement.ViewModels.VM_ArduinoManagement cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::UWPShopManagement.ViewModels.VM_ArduinoManagement obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\V_AddArduinoDialog.xaml line 1
                {
                    this.AddAduDialog = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                }
                break;
            case 3: // Views\V_AddArduinoDialog.xaml line 32
                {
                    this.ArduinoIPTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\V_AddArduinoDialog.xaml line 33
                {
                    this.ArduinoPortTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Views\V_AddArduinoDialog.xaml line 34
                {
                    this.ArduinoSaveCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 6: // Views\V_AddArduinoDialog.xaml line 36
                {
                    this.AddInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\V_AddArduinoDialog.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)target;
                    V_AddArduinoDialog_obj1_Bindings bindings = new V_AddArduinoDialog_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

