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
    /// Логика взаимодействия для Calculate.xaml
    /// </summary>
    public partial class Calculate : Window
    {
        public Calculate()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {


            //int x = int.Parse(txtOne1.Text);
            //int y = int.Parse(txtTwo1.Text);
            //int s = int.Parse(txtSumm.Text);
            //s = x + y;
            int x = Convert.ToInt32(txtOne1.Text);
            int y = Convert.ToInt32(txtTwo1.Text);

            int s1 = x + y;
            int s2 = x - y;
            int s3 = x * y;
            int s4 = x / y;

            txtSumm.Text = Convert.ToString(s1);
            txtMinuss.Text = Convert.ToString(s2);
            txtCompositionn.Text = Convert.ToString(s3);
            txtDivisionn.Text = Convert.ToString(s4);
            
                if (txtTwo1.Text == "0")
                {
                    
                    MessageBox.Show("Вы не можете делить на 0");
                }
            

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Hideandseek newWin = new Hideandseek();
            newWin.Show();
        }
    }

}


