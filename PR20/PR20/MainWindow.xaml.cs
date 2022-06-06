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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace PR20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnFocus_Click(object sender, RoutedEventArgs e)
        {
            
            
            //TextBlock newText = new TextBlock();
            //TxtInput.Text = TxtOutput.Text;
           
           
            //string word1 = TxtOutput.Text;
            //TxtInput.Text = word1;
            //TxtOutput.Clear();
            //BtnFocus.Content = "->";
            //string x = "->";
            //string y = "<-";
            if (BtnFocus.Content == "->")
            {

                string word = TxtInput.Text;
                TxtOutput.Text = word;
                BtnFocus.Content = "<-";
                TxtInput.Clear();
            }

            else
            {
                string word = TxtOutput.Text;
                TxtInput.Text = word;
                BtnFocus.Content = "->";
                TxtOutput.Clear();
            }

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            Calculate newWin = new Calculate();
            newWin.Show();
        }
    }
}
