using System;
using System.Collections.Generic;
using Aspronto.Logic;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Aspronto
{
    public partial class DashboardPage : ContentPage
    {
        Geocoder geoCoder;
        //String currentLocation = string.Empty;

        public DashboardPage()
        {
            InitializeComponent();
            geoCoder = new Geocoder();
        }

        protected override async void OnAppearing()
		{
            base.OnAppearing();

            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync();

            var cO = await COLogic.GetCO(position.Latitude, position.Longitude);
            var o3 = await O3Logic.GetO3(position.Latitude, position.Longitude);
            var nO2 = await NO2Logic.GetNO2(position.Latitude, position.Longitude);
            var sO2 = await SO2Logic.GetSO2(position.Latitude, position.Longitude);

            var geoPosition = new Position(position.Latitude, position.Longitude);

            var rawAddress = await geoCoder.GetAddressesForPositionAsync(geoPosition);

            foreach (var address in rawAddress)
                currentLocation.Text += address + "\n";
		}
	}
}
