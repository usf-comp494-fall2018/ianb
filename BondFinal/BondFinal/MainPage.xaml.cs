using BondFinal.Models;
//using Newtonsoft.Json;
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
        ObservableCollection<NorthwindDisplayData> _dispay;
        public MainPage()
        {
            this.InitializeComponent();
            _dispay = new ObservableCollection<NorthwindDisplayData>();
            results.ItemsSource = _dispay;
        }

        private void CurrentCondtionsButton_Click(object sender, RoutedEventArgs e)
        {
            _dispay.Clear();
        }

        private void ThreeDayForcastButton_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                _dispay.Clear();
                var test = client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                _dispay.Add(new NorthwindDisplayData()
                {
                    Info = test.ToString()
                });
            }
        }
    }
}
