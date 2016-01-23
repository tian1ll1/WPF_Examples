using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace WpfControlLibrary1
{
    public class CommandBehaviorBase<T>
        where T : Control
    {
        private ICommand command;

        public ICommand Command
        {
            get { return command; }
            set
            {
                this.command = value;
            }
        }

        protected virtual void ExecuteCommand()
        {
            if (this.Command != null)
            {
                this.Command.Execute(null);
            }
        }
    }
}