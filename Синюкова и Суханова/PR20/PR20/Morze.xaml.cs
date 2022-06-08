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

namespace PR20
{
    /// <summary>
    /// Логика взаимодействия для Morze.xaml
    /// </summary>
    public partial class Morze : Window
    {
        public Morze()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            
            txtResult.Text += ".- ";
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-... ";
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-.-. ";
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-.. ";
        }

        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ". ";
        }

        private void btnF_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "..-. ";
        }

        private void btnG_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "--. ";
        }

        private void btnH_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".... ";
        }

        private void btnI_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".. ";
        }

        private void btnJ_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".--- ";
        }

        private void btnK_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-.- ";
        }

        private void btnL_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".-.. ";
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-- ";
        }

        private void btnN_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-. ";
        }

        private void btnO_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "--- ";
        }

        private void btnP_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".--. ";
        }

        private void btnQ_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "--.- ";
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".-. ";
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "... ";
        }

        private void btnT_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "- ";
        }

        private void btnU_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "..- ";
        }

        private void btnV_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "...- ";
        }

        private void btnW_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += ".-- ";
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-..- ";
        }

        private void btnY_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "-.-- ";
        }

        private void btnZ_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text += "--.. ";
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Booking newWin = new Booking();
            newWin.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = " ";
        }
    }
}
