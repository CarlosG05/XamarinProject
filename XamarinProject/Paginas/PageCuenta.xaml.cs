using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinProject.Paginas
{

    [DesignTimeVisible(false)]
    [QueryProperty("ResultadoIMC", "resultadoIMC")]

    public partial class PageCuenta : ContentPage
    {
        public PageCuenta()
        {
            InitializeComponent();
        }

        public string ResultadoIMC
        {
            set { lblResultadoIMC.Text = value; }
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync($"//inicio?mensaje={lblResultadoIMC.Text}");
        }
    }
}
