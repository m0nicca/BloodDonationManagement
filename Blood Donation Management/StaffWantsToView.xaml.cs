using System;
using System.Collections.Generic;
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
    /// Interaction logic for StaffWantsToView.xaml
    /// </summary>
    public partial class StaffWantsToView : Window
    {
        public StaffWantsToView()
        {
            InitializeComponent();
        }

        private void Button_logo(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_PatientDetails(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LABSCIFIPC12\LOCALHOST; Initial Catalog=HospitalDataSQL; Integrated Security=True");

            StaffViewsPatientDetails pd = new StaffViewsPatientDetails();
            pd.Show();
            this.Close();
        }

        private void Button_PatientHospitalization(object sender, RoutedEventArgs e)
        {
            //need page
        }

        private void Button_DonorDetails(object sender, RoutedEventArgs e)
        {
            //need page
        }

        private void Button_DonorHospitalization(object sender, RoutedEventArgs e)
        {
            //need page
        }

        private void Button_BloodBanks(object sender, RoutedEventArgs e)
        {
            //need page
        }
    }
}
