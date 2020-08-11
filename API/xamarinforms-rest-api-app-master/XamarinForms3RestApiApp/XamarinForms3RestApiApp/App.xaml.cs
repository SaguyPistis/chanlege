using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms3RestApiApp.Views;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinForms3RestApiApp
{
	public partial class App : Application
	{
		public App ()		{
			InitializeComponent();

			//MainPage = new MainPage();
			MainPage = new ShellPage();
			
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
