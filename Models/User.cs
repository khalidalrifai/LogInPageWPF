using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LogInPageWPF.Models
{
    public class User : INotifyPropertyChanged
    {
        // Private fields for storing user information
        private string _username;
        private string _password;
        private string _email;

        // Constructor [Not Used]
        public User()
        {
        }

        // A property for username
        public string Username
        {
            get => _username;           // Getter returns the current username
            set
            {
                _username = value;      // Setter updates the username
                OnPropertyChanged();    // Raises PropertyChanged event
            }
        }

        // A property for password
        public string Password
        {
            get => _password;           // Getter returns the current password
            set
            {
                _password = value;      // Setter updates the password
                OnPropertyChanged();    // Raises PropertyChanged event
            }
        }

        // A property for email
        public string Email
        {
            get => _email;              // Getter returns the current email
            set
            {
                _email = value;         // Setter updates the email
                OnPropertyChanged();    // Raises PropertyChanged event
            }
        }

        // Implementing INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        // Invoking the PropertyChanged event (Called when a property is set)
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
