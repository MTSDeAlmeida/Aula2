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
	public partial class ResultPage : ContentPage
	{
		public ResultPage (AlunoModel objAluno)
		{            
            InitializeComponent ();

            lblNome.Text = "Nome: " + objAluno.Nome;
            lblDtNasc.Text= "Data Nascimento:" + objAluno.DtNasc;
            lblIdade.Text = "Idade: " + objAluno.Idade;
            lblSexo.Text = "Sexo: " + objAluno.Sexo;
            lblFone.Text = "Fone: " + objAluno.Telefone;
            lblEmail.Text = "Email: " + objAluno.Email;
        }
    }
}