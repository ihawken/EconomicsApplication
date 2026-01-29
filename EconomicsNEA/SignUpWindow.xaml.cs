using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow()
        {
            InitializeComponent();


        }

        public void SignUpClickd(object sender, RoutedEventArgs e)
        {
            string username = NewUsername.Text;
            string password = NewPassword.Password;
            if(username == "" || password == "" )
            {
                // If there is not any password or username entered then this will prevent the user from siging up 
                MessageBox.Show("Must enter a username and password. ");
                return;
            }
            string ConnectionString = 
    "Server=tcp:economicsserver.database.windows.net,1433;" +
    "Initial Catalog=EconomicsNEA;" +
    "Persist Security Info=False;" +
    "User ID=ISAACHAWKEN@exe-coll.ac.uk;" +
    "Password=ocGkgV9Y~RFXUVsaL4qT;" +
    "MultipleActiveResultSets=False;" +
    "Encrypt=True;" +
    "TrustServerCertificate=False;" +
    "Authentication=Active Directory Password;";

            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open(); // Retrieves usernames 
                string Query = @"
            IF EXISTS (SELECT 1 FROM Users WHERE Username = @username)
                SELECT 1
            ELSE
                SELECT 0";


                SqlCommand cmd = new SqlCommand(Query, conn);
                 
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                
                int result =(int) cmd.ExecuteScalar();
                if (result ==1)
                {
                    // If the username already exists then this message will be shown 
                    MessageBox.Show("Username already exists. Please choose a different username.");
                }
                else
                {

                    MessageBox.Show("Unqiue Username");


                    
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                    insertCmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = password;
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("User registered successfully!");
                    
                     this.Close(); // Closes the sign up window after person has been added 
                }







            }




        }


    }
}
