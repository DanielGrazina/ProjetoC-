using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace daniel_grazina_3935
{
	public partial class ApoioEstudo : Form
	{
		MySqlConnection con;
		MySqlCommand cmd;
		MySqlDataReader dr;
		
		//Strings para receber nome e pass do utilizador
		public String nome { get; set; }
		public String pass { get; set; }
		public ApoioEstudo()
		{
			con = new MySqlConnection("Server=localhost;Database=projeto;Uid=root;Pwd=Qop2006a;");
			InitializeComponent();
		}

		private void ApoioEstudo_Load(object sender, EventArgs e)
		{
				//abrir coneccao para a DB
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;
				
				//Query para pedir o nivel do utilizador
				cmd.CommandText = "Select lg_nivel from tbl_login where lg_nome='" + nome + "' and lg_pass='" + pass + "';";
				String nivel = (String)cmd.ExecuteScalar();

				//verificação do nivel do utilizador para desativar ou ativar pagina de gestão
				if (nivel == "guest")
				{
					tpGestao.Enabled = false;
				}
				else
				{
					tpGestao.Enabled = true;
				}

				//Labels de apresentação
				lblBemVindo.Text = "Bem Vindo:  " + nome + "  |  Nivel:  " + nivel;
				lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

				//fechar ligação
				con.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//Bool para resolver bug de ter de dar double clique nas checkboxs
		private bool doublecheck = false;
		private void UncheckAllCheckBoxesExcept_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is CheckBox selectedCheckBox && !doublecheck)
			{
				doublecheck = true;

				// Obtém a TabPage que contém a CheckBox selecionada
				TabPage tabPage = selectedCheckBox.Parent as TabPage;

				if (tabPage != null)
				{
					// Itera apenas sobre os controles dentro da TabPage
					foreach (Control control in tabPage.Controls)
					{
						if (control is CheckBox checkBox && checkBox != selectedCheckBox)
						{
							// Verifica se a CheckBox já está marcada antes de desmarcar
							if (checkBox.CheckState == CheckState.Checked)
							{
								// Desmarca apenas se já estiver marcada
								checkBox.Checked = false;
							}
						}
					}
				}

				doublecheck = false;
			}
		}
	}
}
