using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace converter
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        //BMR = 10 * weight(kg) + 6.25 * height(cm) - 5 * age(y) + 5         (man)
//BMR = 10 * weight(kg) + 6.25 * height(cm) - 5 * age(y) - 161     (woman)
        double ans,weight,height,age;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            weight = Convert.ToDouble(Weight.Text);
            height = Convert.ToDouble(Height.Text);
            age = Convert.ToDouble(Age.Text);

            if (male.IsChecked == true)
                ans = (10 * weight) + (6.25 * height) - (5 * age) + 5 ;

            if (female.IsChecked == true)
                ans = (10 * weight) + (6.25 * height) - (5 * age) -161 ;
          

            MessageBox.Show(" you need " + Convert.ToString(ans)+" Colories/day");

        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {
            if (male.IsChecked == true)
                female.IsEnabled = false;

            if (Weight.Text != "" && Height.Text != "" && Age.Text != "" && (male.IsChecked == true || female.IsChecked == true))
            {
                ok.IsEnabled = true;
            }
            else
                ok.IsEnabled = false;
        }

        private void female_Checked(object sender, RoutedEventArgs e)
        {
            if (female.IsChecked == true)
                male.IsEnabled = false;

            if (Weight.Text != "" && Height.Text != "" && Age.Text != "" && (male.IsChecked == true || female.IsChecked == true))
            {
                ok.IsEnabled = true;
            }
            else
                ok.IsEnabled = false;
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Weight.Text != "" && Height.Text != "" && Age.Text != "" && (male.IsChecked == true || female.IsChecked == true))
            {
                ok.IsEnabled = true;
            }
            else
                ok.IsEnabled = false;

                
        }

        private void Height_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Weight.Text != "" && Height.Text != "" && Age.Text != "" && (male.IsChecked == true || female.IsChecked == true))
            {
                ok.IsEnabled = true;
            }
            else
                ok.IsEnabled = false;
        }

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Weight.Text != "" && Height.Text != "" && Age.Text != "" && (male.IsChecked == true || female.IsChecked == true))
            {
                ok.IsEnabled = true;
            }else
                ok.IsEnabled = false;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Height.Text = "";
            Weight.Text = "";
            Age.Text = "";
            male.IsChecked = false;
            female.IsChecked = false;
            male.IsEnabled = true;
            female.IsEnabled = true;
        }
    }
}