using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;

using Xamarin.Forms;

namespace appFiap
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//DisplayAlert(txtLogin.Text, txtSenha.Text, "OK", "Cancelar");

			UserDialogs.Instance.ShowLoading("logando com " + txtLogin.Text);

			await Task.Delay(3000);

			UserDialogs.Instance.HideLoading();

			Navigation.InsertPageBefore(new TabPage(), this);
			await Navigation.PopAsync();
		}

		async void FormSignOn_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new SignOnPage());
		}
	}
}