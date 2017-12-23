using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aula2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if ((EntrySenha.Text == string.Empty) || (EntryLogin.Text == string.Empty))
            {
                await DisplayAlert("Atenção!", "Campo obrigatório", "OK");
            }

            if (EntrySenha.Text != "1234")
            {
                await DisplayAlert("Atenção!", "Senha Incorreta!", "OK");
            }

            if ((EntryLogin.Text != string.Empty) && (EntrySenha.Text == "1234"))
            {
                EntrySenha.Text = string.Empty;
                EntryLogin.Text = string.Empty;
                await Navigation.PushAsync(new PrincipalPage());
            }
        }
    }
}
