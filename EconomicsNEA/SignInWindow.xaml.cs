using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EconomicsNEA
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        private bool signIn = false;
        public SignInWindow()
        {
            InitializeComponent();
        }
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Password;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Signed in successfully");
                SignedIn(sender, e);
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void OpenSignUp_Click(object sender, RoutedEventArgs e)
        {
            var signUp = new SignUpWindow();
            signUp.ShowDialog();
        }
        private void SignedIn(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            
        
        }

    }

}
