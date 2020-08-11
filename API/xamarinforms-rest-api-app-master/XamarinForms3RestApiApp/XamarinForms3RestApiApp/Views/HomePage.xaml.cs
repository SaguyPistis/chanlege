using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms3RestApiApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void Button_Play(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new GamePage());
        }

        void Button_ShowAPI(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync( new MainPage());
        }
    }
}
