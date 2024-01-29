namespace daniel_grazina_3935
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblMember = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnHideShow = new System.Windows.Forms.Button();
			this.lblErro = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::daniel_grazina_3935.Properties.Resources.Icon_Login;
			this.pictureBox1.Location = new System.Drawing.Point(132, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblMember
			// 
			this.lblMember.AutoSize = true;
			this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.lblMember.Location = new System.Drawing.Point(109, 198);
			this.lblMember.Name = "lblMember";
			this.lblMember.Size = new System.Drawing.Size(197, 31);
			this.lblMember.TabIndex = 1;
			this.lblMember.Text = "Member Login";
			// 
			// txtUser
			// 
			this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUser.Location = new System.Drawing.Point(98, 266);
			this.txtUser.Multiline = true;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(219, 27);
			this.txtUser.TabIndex = 1;
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = global::daniel_grazina_3935.Properties.Resources.Icon_Exit;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(367, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(36, 37);
			this.btnExit.TabIndex = 4;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(94, 254);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(29, 13);
			this.lblUser.TabIndex = 5;
			this.lblUser.Text = "User";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(94, 312);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(53, 13);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Password";
			// 
			// txtPass
			// 
			this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.Location = new System.Drawing.Point(98, 324);
			this.txtPass.Multiline = true;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '•';
			this.txtPass.Size = new System.Drawing.Size(184, 27);
			this.txtPass.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(148, 477);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "DanielGrazina 2024";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(133)))), ((int)(((byte)(197)))));
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
			this.btnLogin.Location = new System.Drawing.Point(98, 383);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(219, 51);
			this.btnLogin.TabIndex = 9;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnHideShow
			// 
			this.btnHideShow.BackgroundImage = global::daniel_grazina_3935.Properties.Resources.visible;
			this.btnHideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnHideShow.FlatAppearance.BorderSize = 0;
			this.btnHideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHideShow.Location = new System.Drawing.Point(284, 324);
			this.btnHideShow.Name = "btnHideShow";
			this.btnHideShow.Size = new System.Drawing.Size(33, 34);
			this.btnHideShow.TabIndex = 10;
			this.btnHideShow.UseVisualStyleBackColor = true;
			this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
			// 
			// lblErro
			// 
			this.lblErro.AutoSize = true;
			this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblErro.ForeColor = System.Drawing.Color.Red;
			this.lblErro.Location = new System.Drawing.Point(122, 437);
			this.lblErro.Name = "lblErro";
			this.lblErro.Size = new System.Drawing.Size(171, 18);
			this.lblErro.TabIndex = 11;
			this.lblErro.Text = "Erro ao efetuar login!!";
			this.lblErro.Visible = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(415, 492);
			this.ControlBox = false;
			this.Controls.Add(this.lblErro);
			this.Controls.Add(this.btnHideShow);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lblMember);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblMember;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnHideShow;
		private System.Windows.Forms.Label lblErro;
	}
}

