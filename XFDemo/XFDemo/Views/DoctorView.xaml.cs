using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDemo.Models;

namespace XFDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorView : ContentPage
	{
        Doctor EditDoctor { get; set; }

        Doctor CurrentDoctor { get; set; }

        public DoctorView (Doctor pdoctor)
		{
			InitializeComponent ();

            CurrentDoctor = pdoctor;

            EditDoctor = new Doctor()
            {
                Name = pdoctor.Name,
                Title = pdoctor.Title,
                Address = pdoctor.Address,
                PhoneNumber = pdoctor.PhoneNumber,
                Image = pdoctor.Image
            };

            BindingContext = EditDoctor;

            //lblName.Text = doctor.Name;
            //lblTitle.Text = doctor.Title;
            //lblAddress.Text = doctor.Address;
            //imgHinh.Source = doctor.Image;
        }

        private void btnCall_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+27219333000");

            //var smsMessenger = CrossMessaging.Current.SmsMessenger;
            //if (smsMessenger.CanSendSmsInBackground)
            //    smsMessenger.SendSmsInBackground("+27213894839", "Well hello there from Xam.Messaging.Plugin");
        }

        private async Task btnTest_ClickedAsync(object sender, EventArgs e)
        {
            for(int i = 1; i <= 360; i ++)
            {
                slider.Value = slider.Value + i;
                await Task.Delay(2000);
            }
        }

        private void btnTest_Clicked(object sender, EventArgs e)
        {

        }

        private void mnuSave_Clicked(object sender, EventArgs e)
        {
            CurrentDoctor.Name = EditDoctor.Name;
            CurrentDoctor.Address = EditDoctor.Address;
            CurrentDoctor.Title = EditDoctor.Title;
            CurrentDoctor.PhoneNumber = EditDoctor.PhoneNumber;

            DisplayAlert("Hello", "Save roi", "OK");

            Navigation.PopAsync();
        }
    }
}