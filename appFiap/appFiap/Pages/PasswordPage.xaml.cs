using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace appFiap
{
	public partial class PasswordPage : ContentPage
	{
		public PasswordPage()
		{
			InitializeComponent();
		}

		async void Recovery_Clicked(object sender, System.EventArgs e)
		{
			UserDialogs.Instance.ShowSuccess("Enviado para " + txtEmail.Text);

			await Navigation.PopModalAsync(true);
		}

		async void Cancel_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}

