using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Aspronto
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
           
            Navigation.PushAsync(new AsprontoPage());
            //throw new NotImplementedException();

        }
    }
}
