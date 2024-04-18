using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace LogInPageWPF.Views
{
    public partial class MonthViewPage : UserControl, INotifyPropertyChanged
    {
        private DateTime _currentDate;

        public MonthViewPage()
        {
            InitializeComponent();
            CurrentDate = DateTime.Today;
            DataContext = this;
        }

        public DateTime CurrentDate
        {
            get { return _currentDate; }
            set
            {
                if (_currentDate != value)
                {
                    _currentDate = value;
                    OnPropertyChanged();
                }
            }
        }

        private void PrevMonth_Click(object sender, RoutedEventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(-1);
        }

        private void NextMonth_Click(object sender, RoutedEventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(1);
        }

        private void GoToday_Click(object sender, RoutedEventArgs e)
        {
            CurrentDate = DateTime.Today;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
