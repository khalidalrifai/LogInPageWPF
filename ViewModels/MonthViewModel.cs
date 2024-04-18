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

        public ICommand PrevMonthCommand { get; }

        public ICommand NextMonthCommand { get; }

        public ICommand GoToTodayCommand { get; }

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

    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
