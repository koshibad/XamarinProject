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

		async void Login_Clicked(object sender, System.EventArgs e)
		{
			//DisplayAlert(txtLogin.Text, txtSenha.Text, "OK", "Cancelar");

			UserDialogs.Instance.ShowLoading("logando com " + txtLogin.Text);

			await Task.Delay(1000);

			UserDialogs.Instance.HideLoading();

			//Navigation.InsertPageBefore(new TabPage(), this);
			//await Navigation.PopAsync();

			await Navigation.PushAsync(new NavigationPage(new TabPage()));
		}

		async void FormSignOn_Clicked(object sender, System.EventArgs e)
		{
			//await Navigation.PushAsync(new NavigationPage(new SignOnPage()));
			await Navigation.PushModalAsync(new SignOnPage());
		}

		async void PasswordRecovery_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushModalAsync(new PasswordPage());
		}
	}
}