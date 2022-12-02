using PronosticoTiempoApp.View;
using PronosticoTiempoApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PronosticoTiempoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
        private void Button_DiasSemana(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DiasSemana());
        }
        private void Button_Horas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HorasDia());
        }

        

    }
}

