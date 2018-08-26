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
	public partial class MainView : ContentPage
	{
        List<Models.Doctor> Doctors = null;

		public MainView ()
		{
			InitializeComponent ();

            if (Doctors == null)
            {
                Doctors = new List<Models.Doctor>()
                {
                    new Models.Doctor() {Name ="Trần Văn A", Title = "Y ta", Address = "Can Tho", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg" },
                    new Models.Doctor() {Name ="Nguyễn Thị Mé Rim", Title = "Bac sy", Address = "Dong Nai", PhoneNumber = "123654789" ,
                    Image = "http://streaming1.danviet.vn/upload/2-2015/images/2015-04-20/1434180134-qaamde_thuong_10_xcnq.jpg"},
                    new Models.Doctor() {Name ="Nguyễn Điểm", Title = "Phau thuat", Address = "Sai Gon", PhoneNumber = "123654789",
                    Image = "http://streaming1.danviet.vn/upload/2-2016/images/2016-06-24/146675109477392-han-hyo-joo-w-two-world.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://khunganhonline.com/images/frame/frame_icon/khung-anh-tet-4005a60b2d8b8dc7.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"},
                    new Models.Doctor() {Name ="Võ Thành Thống", Title = "Ke toan", Address = "Vinh Long", PhoneNumber = "123654789",
                    Image = "https://bookingcare.vn/cache/800/image/2017/08/11/085935safeimage.jpg"}

                };
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lvDoctor.ItemsSource = Doctors;
        }

        private void lvDoctor_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var doctor = (Doctor)e.Item;

            Navigation.PushAsync(new DoctorView(doctor));
        }
    }
}