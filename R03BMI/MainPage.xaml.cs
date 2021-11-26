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
            creater.Text = "JK3A16 齊藤優太";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight, height, BMI;
            if(double.Parse(heighit.Text) >= 100)
            {
                height = double.Parse(heighit.Text) / 100;
            }else
            {
                height = double.Parse(heighit.Text);
            }
            if(double.Parse(weighit.Text) >= 1000)
            {
                weight = double.Parse(weighit.Text) / 1000;
            }else
            {
                weight = double.Parse(weighit.Text);
            }
            if(height == 0 || weight == 0)
            {
                result.Text = "BMIを計算できませんでした。適切な値を入力してください。";
            }

            BMI = Math.Round(weight / (height * height), 1);

            if(BMI >= 40.0)
            {
                result.Text = BMI +　":" + "肥満（４度）";
            }
            else if(BMI >= 35.0) {
                result.Text = BMI + ":" + "肥満（３度）";
            }
            else if(BMI >= 30.0)
            {
                result.Text = BMI + ":" + "肥満（２度）";
            }
            else if(BMI >= 25.0)
            {
                result.Text = BMI + ":" + "肥満（1度）";
            }
            else if(BMI >= 18.5)
            {
                result.Text = BMI + ":" + "普通体重";
            }
            else
            {
                result.Text = BMI + ":" + "低体重（痩せ）";
            }
        }
    }
}
