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

namespace daniel_grazina_3935
{
    public partial class Login : Form
    {
        public Login()
        {
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
	}
}
