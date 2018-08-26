using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage1 : ContentPage
	{
        string text = "";
		public DetailPage1 (string ptext)
		{
			InitializeComponent ();

            text = ptext;

            lbltext.Text = ptext;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}