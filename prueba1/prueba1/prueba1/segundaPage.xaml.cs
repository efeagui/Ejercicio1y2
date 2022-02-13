using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prueba1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class segundaPage : ContentPage
    {
        public segundaPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
            var Vnombre = txtnombre.Text;
            var Vapellido = txtapellido.Text;
            var Vedad = txtedad.Text;
            var Vcorreo = txtcorreo.Text;
            //var Vcorreo = Convert.ToString(txtcorreo);

            var datos = new Models.Persona
            {
                nombre = Vnombre,
                apellido = Vapellido,
                edad = Vedad,
                correo = Vcorreo

                
            };

            var verDatos = new Views.BindingPage();
            verDatos.BindingContext = datos;
            await Navigation.PushAsync(verDatos);
        }

        private async void btnregre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}