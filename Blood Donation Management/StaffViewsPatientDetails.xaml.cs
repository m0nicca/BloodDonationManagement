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

namespace Blood_Donation_Management
{
    /// <summary>
    /// Interaction logic for StaffViewsPatientDetails.xaml
    /// </summary>
    public partial class StaffViewsPatientDetails : Window
    {
        public StaffViewsPatientDetails()
        {
            InitializeComponent();
        }

        private void Button_logo(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_Previous(object sender, RoutedEventArgs e)
        {
            StaffWantsToView previous = new StaffWantsToView();
            previous.Show();
            this.Close();
        }
    }
}


