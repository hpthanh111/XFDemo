using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XFDemo
{
	public partial class App : Application
	{
		public App ()
		{

            #if DEBUG
            LiveReload.Init();
            #endif

            InitializeComponent();

            MainPage = new NavigationPage(new Views.LoginView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
