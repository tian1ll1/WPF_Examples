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

namespace RuntimeEventHandlers
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
            // Attach the event handlers.
            scrRed.ValueChanged += scrRed_ValueChanged;
            scrGreen.ValueChanged += scrGreen_ValueChanged;
            scrBlue.ValueChanged += scrBlue_ValueChanged;
            txtRed.TextChanged += txtRed_TextChanged;
            txtGreen.TextChanged += txtGreen_TextChanged;
            txtBlue.TextChanged += txtBlue_TextChanged;
            btnApply.Click += btnApply_Click;
		}

        // A ScrollBar has been changed. Update the corresponding TextBox.
        private void scrRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtRed == null) return;
            txtRed.Text = ((int)scrRed.Value).ToString();
            ShowSample();
        }
        private void scrGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtGreen == null) return;
            txtGreen.Text = ((int)scrGreen.Value).ToString();
            ShowSample();
        }
        private void scrBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtBlue == null) return;
            txtBlue.Text = ((int)scrBlue.Value).ToString();
            ShowSample();
        }

        // A TextBox has been changed. Update the corresponding ScrollBar.
        private void txtRed_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Keep the value within bounds.
            int value;
            try
            {
                value = int.Parse(txtRed.Text);
            }
            catch
            {
                value = 0;
            }

            if (value < 0) value = 0;
            if (value > 255) value = 255;
            txtRed.Text = value.ToString();

            if (scrRed == null) return;
            scrRed.Value = value;
            ShowSample();
        }
        private void txtGreen_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Keep the value within bounds.
            int value;
            try
            {
                value = int.Parse(txtGreen.Text);
            }
            catch
            {
                value = 0;
            }

            if (value < 0) value = 0;
            if (value > 255) value = 255;
            txtGreen.Text = value.ToString();

            if (scrGreen == null) return;
            scrGreen.Value = value;
            ShowSample();
        }
        private void txtBlue_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Keep the value within bounds.
            int value;
            try
            {
                value = int.Parse(txtBlue.Text);
            }
            catch
            {
                value = 0;
            }

            if (value < 0) value = 0;
            if (value > 255) value = 255;
            txtBlue.Text = value.ToString();

            if (scrBlue == null) return;
            scrBlue.Value = value;
            ShowSample();
        }

        // Display a sample of the color.
        private void ShowSample()
        {
            if (borSample == null) return;

            byte r, g, b;
            try
            {
                r = byte.Parse(txtRed.Text);
            }
            catch
            {
                r = 0;
            }
            try
            {
                g = byte.Parse(txtGreen.Text);
            }
            catch
            {
                g = 0;
            }
            try
            {
                b = byte.Parse(txtBlue.Text);
            }
            catch
            {
                b = 0;
            }
            borSample.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
        }

        // Set the form's background to the sample color.
        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            this.Background = borSample.Background;
        }
    }
}