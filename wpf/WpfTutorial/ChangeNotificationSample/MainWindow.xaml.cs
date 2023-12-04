using System.Collections.Generic;
using System.Windows;

namespace ChangeNotificationSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private List<User> _users = new();
        
        public MainWindow()
        {
            InitializeComponent();

            _users.Add(new User { Name = "John Doe" });
            _users.Add(new User { Name = "Jane Doe" });

            LblUsers.ItemsSource = _users;
        }

        private void BtnAddUser_OnClick(object sender, RoutedEventArgs e)
        {
            _users.Add(new User { Name = "New User" });
        }

        private void BtnChangeUser_OnClick(object sender, RoutedEventArgs e)
        {
            if (LblUsers.SelectedItem != null)
            {
                ((LblUsers.SelectedItem as User)!).Name = "Random Name";
            }
        }

        private void BtnDeleteUser_OnClick(object sender, RoutedEventArgs e)
        {
            if (LblUsers.SelectedItem != null)
            {
                _users.Remove((LblUsers.SelectedItem as User)!);
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}