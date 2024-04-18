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

        public LoginViewModel()
        {
            LoginCommand = this; // Set 'this' as the ICommand implementation
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
                CanExecuteChanged?.Invoke(this, EventArgs.Empty); // Manually raise CanExecuteChanged
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
                CanExecuteChanged?.Invoke(this, EventArgs.Empty); // Manually raise CanExecuteChanged
            }
        }

        public ICommand LoginCommand { get; } // Expose the ICommand interface

        public bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        public void Execute(object parameter)
        {
            // Here you would handle the login logic, possibly checking credentials against a database.
            // For demonstration, assume login is always successful if both fields are filled:
            if (Username == "admin" && Password == "admin") // Placeholder for actual authentication
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButton.OK, MessageBoxImage.Information);
                // Navigate to another page or change application state
            }
            else
            {
                MessageBox.Show("Login failed. Check your username and password.", "Authentication Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
