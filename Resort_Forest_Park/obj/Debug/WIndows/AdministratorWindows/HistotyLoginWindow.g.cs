#pragma checksum "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4D09D14257C5BF2548D55DBC73F025B87EC0FC147CA0775D1BB8D50B36175648"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Resort_Forest_Park.WIndows.AdministratorWindows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Resort_Forest_Park.WIndows.AdministratorWindows {
    
    
    /// <summary>
    /// HistotyLoginWindow
    /// </summary>
    public partial class HistotyLoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmLogin;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgHistory;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Resort_Forest_Park;component/windows/administratorwindows/histotyloginwindow.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CmLogin = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
            this.CmLogin.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmLogin_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Clear_click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\..\WIndows\AdministratorWindows\HistotyLoginWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DgHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

