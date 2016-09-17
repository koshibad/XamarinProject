using System;
using System.Collections.Generic;
using System.Net.Http;
using Acr.UserDialogs;
using Newtonsoft.Json;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace appFiap
{
	public partial class DataPage : ContentPage
	{
		public DataPage()
		{
			InitializeComponent();

			geoloc();
		}

		async private void geoloc()
		{
			var locator = CrossGeolocator.Current;
			locator.DesiredAccuracy = 50;
			var position = await locator.GetPositionAsync(10000);

			string lat = position.Latitude.ToString();
			string lon = position.Longitude.ToString();
			//txtTexto.Text = lat + " *** " + lon;

			lblLat.Text = lat;
			lblLong.Text = lon;

			var pos = new Position(position.Latitude, position.Longitude);
			map.MoveToRegion(MapSpan.FromCenterAndRadius(pos, Distance.FromMiles(1)));

			var pin = new Pin
			{
				Type = PinType.Place,
				Position = pos,
				Label = "local",
				Address = "cidade"
			};

			map.Pins.Add(pin);

			string url = "http://api.geonames.org/findNearByWeatherJSON?"+
				"lat=" + lat + 
				"&lng=" + lon + 
				"&username=deznetfiap";

			HttpClient cliente = new HttpClient();

			var uri = new Uri(url);
			var response = await cliente.GetAsync(uri);

			if (!response.IsSuccessStatusCode)
			{
				UserDialogs.Instance.ShowError("erro");
				return;
			}

			//UserDialogs.Instance.ShowSuccess("sucesso");
			var content = await response.Content.ReadAsStringAsync();

			var tempo = new TempoResultModel();
			tempo = JsonConvert.DeserializeObject<TempoResultModel>(content);

			lblLoc.Text = tempo.weatherObservation.stationName;
			lblTemp.Text = tempo.weatherObservation.temperature;
		}
	}
}

