using System;
using System.Collections.Generic;
using System.Text;

namespace PronosticoTiempoApp.Model
{
    class ClimaPuno
    {
        public string copyright { get; set; }
        public string use { get; set; }
        public Information information { get; set; }
        public string web { get; set; }
        public string language { get; set; }
        public Locality locality { get; set; }
        public Day day1 { get; set; }
        public Day day2 { get; set; }
        public Day day3 { get; set; }
        public Day day4 { get; set; }
        public Day day5 { get; set; }
        public Day day6 { get; set; }
        public Day day7 { get; set; }
        public Hour_hour hour_hour { get; set; }

        public class Information
        {
            public string temperature { get; set; }
            public string wind { get; set; }
            public string humidity { get; set; }
            public string pressure { get; set; }

        }
        public class Locality
        {
            public string name { get; set; }
            public string url_weather_forecast_15_days { get; set; }
            public string url_hourly_forecast { get; set; }
            public string country { get; set; }
            public string url_country { get; set; }

        }
        public class Day
        {
            public string date { get; set; }
            public int temperature_max { get; set; }
            public int temperature_min { get; set; }
            public string icon { get; set; }
            public string text { get; set; }
            public int humidity { get; set; }
            public int wind { get; set; }
            public string wind_direction { get; set; }
            public string icon_wind { get; set; }
            public string sunrise { get; set; }
            public string sunset { get; set; }
            public string moonrise { get; set; }
            public string moonset { get; set; }
            public string moon_phases_icon { get; set; }

        }
        public class Hour
        {
            public string date { get; set; }
            public string hour_data { get; set; }
            public int temperature { get; set; }
            public string text { get; set; }
            public int humidity { get; set; }
            public int pressure { get; set; }
            public string icon { get; set; }
            public int wind { get; set; }
            public string wind_direction { get; set; }
            public string icon_wind { get; set; }

        }
        public class Hour_hour
        {
            public Hour hour1 { get; set; }
            public Hour hour2 { get; set; }
            public Hour hour3 { get; set; }
            public Hour hour4 { get; set; }
            public Hour hour5 { get; set; }
            public Hour hour6 { get; set; }
            public Hour hour7 { get; set; }
            public Hour hour8 { get; set; }
            public Hour hour9 { get; set; }
            public Hour hour10 { get; set; }
            public Hour hour11 { get; set; }
            public Hour hour12 { get; set; }
            public Hour hour13 { get; set; }
            public Hour hour14 { get; set; }
            public Hour hour15 { get; set; }
            public Hour hour16 { get; set; }
            public Hour hour17 { get; set; }
            public Hour hour18 { get; set; }
            public Hour hour19 { get; set; }
            public Hour hour20 { get; set; }
            public Hour hour21 { get; set; }
            public Hour hour22 { get; set; }
            public Hour hour23 { get; set; }
            public Hour hour24 { get; set; }
            public Hour hour25 { get; set; }

        }
    }
}
