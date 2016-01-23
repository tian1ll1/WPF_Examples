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

using Microsoft.Win32;
using System.Windows.Markup;
using System.IO;

namespace DocumentCommands
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

        // Remember if we have unsaved changes.
        private bool m_IsDirty = false;

        // The name of the currently open file.
        private string m_FileName = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create the Close command here
            // just to show how it's done in code-behind.
            CommandBinding close_binding = new CommandBinding(
                ApplicationCommands.Close,
                DocumentClose,
                DocumentCloseAllowed);
            this.CommandBindings.Add(close_binding);
        }

        // Return True if we can perform the New action.
        private void DocumentNewAllowed(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (!m_IsDirty);
        }

        // Perform the New action.
        private void DocumentNew(Object sender, ExecutedRoutedEventArgs e)
        {
            // Remove any existing controls on the Canvas.
            cvsDrawing.Children.Clear();

            // Display the canvas.
            borDrawing.Visibility = Visibility.Visible;
            m_FileName = null;
        }

        // Return True if we can perform the Open action.
        private void DocumentOpenAllowed(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (!m_IsDirty);
        }

        // Perform the Open action.
        private void DocumentOpen(Object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".rects";
            dlg.Filter = "Rectangle Files (.rects)|*.rects|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                // Open the file.
                XamlReader reader = new XamlReader();
                FileStream fs = File.OpenRead(dlg.FileName);
                try
                {
                    // Read the Canvas stored in the file.
                    Canvas new_canvas = (Canvas)XamlReader.Load(fs);

                    // Display the new Canvas.
                    new_canvas.Name = "cvsDrawing";
                    new_canvas.MouseDown += cvsDrawing_MouseDown;
                    new_canvas.MouseMove += cvsDrawing_MouseMove;
                    new_canvas.MouseUp   += cvsDrawing_MouseUp;

                    cvsDrawing = new_canvas;
                    borDrawing.Child = new_canvas;

                    borDrawing.Visibility = Visibility.Visible;
                    m_FileName = dlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Error Reading File",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        // Return True if we can perform the Save action.
        private void DocumentSaveAllowed(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = ((m_FileName != null) && m_IsDirty);
        }

        // Perform the Save action.
        private void DocumentSave(Object sender, ExecutedRoutedEventArgs e)
        {
            // See if we have a file name.
            if (m_FileName == null)
            {
                // Invoke the Save As command.
                ApplicationCommands.SaveAs.Execute(null, this);
            }

            // Save.
            FileStream fs = File.OpenWrite(m_FileName);
            try
            {
                // Save.
                XamlWriter.Save(cvsDrawing, fs);

                // There are no unsaved changes.
                m_IsDirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error Saving File",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                fs.Close();
            }
        }

        // Return True if we can perform the SaveAs action.
        private void DocumentSaveAsAllowed(Object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (m_IsDirty);
        }

        // Perform the SaveAs action.
        private void DocumentSaveAs(Object sender, ExecutedRoutedEventArgs e)
        {
            // Get the file name.
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".rects";
            dlg.Filter = "Rectangle Files (.rects)|*.rects|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                // Save the selected file name.
                m_FileName = dlg.FileName;

                // Invoke the Save command.
                ApplicationCommands.Save.Execute(null, this);
            }
        }

        // Return True if we can perform the Close action.
        private void DocumentCloseAllowed(Object sender, CanExecuteRoutedEventArgs e)
        {
            if (cvsDrawing == null)
            {
                e.CanExecute = false;
            } else {
                // Allow if there is a file open.
                e.CanExecute = (borDrawing.Visibility == Visibility.Visible);
            }
        }

        // Perform the Close action.
        private void DocumentClose(Object sender, ExecutedRoutedEventArgs e)
        {
            // Make sure it's safe to close.
            if (m_IsDirty)
            {
                if (MessageBox.Show("You have unsaved changes. Are you sure you want to close this document?",
                    "Unsaved Changes", MessageBoxButton.YesNo, MessageBoxImage.Exclamation)
                        == MessageBoxResult.No) return;
            }

            // Close it.
            borDrawing.Visibility = Visibility.Hidden;
            m_FileName = null;
            m_IsDirty = false;
        }

#region "Drawing Commands"
        private Rectangle m_NewRectangle = null;
        private Point m_StartPoint;

        private void cvsDrawing_MouseDown(Object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (m_NewRectangle != null) return;

            m_StartPoint = Mouse.GetPosition((IInputElement)sender);
            m_NewRectangle = new Rectangle{Width = 0, Height = 0};
            Canvas.SetLeft(m_NewRectangle, m_StartPoint.X);
            Canvas.SetTop(m_NewRectangle, m_StartPoint.Y);
            
            // Pick a random color.
            Random rand = new Random();
            m_NewRectangle.Fill =
                new SolidColorBrush(Color.FromArgb(
                    255,
                    (byte)rand.Next(256),
                    (byte)rand.Next(256),
                    (byte)rand.Next(256)));
            m_NewRectangle.Stroke = Brushes.Black;

            // Add the Rectangle to the Canvas.
            cvsDrawing.Children.Add(m_NewRectangle);

            // Remember we've modified the file.
            m_IsDirty = true;
        }

        private void cvsDrawing_MouseMove(Object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (m_NewRectangle == null) return;

            Point pt = Mouse.GetPosition((IInputElement)sender);

            Canvas.SetLeft(m_NewRectangle, Math.Min(m_StartPoint.X, pt.X));
            Canvas.SetTop(m_NewRectangle, Math.Min(m_StartPoint.Y, pt.Y));
            m_NewRectangle.Width = Math.Abs(pt.X - m_StartPoint.X);
            m_NewRectangle.Height = Math.Abs(pt.Y - m_StartPoint.Y);
        }

        private void cvsDrawing_MouseUp(Object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (m_NewRectangle == null) return;
            m_NewRectangle = null;
        }
#endregion // Drawing Commands

        // Check for unsaved changes.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (m_IsDirty)
            {
                e.Cancel =
                    (MessageBox.Show("You have unsaved changes. Are you sure you want to quit?",
                        "Unsaved Changes", MessageBoxButton.YesNo, MessageBoxImage.Exclamation)
                            == MessageBoxResult.No);
            }
        }
    }
}