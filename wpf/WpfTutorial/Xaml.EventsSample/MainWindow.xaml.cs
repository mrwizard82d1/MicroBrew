using System.Windows;
using System.Windows.Input;

namespace Xaml.EventsSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var position = e.GetPosition(this);
            MessageBox.Show($"You clicked me at ({position.X}, {position.Y}) in the grid (and main window)");
        }
    }
}