using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using LogInPageWPF.Views;

namespace LogInPageWPF
{
    public partial class MainWindow : Window
    {
        // Main Constructor
        public MainWindow()
        {
            InitializeComponent();          // To initializes component from XAML (Other files has thier similar initialization)
            Loaded += MainWindow_Loaded;    // This is to attache an event handler for the Window Loaded event
        }

        // Event handler for the Window's Loaded event
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // This will automatically navigate to the LoginPage when the window is loaded
            MainFrame.Navigate(new LoginPage());
        }

        // This is a method to navigate to different pages within the application
        public void NavigateTo(Page nextPage)
        {
            // To use the Frame named 'MainFrame' to navigate to the specified page
            MainFrame.Navigate(nextPage);
        }
    }
}
