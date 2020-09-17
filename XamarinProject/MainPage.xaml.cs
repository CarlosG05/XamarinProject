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
    [QueryProperty("mensaje", "Mensaje")]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public string Mensaje {
            set { lblMensaje.Text = value; }
        }
    }
}
