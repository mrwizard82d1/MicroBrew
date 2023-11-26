using System.Windows;

namespace ResourcesInCodeBehind
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

        private void ButtonClickMe_Click(object sender, RoutedEventArgs e)
        {
            switch (ListBoxResult.Items.IsEmpty)
            {
                case true:
                    ListBoxResult.Items.Add(PanelMain.FindResource("StringPanel").ToString());
                    ListBoxResult.Items.Add(FindResource("StringWindow").ToString());
                    ListBoxResult.Items.Add(Application.Current.FindResource("StringApp")?.ToString());
                    break;
            }
        }
    }
}