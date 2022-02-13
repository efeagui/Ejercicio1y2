using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prueba1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnagragar_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtnumber1.Text);
            var num2 = Convert.ToInt32(txtnumber2.Text);

            var sumita = Convert.ToString(num1 + num2);
            var restita = Convert.ToString(num1 - num2);
            var multi = Convert.ToString(num1 * num2);
            var division = Convert.ToString(num1 / num2);

            var operaciones = new Models.operacionesMate
            {
                suma = sumita,
                resta = restita,
                multi = multi,
                divi = division

            };

            var resultP = new Views.ResultPage();
            resultP.BindingContext = operaciones;
            await Navigation.PushAsync(resultP);

            //var num1 = Convert.ToDecimal(txtnum1.Text);
            // var num2 = Convert.ToDecimal(txtnum2.Text);

            // var sumita = Convert.ToString(num1 + num2);
            //var restita = Convert.ToString(num1 - num2);
            //var multi = Convert.ToString(num1 * num2);

            //lblsuma.Text = "Suma: "+sumita;
            //lblresta.Text = "Resta: "+restita;
            //lblmultiplicacion.Text ="Multiplicacion: " +multi;


            // await DisplayAlert("OPERACIONES MATEMATICAS", ";)", "OK");
            // await DisplayAlert("SUMA", Convert.ToString(num1 + num2), "OK");

            //limpiando cajas
            //txtnum1.Text = " ";
            //txtnum2.Text = " ";
        }

        private async void btnsegunda_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new menuPage());

            var menu = new menuPage();
            await Navigation.PushAsync(menu);


        }

        private async void btnsegunda_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
