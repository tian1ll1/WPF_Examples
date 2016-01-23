// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.ComponentModel.Composition;
using System.Windows;

namespace PrismDemo
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    /// 
    [Export]
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }
    }
}
