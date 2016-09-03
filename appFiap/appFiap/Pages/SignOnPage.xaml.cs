using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace appFiap
{
	public partial class SignOnPage : ContentPage
	{
		public SignOnPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}

