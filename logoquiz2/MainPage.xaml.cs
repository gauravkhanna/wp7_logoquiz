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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }
        private string checker(int i)
        {
            switch (Class1.logo[i].check)
                {
                    case 1:
                        return "correct.png";
                    case -1:
                        return "incorrect.png";
                    default:
                        Visibility isLight = (Visibility)Resources["PhoneLightThemeVisibility"]; // for light theme
                        Visibility isDark = (Visibility)Resources["PhoneDarkThemeVisibility"]; // for dark theme
                        if (isLight == System.Windows.Visibility.Visible)
                                return "unmarked1.png";
                                //We are on light theme
                        if (isDark == System.Windows.Visibility.Visible)
                                return "unmarked2.png";
                                //We are on dark theme
                        return "";
                }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
                answer1.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(checker(0));
                answer2.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(checker(1));
        }
        private void image1_Tap(object sender, GestureEventArgs e)
        {
            logos_each.current = 0;
            NavigationService.Navigate(new Uri("/logo11.xaml", UriKind.Relative));
        }

        private void image2_Tap(object sender, GestureEventArgs e)
        {
            logos_each.current = 1;
            NavigationService.Navigate(new Uri("/logo11.xaml", UriKind.Relative));
        }
    }
}