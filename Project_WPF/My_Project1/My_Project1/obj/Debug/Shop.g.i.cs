﻿#pragma checksum "..\..\Shop.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C53AD64E0A17D9E6029611C498744C3A0B040B0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using My_Project1;
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


namespace My_Project1 {
    
    
    /// <summary>
    /// Shop
    /// </summary>
    public partial class Shop : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miBackSignIn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miCLose;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miHelp;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSubject;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOrderTable;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbCountPainer;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDelete;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbPanier;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\Shop.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btFormalizeOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/My_Project1;component/shop.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Shop.xaml"
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
            this.miBackSignIn = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\Shop.xaml"
            this.miBackSignIn.Click += new System.Windows.RoutedEventHandler(this.miBackSignIn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miCLose = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\Shop.xaml"
            this.miCLose.Click += new System.Windows.RoutedEventHandler(this.miCLose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.miHelp = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\Shop.xaml"
            this.miHelp.Click += new System.Windows.RoutedEventHandler(this.miHelp_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSubject = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\Shop.xaml"
            this.cbSubject.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSubject_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgOrderTable = ((System.Windows.Controls.DataGrid)(target));
            
            #line 73 "..\..\Shop.xaml"
            this.dgOrderTable.Loaded += new System.Windows.RoutedEventHandler(this.dgOrderTable_Loaded);
            
            #line default
            #line hidden
            
            #line 73 "..\..\Shop.xaml"
            this.dgOrderTable.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.dgOrderTable_MouseUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.tbCountPainer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btDelete = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\Shop.xaml"
            this.btDelete.Click += new System.Windows.RoutedEventHandler(this.btDelete_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbPanier = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.btFormalizeOrder = ((System.Windows.Controls.Button)(target));
            
            #line 97 "..\..\Shop.xaml"
            this.btFormalizeOrder.Click += new System.Windows.RoutedEventHandler(this.btFormalizeOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

