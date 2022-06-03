using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Kona.Interop;

namespace Kona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int ExpandedHeight = 600;

        public MainWindow()
        {
            InitializeComponent();

            Input.Clear();
            Input.Focus();

            KeyBinding HideWindowKeyBinding = new KeyBinding(
                ((ViewModel)this.DataContext).HideWindowCommand,
                Key.Escape,
                ModifierKeys.None);

            InputBindings.Add(HideWindowKeyBinding);

            WindowBlur.SetIsEnabled(this, true);
        }

        private void OnInputChanged(object sender, TextChangedEventArgs args)
        {
            if (Input.Text.Length > 0)
            {
                ResultsGrid.Visibility = Visibility.Visible;
                Height = ExpandedHeight;
                MainGrid.Height = ExpandedHeight;
                MainBorder.Height = ExpandedHeight;
            }
            else
            {
                ResultsGrid.Visibility = Visibility.Hidden;
                Height = Input.Height;
                MainGrid.Height = Input.Height;
                MainBorder.Height = Input.Height;
            }
        }

        private void OnActivated(object? sender, EventArgs args)
        {
            Focus();
            Input.Focus();
            Top = SystemParameters.PrimaryScreenHeight / 3;
        }

        private void OnDeactivated(object? sender, EventArgs args)
        {
            Input.Clear();
        }
    }
}
