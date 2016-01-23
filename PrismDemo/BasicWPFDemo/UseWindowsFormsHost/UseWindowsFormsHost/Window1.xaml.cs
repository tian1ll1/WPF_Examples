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

namespace UseWindowsFormsHost
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			this.InitializeComponent();

            this.Initial_Data();

			// Insert code required on object creation below this point.
		}

        private void Initial_Data()
        {
            this.cmb.DataSource = new string[] { "a", "b", "c"};
        }

        // Enable the DateTimePicker so the user can make an appointment.
        private void chkMakeAppt_Checked(object sender, RoutedEventArgs e)
        {
            dtpAppt.Enabled = true;
        }

        // Disable the DateTimePicker.
        private void chkMakeAppt_Unchecked(object sender, RoutedEventArgs e)
        {
            dtpAppt.Enabled = false;
        }
	}
}