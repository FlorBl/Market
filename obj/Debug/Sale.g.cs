﻿#pragma checksum "..\..\Sale.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C30302676E5B14E884A64DFB36C2AB0EBC118A0CEE6614A6E53F736D0FA9719"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FarmersMarket;
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


namespace FarmersMarket {
    
    
    /// <summary>
    /// Sale
    /// </summary>
    public partial class Sale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox custName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productId;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountKg;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox total;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calculateTotal;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Sale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmSale;
        
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
            System.Uri resourceLocater = new System.Uri("/FarmersMarket;component/sale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sale.xaml"
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
            this.custName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.productId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.amountKg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.total = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.calculateTotal = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Sale.xaml"
            this.calculateTotal.Click += new System.Windows.RoutedEventHandler(this.calculateTotal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.confirmSale = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\Sale.xaml"
            this.confirmSale.Click += new System.Windows.RoutedEventHandler(this.confirmSale_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

