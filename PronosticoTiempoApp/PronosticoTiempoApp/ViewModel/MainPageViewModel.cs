using Newtonsoft.Json;
using PronosticoTiempoApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;


namespace PronosticoTiempoApp.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private ClimaPuno clima1;

        public event PropertyChangedEventHandler PropertyChanged;

        public ClimaPuno clima
        {
            get => clima1;
            set
            {
                clima1 = value;
                OnPropertyChanged();
            }

        }

        public MainPageViewModel()
        {
            GetClimaPuno();
        }
        private async void GetClimaPuno()
        {
            string url = "https://api.tutiempo.net/json/?lan=es&apid=4CGXXz4aa44N4d9&lid=103527";
            HttpClient cliente = new HttpClient();
            HttpResponseMessage respuesta = await cliente.GetAsync(url);
            var json = await respuesta.Content.ReadAsStringAsync();
            //Debug.WriteLine(json);
            //Application.Current.MainPage.DisplayAlert("msg", json.ToString(), "OK");
            clima = JsonConvert.DeserializeObject<ClimaPuno>(json);

            Console.WriteLine(clima.hour_hour.hour1.icon_wind);
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
