using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LogInPageWPF.Views
{

    public partial class LoginPage : UserControl
    {
        private TextBox usernameTextBox;
        private PasswordBox passwordBox;

        public LoginPage()
        {
            InitializeComponent();
            usernameTextBox = (TextBox)FindName("usernameTextBox");
            passwordBox = (PasswordBox)FindName("passwordBox");
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            // Simple validation to ensure that username and password are entered.
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PerformLogin();
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
