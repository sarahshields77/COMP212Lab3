using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _301264350_shields_Lab3Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Accessing the UserName and Password properties of the LoginUserControl
            string userName = loginUserControl.UserName;
            string password = loginUserControl.Password;

            // Simple validation example
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Welcome, {userName}! You are logged in.");
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    }
}