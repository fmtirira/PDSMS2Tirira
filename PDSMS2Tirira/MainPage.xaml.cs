using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDSMS2Tirira
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string clave)
        {
            InitializeComponent();
        }


        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //almacenar los datos en variables
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            //Navegacion a la ventana dos

            await Navigation.PushAsync(new ViewDos(usuario, clave));


        }
    }
}
