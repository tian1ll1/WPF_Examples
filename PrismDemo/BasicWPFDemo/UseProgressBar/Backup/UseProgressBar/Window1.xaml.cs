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

using System.ComponentModel;
using System.Threading;

namespace UseProgressBar
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
        // The BackgroundWorker that will perform the long task.
        private BackgroundWorker m_BackgroundWorker;
        
        public Window1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.

            // Prepare the BackgroundWorker.
            m_BackgroundWorker = new BackgroundWorker();
            m_BackgroundWorker.WorkerReportsProgress = true;
            m_BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            m_BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            m_BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        // Start the long task.
        private void btnDoSomething_Click(object sender, RoutedEventArgs e)
        {
            // Display the progress controls.
            prgWorking.Value = 0;
            prgWorking.Visibility = Visibility.Visible;
            lblWorking.Visibility = Visibility.Visible;
            btnDoSomething.Visibility = Visibility.Hidden;

            // Asynchronously start the routine
            // that does the long calculation.
            m_BackgroundWorker.RunWorkerAsync();
        }

        // Simulate a long task.
        private void BackgroundWorker_DoWork(Object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int value = 0;
            Random rand = new Random();
            while (value < 100)
            {
                // Wait a little while.
                Thread.Sleep(200);

                // Add a bit to the progress.
                value += rand.Next(10, 20);

                // Update the UI thread.
                Console.WriteLine("Worker: " + value);
                m_BackgroundWorker.ReportProgress(value);
            }
        }

        // Display the progress.
        private void BackgroundWorker_ProgressChanged(Object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            prgWorking.Value = e.ProgressPercentage;
        }

        // Reset the UI.
        private void BackgroundWorker_RunWorkerCompleted(Object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            prgWorking.Visibility = Visibility.Hidden;
            lblWorking.Visibility = Visibility.Hidden;
            btnDoSomething.Visibility = Visibility.Visible;
        }
    }
}