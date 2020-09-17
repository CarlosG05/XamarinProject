using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Proyecto Xamarin", "https://xamarinproject.com", "Listo");
        }

    }
}
 