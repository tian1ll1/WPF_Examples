﻿#pragma checksum "D:\Documents\Documents\项目\上海花旗\Prism\Prism4.1\Quickstarts\UIComposition\Shell\Views\ShellView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CED089D1B50E537852E01D3F04CC390C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace UIComposition.Shell.Views {
    
    
    public partial class ShellView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Canvas Banner;
        
        internal System.Windows.Controls.ContentControl LeftRegion;
        
        internal System.Windows.Controls.ContentControl MainRegion;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/UIComposition.Shell;component/Views/ShellView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Banner = ((System.Windows.Controls.Canvas)(this.FindName("Banner")));
            this.LeftRegion = ((System.Windows.Controls.ContentControl)(this.FindName("LeftRegion")));
            this.MainRegion = ((System.Windows.Controls.ContentControl)(this.FindName("MainRegion")));
        }
    }
}

