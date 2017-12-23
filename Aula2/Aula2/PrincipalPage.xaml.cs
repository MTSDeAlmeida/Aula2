using Aula2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aula2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrincipalPage : ContentPage
	{
		public PrincipalPage ()
		{              
			InitializeComponent ();
        }

        async void btnSalvar_Clicked(object sender, EventArgs e){

            AlunoModel objAluno = new AlunoModel();
            objAluno.Nome = EntryNome.Text;
            objAluno.Idade = Convert.ToInt32(EntryIdade.Text);
            objAluno.Sexo = picSexo.SelectedItem.ToString();
            objAluno.Telefone = EntryFone.Text;
            objAluno.Email = EntryEmail.Text;
           // objAluno.DtNasc = dpDataNascimento.ToString();



            await Navigation.PushAsync(new ResultPage(objAluno));
        }
	}
}