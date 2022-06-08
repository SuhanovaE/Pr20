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
    /// Логика взаимодействия для computation.xaml
    /// </summary>
    public partial class computation : Window
    {
        public computation()
        {
            InitializeComponent();
        }

        private void btnsum_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(number1.Text);
            double y = Convert.ToDouble(number2.Text);
            double an = x + y;
            txtanswer.Text = Convert.ToString(an);
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(number1.Text);
            double y = Convert.ToDouble(number2.Text);
            double an = x - y;
            txtanswer.Text = Convert.ToString(an);
        }

        private void btndivision_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(number1.Text);
            double y = Convert.ToDouble(number2.Text);
            double an = x * y;
            txtanswer.Text = Convert.ToString(an);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Morze newWin = new Morze();
            newWin.Show();
            this.Close();
        }
    }
}
