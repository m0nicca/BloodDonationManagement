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
    /// Interaction logic for PatientOrStaffPage.xaml
    /// </summary>
    public partial class PatientOrStaffPage : Window
    {
        public PatientOrStaffPage()
        {
            InitializeComponent();
        }

        private void Button_Staff(object sender, RoutedEventArgs e)
        {
            LoginStaff ls = new LoginStaff();
            ls.Show();
            this.Close();
        }

        private void Button_Patient(object sender, RoutedEventArgs e)
        {
            LoginPatient lp = new LoginPatient();
            lp.Show();
            this.Close();

        }

    }

}
