using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Common;
using System.Windows.Input;
using System.Windows;

namespace WpfControlLibrary1
{
    public class UserControlViewModel : INotifyPropertyChanged
    {
        public UserControlView View { get; set; }

        public DelegateCommand<object> SaveCommand { get; private set; }

        public ICommand CloseCommand { get; private set; }
        public ICommand TextChangedCommand { get; private set; }

        public UserControlViewModel()
        {
            TextChangedCommand = new DelegateCommand<object>(OnTextChanged, args => true);

            SaveCommand = new DelegateCommand<object>(OnSave, args => true);
            SaveCommand.IsActive = false;

            CloseCommand = new DelegateCommand<object>(OnClose, args => true);

            GlobalCommands.MyCompositeCommand.RegisterCommand(SaveCommand);
            
            //Microsoft.Practices.Prism.Commands.CompositeCommand cmp;
            //cmp.RegisterCommand(SaveCommand);


        }

        public UserControlViewModel(string fileName, string fileText)
        {
            this.FileName = fileName;
            this.FileText = fileText;
            this.IsTextChanged = false;

            TextChangedCommand = new DelegateCommand<object>(OnTextChanged, args => true);

            SaveCommand = new DelegateCommand<object>(OnSave, args => true);
            SaveCommand.IsActive = false;

            CloseCommand = new DelegateCommand<object>(OnClose, args => true);

            GlobalCommands.MyCompositeCommand.RegisterCommand(SaveCommand);
        }

        public void OnSave(object obj)
        {
            this.IsTextChanged = false;
            SaveCommand.IsActive = false;

            MessageBox.Show("Save Data");
        }

        public void OnClose(object obj)
        {
            GlobalCommands.MyCompositeCommand.UnregisterCommand(SaveCommand);

            //这里要使用Prism的Event机制通知主View把当前View从TabControl中移除，限于时间，就不做下去了
         
        }

        public void OnTextChanged(object obj)
        {
            this.IsTextChanged = true;
            SaveCommand.IsActive = true;
        }

        #region members

        private string fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                if (fileName != value)
                {
                    fileName = value;
                    OnPropertyChanged("FileName");
                }
            }
        }

        private string fileText;
        public string FileText
        {
            get
            {
                return fileText;
            }
            set
            {
                if (fileText != value)
                {
                    fileText = value;
                    OnPropertyChanged("FileText");
                }
            }
        }

        public bool isTextChanged;
        public bool IsTextChanged
        {
            get
            {
                return isTextChanged;
            }
            set
            {
                if (isTextChanged != value)
                {
                    isTextChanged = value;
                    OnPropertyChanged("IsTextChanged");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}