using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
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
    /// Interaction logic for LoginStaff.xaml
    /// </summary>
    public partial class LoginStaff : Window
    {

        public LoginStaff()
        {
            InitializeComponent();
        }

        private void Button_logo_SL(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_Previous_SL(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_Login_SL(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=BloodDonationManagement; Integrated Security=True");

            try
            {

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Staff_Details Where Staff_ID=@Username and Staff_Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", txtStaffID.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtStaffPassword.Password);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MainWindow dashboard = new MainWindow();     
                    dashboard.Show();
                    PatientWantsToView pl = new PatientWantsToView();
                    pl.Show();
                    this.Close();

                }
                else if (txtStaffID.Text != null || txtStaffPassword.Password != null)
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
    }
}
