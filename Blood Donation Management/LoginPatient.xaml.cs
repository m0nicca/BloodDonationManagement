using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Blood_Donation_Management
{
    /// <summary>
    /// Interaction logic for LoginPatient.xaml
    /// </summary>
    public partial class LoginPatient : Window
    {
        public LoginPatient()
        {
            InitializeComponent();
        }

        private void Button_Login_PL(object sender, RoutedEventArgs e)
        {
          
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=BloodDonationManagement; Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Patient_Details Where Patient_ID=@Username and Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtPatientID.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPatientPassword.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();
                    //dashboard.label.Content = $"Welcome, {txtPatientID.Text} ";     
                    dashboard.Show();
                    PatientWantsToView pl = new PatientWantsToView();
                    pl.Show();
                    this.Close();
                    
                }
                else if (txtPatientID.Text != null || txtPatientPassword.Password != null)
                {

                    PatientWantsToView pl = new PatientWantsToView();
                    MessageBox.Show("Please enter valid information!");

                }
                else
                {

                    MessageBox.Show("password is not correct");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void Button_logo_PL(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_Previous(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }
    }
}
