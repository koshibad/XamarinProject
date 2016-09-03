using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

		async void Progress_Clicked(object sender, System.EventArgs e)
		{
			await progressBar.ProgressTo(1, 750, Easing.Linear);

			await Task.Delay(3000);
			progressBar.Progress = 0;
		}
	}
}

