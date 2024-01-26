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

			con = new MySqlConnection("Server=localhost;Database=projeto;Uid=root;Pwd=Qop2006a;");
			InitializeComponent();
        }

		private void btnExit_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}

		private void btnHideShow_Click(object sender, EventArgs e)
		{
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

		private void button1_Click(object sender, EventArgs e)
		{
			String user = txtUser.Text;
			String pass = txtPass.Text;

			cmd = new MySqlCommand();
			con.Open();
			cmd.Connection = con;

			cmd.CommandText = "select * from tbl_login where lg_nome = '" + user + "' and lg_pass= '" + pass + "'";

			dr = cmd.ExecuteReader();

			if (dr.Read())
			{
				MessageBox.Show("Login com sucesso!!");
			}
			else
			{
				lblErro.Visible = true;
				txtUser.Clear();
				txtPass.Clear();
				txtUser.Focus();
			}
			con.Close();
		}
	}
}
