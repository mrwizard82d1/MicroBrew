using System.Diagnostics;

namespace DataContextSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            // Sets the `DataContext` property of this window to be this window itself.
            // NOTE: By default `DataContext` is `null` if it is not set.
            Debug.Assert(DataContext == null);
            DataContext = this;
        }
    }
}