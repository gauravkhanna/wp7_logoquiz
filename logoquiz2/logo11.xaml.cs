using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace logoquiz2
{
    public partial class logo11 : PhoneApplicationPage
    {
        public logo11()
        {
            InitializeComponent();
            if (Class1.logo[logos_each.current].check == 1)
            {
                button1.Visibility = Visibility.Visible;
                check.Visibility = Visibility.Collapsed;
            }
            else
            {
                button1.Visibility = Visibility.Collapsed;
                check.Visibility = Visibility.Visible;
            }
            image1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(Class1.logo[logos_each.current].mains);
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Enter your answer")
            {
                textBox1.Text="";
            }
        }

        private void check_Click(object sender, RoutedEventArgs e)
        {
            string ans = textBox1.Text;
            ans = ans.ToLower();
            //enum ans_list = ;

            if (ans.Equals(Class1.logo[logos_each.current].answer[0]) || ans.Equals(Class1.logo[logos_each.current].answer[1]))
            {
                Class1.logo[logos_each.current].check = 1;
            }
            if (!ans.Equals(Class1.logo[logos_each.current].answer[0]) && !ans.Equals(Class1.logo[logos_each.current].answer[1]))
            {
                Class1.logo[logos_each.current].check = -1;
            }

            if (Class1.logo[logos_each.current].check == 1)
            {
                MessageBox.Show("Correct");
                button1.Visibility = Visibility.Visible;
                check.Visibility = Visibility.Collapsed;
            }

            if (Class1.logo[logos_each.current].check == -1)
            {
                MessageBox.Show("Incorrect. Try Again!!");
            }
            
        }

        private void textBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your answer";
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Class1.logo[logos_each.current].hints[0] + "\n" + Class1.logo[logos_each.current].hints[1]);
        }
    }
}