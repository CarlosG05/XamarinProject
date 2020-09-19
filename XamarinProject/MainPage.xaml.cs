using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinProject
{

    [DesignTimeVisible(false)]
    [QueryProperty("Mensaje", "mensaje")]

    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public string Mensaje {
            set { lblMensaje.Text = value; }
        }


        public double CalculoIMC() {

            double peso;
            double estatura;
            double resultado;

            peso = Convert.ToDouble(etPeso.Text);
            estatura = Convert.ToDouble(etEstatura.Text);

            resultado = peso / Math.Pow(estatura/100,2);
            resultado = Math.Round(resultado, 2);
            return resultado;
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string resultado;
            lblMensaje.Text = Convert.ToString(CalculoIMC());
            resultado = Convert.ToString(CalculoIMC());

            await Shell.Current.GoToAsync($"//resultado?resultadoIMC={resultado}");
        }
    }
}
