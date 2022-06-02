using System.Windows.Input;

namespace Kona
{
    public static class Commands
    {
        public static readonly RoutedCommand Toggle = new RoutedCommand(
            "Toggle",
            typeof(Commands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.Space, ModifierKeys.Alt)
            });
    }
}
