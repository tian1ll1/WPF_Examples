using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultiWindowResources
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void rectAddUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            winAddUser win = new winAddUser();
            win.Owner = this;
            win.Show();
        }
        private void rectEditUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            winEditUser win = new winEditUser();
            win.Owner = this;
            win.Show();
        }
        private void rectDeleteUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            winDeleteUser win = new winDeleteUser();
            win.Owner = this;
            win.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Window win in this.OwnedWindows)
            {
                win.Close();
            }
        }
    }
}