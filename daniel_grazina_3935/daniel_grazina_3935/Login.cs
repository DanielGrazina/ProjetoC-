using daniel_grazina_3935.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace daniel_grazina_3935
{
    public partial class Login : Form
    {
		MySqlConnection con;
		MySqlCommand cmd;
		MySqlDataReader dr;
		public Login()
        {
			//Coneccao base de dados
			con = new MySqlConnection("Server=127.0.0.1;Database=projeto;Uid=root;Pwd=Qop2006a;");
			InitializeComponent();
        }

		//Botão mostrar e esconder passs
		private void btnHideShow_Click(object sender, EventArgs e)
		{
			//verificação para esconder ou mostrar pass
			if (txtPass.PasswordChar == '•')
			{
				txtPass.PasswordChar = '\0';
				btnHideShow.BackgroundImage = Resources.hide;
			}
			else
			{
				txtPass.PasswordChar = '•';
				btnHideShow.BackgroundImage = Resources.visible;
			}
		}

		//Botão de login
		private void btnLogin_Click(object sender, EventArgs e)
		{
			//Variaveis para armazenar o user e a pass
			String user = txtUser.Text;
			String pass = txtPass.Text;

			//abrir coneccao DB
			con.Open();
			cmd = new MySqlCommand();
			cmd.Connection = con;

			//Query para verificação do login
			cmd.CommandText = "select * from tbl_login where lg_nome = '" + user + "' and lg_pass= '" + pass + "'";

			//Executar query
			dr = cmd.ExecuteReader();

			//Verificação do login
			if (dr.Read())
			{
				this.Hide();
				ApoioEstudo fr2 = new ApoioEstudo();
				//Passar nome e pass para o ApoioEstudo. Fazer no ApoioEstudo verificação de nivel.
				fr2.nome = user;
				fr2.pass = pass;
				fr2.ShowDialog();
				this.Close();
			}
			else
			{
				//Mostrar mensagem de erro e limpar caixas de texto
				lblErro.Visible = true;
				txtUser.Clear();
				txtPass.Clear();
				txtUser.Focus();
			}
			//Fechar ligação
			con.Close();
		}

		//Botão para sair da aplicação
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
