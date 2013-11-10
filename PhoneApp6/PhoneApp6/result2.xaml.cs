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
    public partial class result2 : PhoneApplicationPage
    {
        static int res1 = 0;
        public result2()
        {
            InitializeComponent();
            TB.Text = (res1++).ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/StartPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/Thank.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}