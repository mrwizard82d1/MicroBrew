using System.Windows;
using System.Windows.Navigation;

namespace TextBlockHyperlinkSample
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

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // Navigate to the specified (absolute) Uri.
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}