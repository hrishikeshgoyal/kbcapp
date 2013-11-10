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
    public partial class division : PhoneApplicationPage
    {
        static float a1, a2, a3, b4;
        static int b1, b2, b3,b5;
        public division()
        {
            InitializeComponent();
            Random rnd = new Random();
            b1 = rnd.Next(50, 100);
            b2 = rnd.Next(1, 48);
            b3 = rnd.Next(1, 4);
            x1.Text = (b1).ToString();
            x2.Text = (b2).ToString();
            b4 = (float)b1 / b2;
            if (b3 == 1)
                ck1.Content = (b4).ToString();
            else
                ck1.Content = (rnd.Next(1, 100).ToString());
            if (b3 == 2)
                ck2.Content = (b4).ToString();
            else
                ck2.Content = (rnd.Next(1, 100).ToString());
            if (b3 == 3)
                ck3.Content = (b4).ToString();
            else
                ck3.Content = (rnd.Next(1, 100).ToString());
            if (b3 == 4)
                ck4.Content = (b4).ToString();
            else
                ck4.Content = (rnd.Next(1, 100).ToString());
            b5 = rnd.Next(1, 4);
            if (b5 != b3)
            {
                if (b5 == 1)
                {
                    ck1.Content = (b4 + rnd.Next(-2, 6)).ToString();
                }
                else
                if (b5 == 2)
                {
                    ck2.Content = (b4 + rnd.Next(0, 3)).ToString();
                }
                else
                if(b5==3)
                {
                     ck3.Content = (b4 + rnd.Next(1, 3)).ToString();
                }
                else
                if(b5==4)
                {
                     ck4.Content = (b4 + rnd.Next(2, 5)).ToString();
                }
            }
        }

        private void ck1_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x1.Text.ToString(), out a1);
            float.TryParse(x2.Text.ToString(), out a2);
            float.TryParse(ck1.Content.ToString(), out a3);
            if ((int)a1 / (int)a2 == (int)a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ck2_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x1.Text.ToString(), out a1);
            float.TryParse(x2.Text.ToString(), out a2);
            float.TryParse(ck2.Content.ToString(), out a3);
            if ((int)a1 / (int)a2 == (int)a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ck3_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x1.Text.ToString(), out a1);
            float.TryParse(x2.Text.ToString(), out a2);
            float.TryParse(ck3.Content.ToString(), out a3);
            if ((int)a1 / (int)a2 == (int)a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ck4_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(x1.Text.ToString(), out a1);
            float.TryParse(x2.Text.ToString(), out a2);
            float.TryParse(ck4.Content.ToString(), out a3);
            if ((int)a1 / (int)a2 == (int)a3)
                this.NavigationService.Navigate(new Uri("/result1.xaml", UriKind.RelativeOrAbsolute));
            else
                this.NavigationService.Navigate(new Uri("/result2.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}