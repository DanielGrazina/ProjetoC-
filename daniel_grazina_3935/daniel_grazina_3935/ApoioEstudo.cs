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
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;

				cmd.CommandText = "Select lg_nivel from tbl_login where lg_nome='" + nome + "' and lg_pass='" + pass + "';";
				String nivel = (String)cmd.ExecuteScalar();

				if (nivel == "guest")
				{
					tpGestao.Enabled = false;
				}
				else
				{
					tpGestao.Enabled = true;
				}

				lblNome.Text = nome;
				lblNivel.Text = nivel;
				lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");

				con.Close();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

	}
}
