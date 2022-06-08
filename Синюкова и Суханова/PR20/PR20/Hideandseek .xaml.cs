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
    /// Логика взаимодействия для Hideandseek.xaml
    /// </summary>
    public partial class Hideandseek : Window
    {
        public Hideandseek()
        {
            InitializeComponent();
        }           
        private void chknumber1_Checked(object sender, RoutedEventArgs e)
        {           
                Box1.Visibility = Visibility.Hidden;            
        }

        private void chknumber2_Checked(object sender, RoutedEventArgs e)
        {
            Box2.Visibility = Visibility.Hidden;
        }

        private void chknumber3_Checked(object sender, RoutedEventArgs e)
        {
            Box3.Visibility = Visibility.Hidden;
        }

        private void chknumber4_Checked(object sender, RoutedEventArgs e)
        {
            Box4.Visibility = Visibility.Hidden;
        }

        private void chknumber1_Unchecked(object sender, RoutedEventArgs e)
        {
            Box1.Visibility = Visibility.Visible;
        }

        private void chknumber2_Unchecked(object sender, RoutedEventArgs e)
        {
            Box2.Visibility = Visibility.Visible;
        }

        private void chknumber3_Unchecked(object sender, RoutedEventArgs e)
        {
            Box3.Visibility = Visibility.Visible;
        }

        private void chknumber4_Unchecked(object sender, RoutedEventArgs e)
        {
            Box4.Visibility = Visibility.Visible;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            computation newWin = new computation();
            newWin.Show();
            this.Close();
        }
    }
}
