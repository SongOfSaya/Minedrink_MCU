﻿#pragma checksum "C:\Users\liute\Source\Repos\Minedrink\SMS_UWP\SMS_UWP\Views\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9EC94F0EB815DEC9C8A0E301EEE6F3E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS_UWP.Views
{
    partial class SettingsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Nullable<global::System.Boolean>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Nullable<global::System.Boolean>), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.CommandParameter = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class SettingsPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsPage_Bindings
        {
            private global::SMS_UWP.Views.SettingsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.RadioButton obj4;
            private global::Windows.UI.Xaml.Controls.RadioButton obj5;
            private global::Windows.UI.Xaml.Controls.RadioButton obj6;
            private global::Windows.UI.Xaml.Controls.Button obj8;

            private SettingsPage_obj1_BindingsTracking bindingsTracking;

            public SettingsPage_obj1_Bindings()
            {
                this.bindingsTracking = new SettingsPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        (this.obj3).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.VersionDescription = this.obj3.Text;
                                }
                            });
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj4).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ElementTheme = (global::Windows.UI.Xaml.ElementTheme)this.LookupConverter("EnumToBooleanConverter").ConvertBack(this.obj4.IsChecked, typeof(global::Windows.UI.Xaml.ElementTheme), "Light", null);
                                }
                            });
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ElementTheme = (global::Windows.UI.Xaml.ElementTheme)this.LookupConverter("EnumToBooleanConverter").ConvertBack(this.obj5.IsChecked, typeof(global::Windows.UI.Xaml.ElementTheme), "Dark", null);
                                }
                            });
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.RadioButton)target;
                        (this.obj6).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.ElementTheme = (global::Windows.UI.Xaml.ElementTheme)this.LookupConverter("EnumToBooleanConverter").ConvertBack(this.obj6.IsChecked, typeof(global::Windows.UI.Xaml.ElementTheme), "Default", null);
                                }
                            });
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        (this.obj8).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ContentControl.ContentProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewModel.BtnContent = (global::System.String)this.obj8.Content;
                                }
                            });
                        break;
                    default:
                        break;
                }
            }

            // ISettingsPage_Bindings

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

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SMS_UWP.Views.SettingsPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SMS_UWP.Views.SettingsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NameTextBlock(obj.NameTextBlock, phase);
                    }
                }
            }
            private void Update_ViewModel(global::SMS_UWP.ViewModels.SettingsViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_VersionDescription(obj.VersionDescription, phase);
                        this.Update_ViewModel_ElementTheme(obj.ElementTheme, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SwitchThemeCommand(obj.SwitchThemeCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_BtnContent(obj.BtnContent, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_BtnClickCommand(obj.BtnClickCommand, phase);
                    }
                }
            }
            private void Update_ViewModel_VersionDescription(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_ElementTheme(global::Windows.UI.Xaml.ElementTheme obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj4, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("EnumToBooleanConverter").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), "Light", null), null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj5, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("EnumToBooleanConverter").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), "Dark", null), null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj6, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("EnumToBooleanConverter").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), "Default", null), null);
                }
            }
            private void Update_ViewModel_SwitchThemeCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj4, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel_BtnContent(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_BtnClickCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj8, obj, null);
                }
            }
            private void Update_NameTextBlock(global::Windows.UI.Xaml.Controls.TextBlock obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NameTextBlock_Text(obj.Text, phase);
                    }
                }
            }
            private void Update_NameTextBlock_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj8, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
            private class SettingsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<SettingsPage_obj1_Bindings> WeakRefToBindingObj; 

                public SettingsPage_obj1_BindingsTracking(SettingsPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<SettingsPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SettingsPage_obj1_Bindings bindings;
                    if (WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::SMS_UWP.ViewModels.SettingsViewModel obj = sender as global::SMS_UWP.ViewModels.SettingsViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_VersionDescription(obj.VersionDescription, DATA_CHANGED);
                                bindings.Update_ViewModel_ElementTheme(obj.ElementTheme, DATA_CHANGED);
                                bindings.Update_ViewModel_BtnContent(obj.BtnContent, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "VersionDescription":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_VersionDescription(obj.VersionDescription, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ElementTheme":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_ElementTheme(obj.ElementTheme, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "BtnContent":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_BtnContent(obj.BtnContent, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::SMS_UWP.ViewModels.SettingsViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::SMS_UWP.ViewModels.SettingsViewModel obj)
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
            case 2:
                {
                    this.TitlePage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.NameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 10:
                {
                    this.WideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 11:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SettingsPage_obj1_Bindings bindings = new SettingsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
