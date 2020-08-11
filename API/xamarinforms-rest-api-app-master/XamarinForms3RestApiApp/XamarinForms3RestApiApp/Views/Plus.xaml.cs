using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinForms3RestApiApp.Views
{
    //https://en.wikipedia.org/wiki/Elephant

    //[DesignTimeVisible(false)]

    public partial class Plus : ContentPage
    {
        public Plus()
        {
            InitializeComponent();

        }


        async void Button_Clicked(object sender, EventArgs args)
        {
            {
                await Browser.OpenAsync("https://en.wikipedia.org/wiki/Elephant");
            }

        }
    }

}
   

    
    


   

            
            
    

