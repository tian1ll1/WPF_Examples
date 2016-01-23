using System;
using System.Collections.Generic;
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
	/// Interaction logic for winDeleteUser.xaml
	/// </summary>
	public partial class winDeleteUser : Window
	{
		public winDeleteUser()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void rectOk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        private void rectCancel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}