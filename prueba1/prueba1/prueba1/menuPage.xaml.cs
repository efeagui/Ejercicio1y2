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
    public partial class menuPage : ContentPage
    {
        public menuPage()
        {
            InitializeComponent();
        }

        private async void btnApp1_Clicked(object sender, EventArgs e)
        {
            var main = new MainPage();
            await Navigation.PushAsync(main);

        }

        private async void btnApp2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new segundaPage());



        }
    }
}