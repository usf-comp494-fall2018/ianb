using BondFinal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BondFinal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<NorthwindDisplayData> _display;
        public MainPage()
        {
            this.InitializeComponent();
            _display = new ObservableCollection<NorthwindDisplayData>();
            results.ItemsSource = _display;
            CurrentCondtionsButton_Click(this, null);
        }

        private async void CurrentCondtionsButton_Click(object sender, RoutedEventArgs e)
        {
            _display.Clear();
            using (var client = new HttpClient())
            {
                var readConditions = await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/2");
                var weatherList = JsonConvert.DeserializeObject<CurrentConditions>(readConditions);
                {
                    _display.Add(new NorthwindDisplayData()
                    {
                        Id = weatherList.Id,
                        DisplayLargeText = weatherList.Weather,
                        DisplaySmallText = $"It is currently {weatherList.TempF}°F with {weatherList.RelativeHumidity} humidity\nWinds blowing {weatherList.WindDir} at {weatherList.WindMph}mph",
                        Date = $"{weatherList.ObservationTime}",
                        ImagePath = ImgPath(weatherList.Weather)
                    });
                }
            }
        }

        private async void ThreeDayForcastButton_Click(object sender, RoutedEventArgs e)
        {
            _display.Clear();
            using (var client = new HttpClient())
            {
                var readWeather = await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                var weatherList = JsonConvert.DeserializeObject<List<ThreeDay>>(readWeather);
                foreach (var ThreeDay in weatherList)
                {
                    _display.Add(new NorthwindDisplayData()
                    {
                        Id = ThreeDay.Id,
                        DisplayLargeText = ThreeDay.Title,
                        DisplaySmallText = $"{ThreeDay.Fcttext}",
                        Date = $"Last checked: {ThreeDay.Lastcheck.ToString()}",
                        ImagePath = ImgPath(ThreeDay.Icon)
                    });
                }
            }
        }

        private string ImgPath(string icon)
        {
            icon = icon.ToUpper();
            string imgSource = "Assets/Final Project Icons/Default.png";
            switch (icon)
            {
                case "OVERCAST":
                    imgSource = "Assets/Final Project Icons/Overcast.png";
                    break;
                case "CLOUDY":
                    imgSource = "Assets/Final Project Icons/Overcast.png";
                    break;
                case "MOSTLYCLOUDY":
                    imgSource = "Assets/Final Project Icons/Overcast.png";
                    break;
                case "NT_CLOUDY":
                    imgSource = "Assets/Final Project Icons/Overcast.png";
                    break;
                case "NT_MOSTLYCLOUDY":
                    imgSource = "Assets/Final Project Icons/Overcast.png";
                    break;
                case "PARTLYCLOUDY":
                    imgSource = "Assets/Final Project Icons/PartyCloudy.png";
                    break;
                case "NT_PARTLYCLOUDY":
                    imgSource = "Assets/Final Project Icons/NightPartlyCloudy.png";
                    break;
                case "CHANCERAIN":
                    imgSource = "Assets/Final Project Icons/Rain.png";
                    break;
                case "RAIN":
                    imgSource = "Assets/Final Project Icons/Rain.png";
                    break;
                case "NT_CHANCERAIN":
                    imgSource = "Assets/Final Project Icons/Rain.png";
                    break;
                case "NT_RAIN":
                    imgSource = "Assets/Final Project Icons/Rain.png";
                    break;
                case "CHANCESNOW":
                    imgSource = "Assets/Final Project Icons/Snow.png";
                    break;
                case "SNOW":
                    imgSource = "Assets/Final Project Icons/Snow.png";
                    break;
                case "NT_CHANCESNOW":
                    imgSource = "Assets/Final Project Icons/Snow.png";
                    break;
                case "NT_SNOW":
                    imgSource = "Assets/Final Project Icons/Snow.png";
                    break;
                case "CLEAR":
                    imgSource = "Assets/Final Project Icons/Sunny.png";
                    break;
                case "NT_CLEAR":
                    imgSource = "Assets/Final Project Icons/Moon.png";
                    break;
                case "STORM":
                    imgSource = "Assets/Final Project Icons/Thunderstorm.png";
                    break;
                case "NT_STORM":
                    imgSource = "Assets/Final Project Icons/Thunderstorm.png";
                    break;
                case "NT_WINDY":
                    imgSource = "Assets/Final Project Icons/Windy.png";
                    break;
                case "WINDY":
                    imgSource = "Assets/Final Project Icons/Windy.png";
                    break;
            }
            return imgSource;
        }
    }
}
