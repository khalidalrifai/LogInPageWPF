using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace LogInPageWPF.ViewModels
{
    public class MonthViewModel : INotifyPropertyChanged
    {
        private DateTime _currentDate;

        public MonthViewModel()
        {
            CurrentDate = DateTime.Today;                                       // This is to set the initial value for CurrentDate
            PrevMonthCommand = new RelayCommand(_ => MoveToPreviousMonth());    // Command for moving to the previous month
            NextMonthCommand = new RelayCommand(_ => MoveToNextMonth());        // Command for moving to the next month
            GoToTodayCommand = new RelayCommand(_ => MoveToToday());            // Command for resetting to today's date
        }

        // Property for CurrentDate that notifies when it changes
        public DateTime CurrentDate
        {
            get => _currentDate;
            set
            {
                if (_currentDate != value)  // Checking if the value is different from the current date
                {
                    _currentDate = value;
                    OnPropertyChanged();  // Notifying that CurrentDate has changed
                }
            }
        }

        // ICommand properties is for binding commands in XAML
        public ICommand PrevMonthCommand { get; private set; }
        public ICommand NextMonthCommand { get; private set; }
        public ICommand GoToTodayCommand { get; private set; }

        // To move the calendar to the previous month
        private void MoveToPreviousMonth()
        {
            CurrentDate = CurrentDate.AddMonths(-1);
        }

        // To move the calendar to the next month
        private void MoveToNextMonth()
        {
            CurrentDate = CurrentDate.AddMonths(1);
        }

        // To reset the calendar to today's date
        private void MoveToToday()
        {
            CurrentDate = DateTime.Today;
        }

        // Event and method for property changed notifications
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
