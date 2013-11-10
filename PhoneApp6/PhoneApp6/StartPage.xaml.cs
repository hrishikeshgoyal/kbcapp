using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp6
{
    public partial class StartPage : PhoneApplicationPage
    {
        static int res = 0;
        public StartPage()
        {
            InitializeComponent();
            tt.Text = (res++).ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/addition.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/multiply.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/division.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/subtraction.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}