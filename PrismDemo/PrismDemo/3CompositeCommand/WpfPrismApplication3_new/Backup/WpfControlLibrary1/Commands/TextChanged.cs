using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Controls;

namespace WpfControlLibrary1
{
    public static class TextChanged
    {
        private static readonly DependencyProperty TextChangedCommandBehaviorProperty = DependencyProperty.RegisterAttached(
            "TextChangedCommandBehavior",
            typeof(TextBoxTextChangedCommandBehavior),
            typeof(TextChanged),
            null);

        public static readonly DependencyProperty CommandProperty = DependencyProperty.RegisterAttached(
            "Command",
            typeof(ICommand),
            typeof(TextChanged),
            new PropertyMetadata(OnSetCommandCallback));

        public static void SetCommand(TextBox textBox, ICommand command)
        {
            textBox.SetValue(CommandProperty, command);
        }

        public static ICommand GetCommand(TextBox textBox)
        {
            return textBox.GetValue(CommandProperty) as ICommand;
        }

        private static void OnSetCommandCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = dependencyObject as TextBox;
            if (textBox != null)
            {
                TextBoxTextChangedCommandBehavior behavior = GetOrCreateBehavior(textBox);
                behavior.Command = e.NewValue as ICommand;
            }
        }

        private static TextBoxTextChangedCommandBehavior GetOrCreateBehavior(TextBox textBox)
        {
            TextBoxTextChangedCommandBehavior behavior = textBox.GetValue(TextChangedCommandBehaviorProperty) as TextBoxTextChangedCommandBehavior;
            if (behavior == null)
            {
                behavior = new TextBoxTextChangedCommandBehavior(textBox);
                textBox.SetValue(TextChangedCommandBehaviorProperty, behavior);
            }

            return behavior;
        }
    }
}