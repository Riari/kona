using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Kona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid outerContainer;
        TextBox input;

        public MainWindow()
        {
            InitializeComponent();
            outerContainer = (Grid)this.FindName("OuterContainer");
            input = (TextBox)this.FindName("Input");
            outerContainer.Visibility = Visibility.Hidden;

            CommandBinding toggleCommandBinding = new CommandBinding(
                Commands.Toggle, ExecutedToggleCommand, CanExecuteToggleCommand);

            this.CommandBindings.Add(toggleCommandBinding);
        }

        private void CanExecuteToggleCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExecutedToggleCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (outerContainer.Visibility == Visibility.Hidden)
            {
                outerContainer.Visibility = Visibility.Visible;
                input.Focus();
            }
            else
            {
                outerContainer.Visibility = Visibility.Hidden;
                input.Clear();
            }
        }
    }
}
