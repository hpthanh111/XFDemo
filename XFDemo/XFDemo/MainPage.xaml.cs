using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btn1_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void btn1_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new DetailPage1(btn1.Text));
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestPage());
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Calc());
        }
    }
}
