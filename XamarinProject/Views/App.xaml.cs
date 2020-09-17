using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new AppShell();
            Routing.RegisterRoute("pagina", typeof(MainPage));      
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
