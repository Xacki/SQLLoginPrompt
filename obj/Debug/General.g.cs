#pragma checksum "..\..\General.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "607D3FECD94108F46CE68A47A9018B044013DC33416E8E735FA072557D331406"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SQLLoginPrompt {
    
    
    /// <summary>
    /// General
    /// </summary>
    public partial class General : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid postsGrid;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox header_txt;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox text_txt;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\General.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox date_txt;
        
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
            System.Uri resourceLocater = new System.Uri("/SQLLoginPrompt;component/general.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\General.xaml"
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
            
            #line 38 "..\..\General.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 50 "..\..\General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtMinimaze);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 55 "..\..\General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtClose);
            
            #line default
            #line hidden
            return;
            case 4:
            this.postsGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 74 "..\..\General.xaml"
            this.postsGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.postsGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.header_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.text_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.date_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 122 "..\..\General.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

