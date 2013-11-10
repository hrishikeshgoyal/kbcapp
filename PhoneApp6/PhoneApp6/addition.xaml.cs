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
    public partial class addition : PhoneApplicationPage
    {
        int a1, a2, a3, b1, b2, b3, b4;
        public addition()
        {
            InitializeComponent();
            Random rnd = new Random();
            b1 = rnd.Next(50, 100);
            b2 = rnd.Next(1, 48);
            b3 = rnd.Next(1, 4);

            x1.Text = (b1).ToString();
            x2.Text = (b2).ToString();
            b4 = b1 + b2;
             if (b3 == 1)
                ck1.Content = (b4).ToString();
            else
                ck1.Content = (rnd.Next(1, 100).ToString());
            if(b3==2)
                ck2.Content = (b4).ToString();
            else
                ck2.Content = (rnd.Next(1, 100).ToString());
            if(b3==3)
                ck3.Content = (b4).ToString();
            else
                ck3.Content = (rnd.Next(1, 100).ToString());
            if (b3 == 4)
                ck4.Content = (b4).ToString();
            else
                ck4.Content = (rnd.Next(1, 100).ToString());
        }
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(x1.Text.ToString(), out a1);
            Int32.TryParse(x2.Text.ToString(), out a2);
            Int32.TryParse(ck1.Content.ToString(), out a3);
            if (a1 + a2 == a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(x1.Text.ToString(), out a1);
            Int32.TryParse(x2.Text.ToString(), out a2);
            Int32.TryParse(ck2.Content.ToString(), out a3);
            if (a1 + a2 == a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(x1.Text.ToString(), out a1);
            Int32.TryParse(x2.Text.ToString(), out a2);
            Int32.TryParse(ck3.Content.ToString(), out a3);
            if (a1 + a2 == a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(x1.Text.ToString(), out a1);
            Int32.TryParse(x2.Text.ToString(), out a2);
            Int32.TryParse(ck4.Content.ToString(), out a3);
            if (a1 + a2 == a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}