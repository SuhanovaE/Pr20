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
    /// Логика взаимодействия для Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void chkchiz_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void chkgamb_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chkcola_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void chknag_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnRezult_Click(object sender, RoutedEventArgs e)
        {

            int n1 = Convert.ToInt32(txtAmountchiz.Text);
            int s1 = n1 * 230;

            int n2 = Convert.ToInt32(txtAmountgamb.Text);
            int s2 = n2 * 150;

            int n3 = Convert.ToInt32(txtAmountcola.Text);
            int s3 = n3 * 200;

            int n4 = Convert.ToInt32(txtAmountnag.Text);
            int s4 = n4 * 100;

            int all = s4 + s3 + s2 + s1;
            
            Book.Text += "Чек: \n";
            if (chkchiz.IsChecked == true)
            {
                
                Book.Text += Convert.ToString($"Чизбургер  {s1} руб. \n");
            }
            if (chkgamb.IsChecked == true)
            {
                Book.Text += Convert.ToString($"Гамбургер  {s2} руб. \n");
            }
            if (chkcola.IsChecked == true)
            {
                Book.Text += Convert.ToString($"Кока-кола  {s3} руб.  \n");
            }
            if (chknag.IsChecked == true)
            {
                Book.Text += Convert.ToString($"Нагетсы  {s4} руб. \n");
            }
            Book.Text += Convert.ToString($"Итого:  {all} руб. \n");

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Book.Text=" ";
            txtAmountchiz.Text = " ";
            txtAmountcola.Text = " ";
            txtAmountgamb.Text = " ";
            txtAmountnag.Text = " ";
            chkgamb.IsChecked = false;
            chkcola.IsChecked = false;
            chknag.IsChecked = false;
            chkchiz.IsChecked = false;

        }
    }
}
