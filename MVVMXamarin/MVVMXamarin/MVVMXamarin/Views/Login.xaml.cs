using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MVVMXamarin.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Options());
        }
    }
}
