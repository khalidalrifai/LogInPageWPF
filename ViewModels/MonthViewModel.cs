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
            CurrentDate = DateTime.Today;
            PrevMonthCommand = new RelayCommand(_ => MoveToPreviousMonth());
            NextMonthCommand = new RelayCommand(_ => MoveToNextMonth());
            GoToTodayCommand = new RelayCommand(_ => MoveToToday());
        }

        public DateTime CurrentDate
        {
            get => _currentDate;
            set
            {
                if (_currentDate != value)
                {
                    _currentDate = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand PrevMonthCommand { get; private set; }
        public ICommand NextMonthCommand { get; private set; }
        public ICommand GoToTodayCommand { get; private set; }

        private void MoveToPreviousMonth()
        {
            CurrentDate = CurrentDate.AddMonths(-1);
        }

        private void MoveToNextMonth()
        {
            CurrentDate = CurrentDate.AddMonths(1);
        }

        private void MoveToToday()
        {
            CurrentDate = DateTime.Today;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
