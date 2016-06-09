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

namespace Temp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "name is " + name + "\nx is " + x + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;
            if (x== 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Ivan";
            if ((someValue == 4) && (name == "Ivan"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }
            //myLabel.Text = "this line runs no matter what";
        }

        private string Addline (int count,string message)
        {
            return message + "count=" + count + "       ";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            string TheText = "";

            while (count < 100)
            {
                count++;
                TheText = Addline(count, TheText);
            }

            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
                TheText = Addline(count, TheText);
            }
            myLabel.Text = TheText;
        }
    }
}
