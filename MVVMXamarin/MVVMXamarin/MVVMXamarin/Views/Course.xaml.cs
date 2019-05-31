using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MVVMXamarin.Views
{
    public partial class Course : ContentPage
    {
        void Handle_SearchButtonPressed(object sender, System.EventArgs e)
        {
            DisplayAlert("Buscando", "Buscando un curso", "ok");
        }

        public Course()
        {
            InitializeComponent();
        }
    }
}
