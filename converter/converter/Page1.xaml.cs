




using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BodyCalcul.Resources;

namespace converter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ans =(Convert.ToDouble(weight.Text) /( (Convert.ToDouble(height.Text)/100) * (Convert.ToDouble(height.Text)/100) )) ;
            result.Text = Convert.ToString(ans);
            int calculIdeal = (int) (((Convert.ToDouble(height.Text) / 100) * (Convert.ToDouble(height.Text) / 100)) * 21.7);
           
            result.Text = Convert.ToString(ans);
            ideal.Text = Convert.ToString(calculIdeal);
            if (ans < 18.5)
            {
                resultBorder.Value = ans;
                MessageBox.Show(" you are underweight");

            }
            if (ans > 18.5 && ans < 24.9)
            {
                resultBorder.Value = ans;
                MessageBox.Show(" you are normal");
            }
            if (ans > 25.0)
            {
                resultBorder.Value = ans;
                MessageBox.Show(" you are overweight");

            }

            
            
            /*
             * 18.5–24.9
            if (MCM.IsChecked==true)
               result.Text= Convert.ToString(Convert.ToDouble(number.Text)*100);
            
            if(CMM.IsChecked==true)
                result.Text = Convert.ToString(Convert.ToDouble(number.Text)/ 100);
            */
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Text = "";
            height.Text = "";
            weight.Text = "";
            ideal.Text = "";
            resultBorder.Value = 0;

            
        }

        private void weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (height.Text != "" && weight.Text!="")
                enterBut.IsEnabled = true;
            if (height.Text == "" && weight.Text == "")
                enterBut.IsEnabled = false;
        }

       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}