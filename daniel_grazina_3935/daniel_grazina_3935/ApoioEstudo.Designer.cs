namespace daniel_grazina_3935
{
	partial class ApoioEstudo
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
			this.btnExit = new System.Windows.Forms.Button();
			this.lblEfeiteApoioAoEstudo = new System.Windows.Forms.Label();
			this.lblEfeiteDivisória1 = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.lblEfeitoBemVindo = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEfeiteDivisória2 = new System.Windows.Forms.Label();
			this.lblEfeiteNivel = new System.Windows.Forms.Label();
			this.lblNivel = new System.Windows.Forms.Label();
			this.tcApoioEstudo = new System.Windows.Forms.TabControl();
			this.tpQuestoes = new System.Windows.Forms.TabPage();
			this.tpResultados = new System.Windows.Forms.TabPage();
			this.tpGestao = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tcApoioEstudo.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::daniel_grazina_3935.Properties.Resources._default;
			this.pictureBox1.Location = new System.Drawing.Point(0, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 601);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnExit
			// 
			this.btnExit.BackgroundImage = global::daniel_grazina_3935.Properties.Resources.Icon_Exit;
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(1102, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(36, 37);
			this.btnExit.TabIndex = 5;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblEfeiteApoioAoEstudo
			// 
			this.lblEfeiteApoioAoEstudo.AutoSize = true;
			this.lblEfeiteApoioAoEstudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteApoioAoEstudo.Location = new System.Drawing.Point(246, 20);
			this.lblEfeiteApoioAoEstudo.Name = "lblEfeiteApoioAoEstudo";
			this.lblEfeiteApoioAoEstudo.Size = new System.Drawing.Size(273, 29);
			this.lblEfeiteApoioAoEstudo.TabIndex = 6;
			this.lblEfeiteApoioAoEstudo.Text = "Apoio ao Estudo | v1.0";
			// 
			// lblEfeiteDivisória1
			// 
			this.lblEfeiteDivisória1.AutoSize = true;
			this.lblEfeiteDivisória1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteDivisória1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteDivisória1.Location = new System.Drawing.Point(246, 41);
			this.lblEfeiteDivisória1.Name = "lblEfeiteDivisória1";
			this.lblEfeiteDivisória1.Size = new System.Drawing.Size(861, 13);
			this.lblEfeiteDivisória1.TabIndex = 7;
			this.lblEfeiteDivisória1.Text = "_________________________________________________________________________________" +
    "_________________________________________";
			// 
			// lblData
			// 
			this.lblData.AutoSize = true;
			this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblData.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblData.Location = new System.Drawing.Point(1026, 63);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(81, 16);
			this.lblData.TabIndex = 8;
			this.lblData.Text = "00/00/0000";
			// 
			// lblEfeitoBemVindo
			// 
			this.lblEfeitoBemVindo.AutoSize = true;
			this.lblEfeitoBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeitoBemVindo.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeitoBemVindo.Location = new System.Drawing.Point(246, 64);
			this.lblEfeitoBemVindo.Name = "lblEfeitoBemVindo";
			this.lblEfeitoBemVindo.Size = new System.Drawing.Size(70, 15);
			this.lblEfeitoBemVindo.TabIndex = 9;
			this.lblEfeitoBemVindo.Text = "Bem Vindo:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblNome.Location = new System.Drawing.Point(322, 64);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(41, 15);
			this.lblNome.TabIndex = 10;
			this.lblNome.Text = "daniel";
			// 
			// lblEfeiteDivisória2
			// 
			this.lblEfeiteDivisória2.AutoSize = true;
			this.lblEfeiteDivisória2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteDivisória2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteDivisória2.Location = new System.Drawing.Point(379, 63);
			this.lblEfeiteDivisória2.Name = "lblEfeiteDivisória2";
			this.lblEfeiteDivisória2.Size = new System.Drawing.Size(11, 15);
			this.lblEfeiteDivisória2.TabIndex = 11;
			this.lblEfeiteDivisória2.Text = "|";
			// 
			// lblEfeiteNivel
			// 
			this.lblEfeiteNivel.AutoSize = true;
			this.lblEfeiteNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteNivel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteNivel.Location = new System.Drawing.Point(405, 64);
			this.lblEfeiteNivel.Name = "lblEfeiteNivel";
			this.lblEfeiteNivel.Size = new System.Drawing.Size(37, 15);
			this.lblEfeiteNivel.TabIndex = 12;
			this.lblEfeiteNivel.Text = "Nivel:";
			// 
			// lblNivel
			// 
			this.lblNivel.AutoSize = true;
			this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNivel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblNivel.Location = new System.Drawing.Point(448, 64);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(42, 15);
			this.lblNivel.TabIndex = 13;
			this.lblNivel.Text = "admin";
			// 
			// tcApoioEstudo
			// 
			this.tcApoioEstudo.Controls.Add(this.tpQuestoes);
			this.tcApoioEstudo.Controls.Add(this.tpResultados);
			this.tcApoioEstudo.Controls.Add(this.tpGestao);
			this.tcApoioEstudo.Location = new System.Drawing.Point(251, 103);
			this.tcApoioEstudo.Name = "tcApoioEstudo";
			this.tcApoioEstudo.SelectedIndex = 0;
			this.tcApoioEstudo.Size = new System.Drawing.Size(887, 485);
			this.tcApoioEstudo.TabIndex = 14;
			// 
			// tpQuestoes
			// 
			this.tpQuestoes.Location = new System.Drawing.Point(4, 22);
			this.tpQuestoes.Name = "tpQuestoes";
			this.tpQuestoes.Padding = new System.Windows.Forms.Padding(3);
			this.tpQuestoes.Size = new System.Drawing.Size(879, 459);
			this.tpQuestoes.TabIndex = 0;
			this.tpQuestoes.Text = "Questões de Estudo";
			this.tpQuestoes.UseVisualStyleBackColor = true;
			// 
			// tpResultados
			// 
			this.tpResultados.Location = new System.Drawing.Point(4, 22);
			this.tpResultados.Name = "tpResultados";
			this.tpResultados.Padding = new System.Windows.Forms.Padding(3);
			this.tpResultados.Size = new System.Drawing.Size(879, 459);
			this.tpResultados.TabIndex = 1;
			this.tpResultados.Text = "Resultados";
			this.tpResultados.UseVisualStyleBackColor = true;
			// 
			// tpGestao
			// 
			this.tpGestao.Location = new System.Drawing.Point(4, 22);
			this.tpGestao.Name = "tpGestao";
			this.tpGestao.Padding = new System.Windows.Forms.Padding(3);
			this.tpGestao.Size = new System.Drawing.Size(879, 459);
			this.tpGestao.TabIndex = 2;
			this.tpGestao.Text = "Gestão Utilizadores";
			this.tpGestao.UseVisualStyleBackColor = true;
			// 
			// ApoioEstudo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 600);
			this.ControlBox = false;
			this.Controls.Add(this.tcApoioEstudo);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.lblEfeiteNivel);
			this.Controls.Add(this.lblEfeiteDivisória2);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblEfeitoBemVindo);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.lblEfeiteApoioAoEstudo);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblEfeiteDivisória1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ApoioEstudo";
			this.Text = "ApoioEstudo";
			this.Load += new System.EventHandler(this.ApoioEstudo_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tcApoioEstudo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblEfeiteApoioAoEstudo;
		private System.Windows.Forms.Label lblEfeiteDivisória1;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblEfeitoBemVindo;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblEfeiteDivisória2;
		private System.Windows.Forms.Label lblEfeiteNivel;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.TabControl tcApoioEstudo;
		private System.Windows.Forms.TabPage tpQuestoes;
		private System.Windows.Forms.TabPage tpResultados;
		private System.Windows.Forms.TabPage tpGestao;
	}
}