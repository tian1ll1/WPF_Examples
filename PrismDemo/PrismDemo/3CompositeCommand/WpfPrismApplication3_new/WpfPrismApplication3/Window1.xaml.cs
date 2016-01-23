using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace WpfPrismApplication3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            tabControl1.Items.Add(new WpfControlLibrary1.UserControlView("OrdersToolBar.xaml.cs", "static void Main()"));
            tabControl1.Items.Add(new WpfControlLibrary1.UserControlView("OrdersCommands.cs", "public Datatable GetPoint()"));
            tabControl1.Items.Add(new WpfControlLibrary1.UserControlView("OrderModule.cs", "public interface IView"));
        }
    }
}