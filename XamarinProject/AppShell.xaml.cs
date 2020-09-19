using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinProject.Paginas;

namespace XamarinProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute("inicio", typeof(MainPage));
            Routing.RegisterRoute("resultado", typeof(PageCuenta));
        }

        async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await DisplayAlert("Proyecto Xamarin", "https://xamarinproject.com", "Listo");
        }

    }
}
 