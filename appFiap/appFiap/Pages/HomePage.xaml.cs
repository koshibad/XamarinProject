using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace appFiap
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			App.Current.MainPage = new NavigationPage(new LoginPage());
		}
	}
}

