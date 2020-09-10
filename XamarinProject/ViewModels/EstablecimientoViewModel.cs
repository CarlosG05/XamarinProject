using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinProject.ViewModels
{
    public class EstablecimientoViewModel : BaseViewModel
    {
        private int id;
        private string nombre;
        private string articulo;
        private double valor;
        public ICommand ComandoLimpiar { get; set; }
        public ICommand ComandoEnviar { get; set; }

        public int Id
        {
            get => id;
            set { id = value; OnPropertyChanged(nameof(id)); }
        }

        public string Nombre
        {
            get => nombre;
            set { nombre = value; OnPropertyChanged(nameof(nombre)); }
        }

        public string Articulo
        {
            get => articulo;
            set { articulo = value; OnPropertyChanged(nameof(articulo)); }
        }

        public double Valor
        {
            get => valor;
            set { valor = value; OnPropertyChanged(nameof(valor)); }
        }

        #region Metodos
        void Limpiar()
        {
            Nombre = string.Empty;
            Articulo = string.Empty;
            Valor = 0.0;
            
        }

        async Task Enviar()
        {
            try
            {
                EmailMessage mensaje = new EmailMessage
                {
                    Subject = "¡Nuevo producto!",
                    Body = $"Producto: {Nombre} \n Artículo: {Articulo }  \nPrecio: {Valor:N2}",
                    To = new List<string> { "rubenefrain@gmail.com" }
                };
                await Email.ComposeAsync(mensaje);
            }
            catch (Exception)
            {

            }
        }
        #endregion

        //Constructor
        public EstablecimientoViewModel()
        {
            ComandoLimpiar = new Command(Limpiar);
            ComandoEnviar = new Command(async () => await Enviar());
        }



    }
}
