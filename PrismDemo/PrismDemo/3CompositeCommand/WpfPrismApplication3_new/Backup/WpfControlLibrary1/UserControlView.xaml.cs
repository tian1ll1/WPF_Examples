using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControlView.xaml
    /// </summary>
    public partial class UserControlView : TabItem
    {
        public UserControlView()
        {
            InitializeComponent();
        }

        public UserControlView(String header, string fileText)
            : this()
        {
            UserControlViewModel viewModel = new UserControlViewModel(header, fileText);
            
            this.ViewModel = viewModel;
            this.ViewModel.View = this;
        }

        public UserControlViewModel ViewModel
        {
            get
            {
                return this.DataContext as UserControlViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
    }
}