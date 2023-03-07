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
    /// Interaction logic for PatientWantsToView.xaml
    /// </summary>
    public partial class PatientWantsToView : Window
    {
        public PatientWantsToView()
        {
            InitializeComponent();
        }

        private void Button_Previous(object sender, RoutedEventArgs e)
        {
            PatientOrStaffPage mainPage = new PatientOrStaffPage();
            mainPage.Show();
            this.Close();
        }

        private void Button_Hospitalization(object sender, RoutedEventArgs e)
        {
            //need page
        }

        private void Button_PatientDetails(object sender, RoutedEventArgs e)
        {
            //need page
        }
    }
}
