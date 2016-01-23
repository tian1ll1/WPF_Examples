using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Controls;

namespace WpfControlLibrary1
{
    public class TextBoxTextChangedCommandBehavior : CommandBehaviorBase<TextBox>
    {
        public TextBoxTextChangedCommandBehavior(TextBox obj)
        {
            obj.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ExecuteCommand();
        }
    }
}