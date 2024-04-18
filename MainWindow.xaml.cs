using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using LogInPageWPF.Views;

namespace LogInPageWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Navigate to the LoginPage when the main window is loaded.
            MainFrame.Navigate(new LoginPage());
        }

        public void NavigateTo(Page nextPage)
        {
            MainFrame.Navigate(nextPage);
        }
    }
}
