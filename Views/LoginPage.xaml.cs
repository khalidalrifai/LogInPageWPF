using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LogInPageWPF.Views
{
    public partial class LoginPage : UserControl
    {
        // The typical constructor for LoginPage. It initializes the component which ties the backend to the designed XAML frontend.
        public LoginPage()
        {
            InitializeComponent();
        }

        // Event handler for the Login button
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Calls the PerformLogin method when the login button is clicked
            // NOTE: This method is just very basic. During the real implementation, we need to connect to a backend service to verify user credentials.
            // Thus, we must replace the placeholder logic with calls to authentication services.
            PerformLogin();
        }

        // Method that handles the login functionality
        private void PerformLogin()
        {
            // This checks if username or password fields are empty
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                // This is to show a message box if either field is empty
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;

                // NOTE: This is just basic validation, we can add more complicated checks, such as password strength in a case of sign up etc.
            }

            // A placeholder for successful login;
            MessageBox.Show("Login successful!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);

            // According to our chat, we did not want to make a Sign Up page. However, here we can add navigation to another page such as sign up or update the application's state
        }

        // Event handler for pressing the Enter key while in the PasswordBox
        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If the Enter key is pressed, attempt to perform login
            if (e.Key == Key.Enter)
            {
                PerformLogin();
            }
        }

        // Event handler for the Sign Up button click
        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            // This will shows a message box as a placeholder for navigation to a signup page (Ir doesn't exist)
            MessageBox.Show("Navigate to sign up page.", "Sign Up", MessageBoxButton.OK);
        }
    }
}
