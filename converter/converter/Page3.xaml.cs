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
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }
        //%Fat = 86.010*LOG(abdomen - neck) - 70.041*LOG(height) + 30.30
        //Fat = 163.205*LOG(abdomen + hip - neck) - 97.684*LOG(height) - 104.912


        //495/(1.0324-0.19077(LOG(waist-neck))+0.15456(LOG(height)))-450
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double bmi;
            double ans = 0.0 ;
            double weightint=Convert.ToDouble(weight.Text);
            int ageint=Convert.ToInt16(age.Text);
            double heightint=Convert.ToDouble(height.Text);

            bmi = (weightint / ((heightint / 100) * (heightint / 100)));
            //(1.20 x BMI) + (0.23 x Age) - (10.8 x gender) - 5.4
            if(female.IsChecked==true && male.IsChecked==false){

                ans = (int) (1.20 * bmi) + (0.23 * ageint) - (10.8 * 0) - 5.4;
            }
            if (female.IsChecked == false && male.IsChecked == true)
            {
               // ans = 86.010 * Math.Log(waistint - neckint) - (70.041 * Math.Log(heightint)) + 30.30;
                ans = (int ) (1.20 * bmi) + (0.23 * ageint) - (10.8 * 1) - 5.4;
            }

            result.Text = Convert.ToString(ans);
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            
            height.Text = "";
            age.Text = "";
            male.IsChecked = false;
            female.IsChecked = false;
            weight.Text = "";
            male.IsEnabled = true;
            female.IsEnabled = true;
           
        }

        private void height_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "" &&

                (male.IsChecked == true || female.IsChecked == true))
            {
                enterBut.IsEnabled = true;
            }else
                enterBut.IsEnabled = false;
        }

        private void neck_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "" &&

                (male.IsChecked == true || female.IsChecked == true))
            {
                enterBut.IsEnabled = true;
            }
            else
                enterBut.IsEnabled = false;
        }

        private void waist_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "" &&

                (male.IsChecked == true || female.IsChecked == true))
            {
                enterBut.IsEnabled = true;
            }
            else
                enterBut.IsEnabled = false;
        }

        private void hip_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "" &&

                (male.IsChecked == true || female.IsChecked == true))
            {
                enterBut.IsEnabled = true;
            }
            else
                enterBut.IsEnabled = false;
        }

        private void female_Checked(object sender, RoutedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "" )
            {
                enterBut.IsEnabled = true;
            }
            else
                enterBut.IsEnabled = false;
            male.IsEnabled = false;
        }

        private void male_Checked(object sender, RoutedEventArgs e)
        {
            if (height.Text != "" && weight.Text != "" && age.Text != "")
            {
                enterBut.IsEnabled = true;
            }
            else
                enterBut.IsEnabled = false;

            female.IsEnabled = false;
        }
    }
}