using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A17 齊藤優太";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight, height, BMI;
            weight = double.Parse(heighit.Text);
            height = double.Parse(weighit.Text);
            BMI = (weight / (height * height));
            result.Text = BMI + "("; 
        }
    }
}
