using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using Acr.UserDialogs;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace appFiap
{
	public partial class AdressPage : ContentPage
	{
		public AdressPage()
		{
			InitializeComponent();
		}

		async void Handle_Unfocused(object sender, Xamarin.Forms.FocusEventArgs e)
		{
			string sURL = "http://viacep.com.br/ws/{0}/json/";

			HttpClient cliente = new HttpClient();

			var uri = new Uri(string.Format(sURL, txtCep.Text));
			var response = await cliente.GetAsync(uri);

			if (!response.IsSuccessStatusCode)
			{
				UserDialogs.Instance.ShowError("erro");
				return;
			}

			UserDialogs.Instance.ShowSuccess("sucesso");
			var content = await response.Content.ReadAsStringAsync();

			CepResultModel cep = new CepResultModel();
			cep = JsonConvert.DeserializeObject<CepResultModel>(content);

			txtRua.Text = cep.rua;
			txtBairro.Text = cep.bairro;
			txtComplemento.Text = cep.complemento;
			txtCidade.Text = cep.cidade;
			txtEstado.Text = cep.estado;
			txtTexto.Focus();
		}
	}
}

