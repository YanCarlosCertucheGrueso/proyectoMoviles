
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MVVMXamarin.Views
{
    public partial class Options : ContentPage
    {
        void Handle_Clicked_2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Date());
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Course());
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Schedule());
        }

        public Options()
        {
            InitializeComponent();
        }

        void Handle_Clicked_3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Library());
        }

        void Handle_Clicked_4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Dispenser());
        }
    }
}
