﻿#pragma checksum "C:\Users\Stephanie Allen\Desktop\Let It Out\Let It Out\App1\AboutPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0866231E17CE3A57CC59C5EC2D1D1F8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class AboutPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.NavPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\AboutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.HomepageBtnClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.MainMenuBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 16 "..\..\..\AboutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MainMenuBtn).Click += this.SelfHelpBtnClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.AboutBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 17 "..\..\..\AboutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AboutBtn).Click += this.AboutBtnClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.InstructionsBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\AboutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.InstructionsBtn).Click += this.InstructionBtnClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.InfoBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\AboutPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.InfoBtn).Click += this.InfoBtnClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.ContextPanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
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
            return returnValue;
        }
    }
}

