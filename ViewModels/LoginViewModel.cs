using System;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace LogInPageWPF.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged, ICommand
    {
        private string _username;
        private string _password;

        public event EventHandler CanExecuteChanged;

        // Constructor
        public LoginViewModel()
        {
            LoginCommand = this; // To set 'this' as the ICommand implementation
        }

        // Username property
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
                CanExecuteChanged?.Invoke(this, EventArgs.Empty); // Notify command can execute state may have changed
            }
        }

        // Password property
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
                CanExecuteChanged?.Invoke(this, EventArgs.Empty); // Notify command can execute state may have changed
            }
        }

        // Expose the ICommand interface implementation
        public ICommand LoginCommand { get; }

        // Determine if the command can execute
        public bool CanExecute(object parameter)
        {
            // Command can execute if neither username nor password are empty
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        // Execute login command
        public void Execute(object parameter)
        {
            // Placeholder for actual authentication logic
            if (Username == "admin" && Password == "admin") // Simple check for demonstration
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
                // Here we can navigate to another page or change the application state
            }
            else
            {
                MessageBox.Show("Login failed. Check your username and password.", "Authentication Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Event and method to support property change notification
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
