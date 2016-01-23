using System.Windows.Controls;
using Microsoft.Practices.Prism.Mvvm;

namespace PrismDemo.Mvvm.Views
{
    /// <summary>
    /// Interaction logic for PrismKeyConcepts.xaml
    /// </summary>
    public partial class PrismKeyConcepts : UserControl, IView
    {
        public PrismKeyConcepts()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, System.Windows.RoutedEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;

            if (stackPanel != null)
            {
                System.Windows.Forms.MessageBox.Show("Handled on StackPanel!");
            }

            Button button = sender as Button;
            if (button != null)
            {
                System.Windows.Forms.MessageBox.Show("Handled on Button!");
            }
        }
    }
}
