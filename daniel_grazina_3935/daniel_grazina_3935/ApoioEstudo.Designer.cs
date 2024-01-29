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
			this.lblEfeiteApoioAoEstudo = new System.Windows.Forms.Label();
			this.lblEfeiteDivisória1 = new System.Windows.Forms.Label();
			this.lblData = new System.Windows.Forms.Label();
			this.lblBemVindo = new System.Windows.Forms.Label();
			this.tcApoioEstudo = new System.Windows.Forms.TabControl();
			this.tpQuestoes = new System.Windows.Forms.TabPage();
			this.btnPerguntaAnterior = new System.Windows.Forms.Button();
			this.btnProximaPergunta = new System.Windows.Forms.Button();
			this.cbD = new System.Windows.Forms.CheckBox();
			this.cbC = new System.Windows.Forms.CheckBox();
			this.cbB = new System.Windows.Forms.CheckBox();
			this.cbA = new System.Windows.Forms.CheckBox();
			this.lblRespostaD = new System.Windows.Forms.Label();
			this.lblRespostaC = new System.Windows.Forms.Label();
			this.lblRespostaB = new System.Windows.Forms.Label();
			this.lblRespostaA = new System.Windows.Forms.Label();
			this.lblEfeiteReposta2 = new System.Windows.Forms.Label();
			this.lblEfeiteReposta3 = new System.Windows.Forms.Label();
			this.lblEfeiteReposta4 = new System.Windows.Forms.Label();
			this.lblEfeiteReposta1 = new System.Windows.Forms.Label();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.lblNumPergunta = new System.Windows.Forms.Label();
			this.pcbQuestoes = new System.Windows.Forms.PictureBox();
			this.lblEfeiteQuestoes = new System.Windows.Forms.Label();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.cbMaterias = new System.Windows.Forms.ComboBox();
			this.lblEfeiteMatéria = new System.Windows.Forms.Label();
			this.lblEfeiteDivisoria3 = new System.Windows.Forms.Label();
			this.lblEfeiteNavegacao = new System.Windows.Forms.Label();
			this.lblEfeiteDivisoria4 = new System.Windows.Forms.Label();
			this.tpResultados = new System.Windows.Forms.TabPage();
			this.tpGestao = new System.Windows.Forms.TabPage();
			this.btnExit = new System.Windows.Forms.Button();
			this.pcbEfeiteEstudar = new System.Windows.Forms.PictureBox();
			this.tcApoioEstudo.SuspendLayout();
			this.tpQuestoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbQuestoes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbEfeiteEstudar)).BeginInit();
			this.SuspendLayout();
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
			// lblBemVindo
			// 
			this.lblBemVindo.AutoSize = true;
			this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblBemVindo.Location = new System.Drawing.Point(246, 64);
			this.lblBemVindo.Name = "lblBemVindo";
			this.lblBemVindo.Size = new System.Drawing.Size(211, 16);
			this.lblBemVindo.TabIndex = 9;
			this.lblBemVindo.Text = "Bem Vindo:  daniel  |  Nivel:  admin";
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
			this.tpQuestoes.Controls.Add(this.btnPerguntaAnterior);
			this.tpQuestoes.Controls.Add(this.btnProximaPergunta);
			this.tpQuestoes.Controls.Add(this.cbD);
			this.tpQuestoes.Controls.Add(this.cbC);
			this.tpQuestoes.Controls.Add(this.cbB);
			this.tpQuestoes.Controls.Add(this.cbA);
			this.tpQuestoes.Controls.Add(this.lblRespostaD);
			this.tpQuestoes.Controls.Add(this.lblRespostaC);
			this.tpQuestoes.Controls.Add(this.lblRespostaB);
			this.tpQuestoes.Controls.Add(this.lblRespostaA);
			this.tpQuestoes.Controls.Add(this.lblEfeiteReposta2);
			this.tpQuestoes.Controls.Add(this.lblEfeiteReposta3);
			this.tpQuestoes.Controls.Add(this.lblEfeiteReposta4);
			this.tpQuestoes.Controls.Add(this.lblEfeiteReposta1);
			this.tpQuestoes.Controls.Add(this.lblPergunta);
			this.tpQuestoes.Controls.Add(this.lblNumPergunta);
			this.tpQuestoes.Controls.Add(this.pcbQuestoes);
			this.tpQuestoes.Controls.Add(this.lblEfeiteQuestoes);
			this.tpQuestoes.Controls.Add(this.btnIniciar);
			this.tpQuestoes.Controls.Add(this.cbMaterias);
			this.tpQuestoes.Controls.Add(this.lblEfeiteMatéria);
			this.tpQuestoes.Controls.Add(this.lblEfeiteDivisoria3);
			this.tpQuestoes.Controls.Add(this.lblEfeiteNavegacao);
			this.tpQuestoes.Controls.Add(this.lblEfeiteDivisoria4);
			this.tpQuestoes.Location = new System.Drawing.Point(4, 22);
			this.tpQuestoes.Name = "tpQuestoes";
			this.tpQuestoes.Padding = new System.Windows.Forms.Padding(3);
			this.tpQuestoes.Size = new System.Drawing.Size(879, 459);
			this.tpQuestoes.TabIndex = 0;
			this.tpQuestoes.Text = "Questões de Estudo";
			this.tpQuestoes.UseVisualStyleBackColor = true;
			// 
			// btnPerguntaAnterior
			// 
			this.btnPerguntaAnterior.Location = new System.Drawing.Point(634, 380);
			this.btnPerguntaAnterior.Name = "btnPerguntaAnterior";
			this.btnPerguntaAnterior.Size = new System.Drawing.Size(75, 23);
			this.btnPerguntaAnterior.TabIndex = 36;
			this.btnPerguntaAnterior.Text = "<";
			this.btnPerguntaAnterior.UseVisualStyleBackColor = true;
			// 
			// btnProximaPergunta
			// 
			this.btnProximaPergunta.Location = new System.Drawing.Point(715, 380);
			this.btnProximaPergunta.Name = "btnProximaPergunta";
			this.btnProximaPergunta.Size = new System.Drawing.Size(75, 23);
			this.btnProximaPergunta.TabIndex = 35;
			this.btnProximaPergunta.Text = ">";
			this.btnProximaPergunta.UseVisualStyleBackColor = true;
			// 
			// cbD
			// 
			this.cbD.Location = new System.Drawing.Point(763, 269);
			this.cbD.Name = "cbD";
			this.cbD.Size = new System.Drawing.Size(17, 24);
			this.cbD.TabIndex = 33;
			this.cbD.UseVisualStyleBackColor = true;
			this.cbD.CheckedChanged += new System.EventHandler(this.UncheckAllCheckBoxesExcept_CheckedChanged);
			// 
			// cbC
			// 
			this.cbC.Location = new System.Drawing.Point(763, 230);
			this.cbC.Name = "cbC";
			this.cbC.Size = new System.Drawing.Size(17, 24);
			this.cbC.TabIndex = 32;
			this.cbC.UseVisualStyleBackColor = true;
			this.cbC.CheckedChanged += new System.EventHandler(this.UncheckAllCheckBoxesExcept_CheckedChanged);
			// 
			// cbB
			// 
			this.cbB.Location = new System.Drawing.Point(763, 190);
			this.cbB.Name = "cbB";
			this.cbB.Size = new System.Drawing.Size(17, 24);
			this.cbB.TabIndex = 31;
			this.cbB.UseVisualStyleBackColor = true;
			this.cbB.CheckedChanged += new System.EventHandler(this.UncheckAllCheckBoxesExcept_CheckedChanged);
			// 
			// cbA
			// 
			this.cbA.Location = new System.Drawing.Point(763, 149);
			this.cbA.Name = "cbA";
			this.cbA.Size = new System.Drawing.Size(17, 24);
			this.cbA.TabIndex = 30;
			this.cbA.UseVisualStyleBackColor = true;
			this.cbA.CheckedChanged += new System.EventHandler(this.UncheckAllCheckBoxesExcept_CheckedChanged);
			// 
			// lblRespostaD
			// 
			this.lblRespostaD.BackColor = System.Drawing.Color.Transparent;
			this.lblRespostaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRespostaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespostaD.Location = new System.Drawing.Point(187, 269);
			this.lblRespostaD.Name = "lblRespostaD";
			this.lblRespostaD.Size = new System.Drawing.Size(560, 28);
			this.lblRespostaD.TabIndex = 29;
			this.lblRespostaD.Text = "...";
			// 
			// lblRespostaC
			// 
			this.lblRespostaC.BackColor = System.Drawing.Color.Transparent;
			this.lblRespostaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRespostaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespostaC.Location = new System.Drawing.Point(187, 230);
			this.lblRespostaC.Name = "lblRespostaC";
			this.lblRespostaC.Size = new System.Drawing.Size(560, 28);
			this.lblRespostaC.TabIndex = 28;
			this.lblRespostaC.Text = "...";
			// 
			// lblRespostaB
			// 
			this.lblRespostaB.BackColor = System.Drawing.Color.Transparent;
			this.lblRespostaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRespostaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespostaB.Location = new System.Drawing.Point(187, 190);
			this.lblRespostaB.Name = "lblRespostaB";
			this.lblRespostaB.Size = new System.Drawing.Size(560, 28);
			this.lblRespostaB.TabIndex = 27;
			this.lblRespostaB.Text = "...";
			// 
			// lblRespostaA
			// 
			this.lblRespostaA.BackColor = System.Drawing.Color.Transparent;
			this.lblRespostaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRespostaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRespostaA.Location = new System.Drawing.Point(187, 148);
			this.lblRespostaA.Name = "lblRespostaA";
			this.lblRespostaA.Size = new System.Drawing.Size(560, 28);
			this.lblRespostaA.TabIndex = 26;
			this.lblRespostaA.Text = "...";
			// 
			// lblEfeiteReposta2
			// 
			this.lblEfeiteReposta2.BackColor = System.Drawing.Color.Transparent;
			this.lblEfeiteReposta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteReposta2.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteReposta2.Location = new System.Drawing.Point(153, 186);
			this.lblEfeiteReposta2.Name = "lblEfeiteReposta2";
			this.lblEfeiteReposta2.Size = new System.Drawing.Size(28, 28);
			this.lblEfeiteReposta2.TabIndex = 25;
			this.lblEfeiteReposta2.Text = "b)";
			this.lblEfeiteReposta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEfeiteReposta3
			// 
			this.lblEfeiteReposta3.BackColor = System.Drawing.Color.Transparent;
			this.lblEfeiteReposta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteReposta3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteReposta3.Location = new System.Drawing.Point(153, 226);
			this.lblEfeiteReposta3.Name = "lblEfeiteReposta3";
			this.lblEfeiteReposta3.Size = new System.Drawing.Size(28, 28);
			this.lblEfeiteReposta3.TabIndex = 24;
			this.lblEfeiteReposta3.Text = "c)";
			this.lblEfeiteReposta3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEfeiteReposta4
			// 
			this.lblEfeiteReposta4.BackColor = System.Drawing.Color.Transparent;
			this.lblEfeiteReposta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteReposta4.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteReposta4.Location = new System.Drawing.Point(153, 265);
			this.lblEfeiteReposta4.Name = "lblEfeiteReposta4";
			this.lblEfeiteReposta4.Size = new System.Drawing.Size(28, 28);
			this.lblEfeiteReposta4.TabIndex = 23;
			this.lblEfeiteReposta4.Text = "d)";
			this.lblEfeiteReposta4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblEfeiteReposta1
			// 
			this.lblEfeiteReposta1.BackColor = System.Drawing.Color.Transparent;
			this.lblEfeiteReposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteReposta1.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteReposta1.Location = new System.Drawing.Point(153, 145);
			this.lblEfeiteReposta1.Name = "lblEfeiteReposta1";
			this.lblEfeiteReposta1.Size = new System.Drawing.Size(28, 28);
			this.lblEfeiteReposta1.TabIndex = 22;
			this.lblEfeiteReposta1.Text = "a)";
			this.lblEfeiteReposta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPergunta
			// 
			this.lblPergunta.BackColor = System.Drawing.Color.BurlyWood;
			this.lblPergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPergunta.Location = new System.Drawing.Point(187, 102);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(603, 28);
			this.lblPergunta.TabIndex = 21;
			this.lblPergunta.Text = "...";
			// 
			// lblNumPergunta
			// 
			this.lblNumPergunta.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.lblNumPergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNumPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumPergunta.Location = new System.Drawing.Point(153, 102);
			this.lblNumPergunta.Name = "lblNumPergunta";
			this.lblNumPergunta.Size = new System.Drawing.Size(28, 28);
			this.lblNumPergunta.TabIndex = 20;
			this.lblNumPergunta.Text = "...";
			// 
			// pcbQuestoes
			// 
			this.pcbQuestoes.Image = global::daniel_grazina_3935.Properties.Resources.books;
			this.pcbQuestoes.Location = new System.Drawing.Point(0, 102);
			this.pcbQuestoes.Name = "pcbQuestoes";
			this.pcbQuestoes.Size = new System.Drawing.Size(147, 238);
			this.pcbQuestoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbQuestoes.TabIndex = 19;
			this.pcbQuestoes.TabStop = false;
			// 
			// lblEfeiteQuestoes
			// 
			this.lblEfeiteQuestoes.AutoSize = true;
			this.lblEfeiteQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteQuestoes.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteQuestoes.Location = new System.Drawing.Point(7, 79);
			this.lblEfeiteQuestoes.Name = "lblEfeiteQuestoes";
			this.lblEfeiteQuestoes.Size = new System.Drawing.Size(101, 20);
			this.lblEfeiteQuestoes.TabIndex = 18;
			this.lblEfeiteQuestoes.Text = "Questões...";
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(193, 32);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(75, 23);
			this.btnIniciar.TabIndex = 17;
			this.btnIniciar.Text = "iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			// 
			// cbMaterias
			// 
			this.cbMaterias.FormattingEnabled = true;
			this.cbMaterias.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "Programação"});
			this.cbMaterias.Location = new System.Drawing.Point(6, 34);
			this.cbMaterias.Name = "cbMaterias";
			this.cbMaterias.Size = new System.Drawing.Size(181, 21);
			this.cbMaterias.TabIndex = 16;
			// 
			// lblEfeiteMatéria
			// 
			this.lblEfeiteMatéria.AutoSize = true;
			this.lblEfeiteMatéria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteMatéria.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteMatéria.Location = new System.Drawing.Point(7, 15);
			this.lblEfeiteMatéria.Name = "lblEfeiteMatéria";
			this.lblEfeiteMatéria.Size = new System.Drawing.Size(132, 16);
			this.lblEfeiteMatéria.TabIndex = 15;
			this.lblEfeiteMatéria.Text = "Escolha a Matéria";
			// 
			// lblEfeiteDivisoria3
			// 
			this.lblEfeiteDivisoria3.AutoSize = true;
			this.lblEfeiteDivisoria3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteDivisoria3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteDivisoria3.Location = new System.Drawing.Point(3, 54);
			this.lblEfeiteDivisoria3.Name = "lblEfeiteDivisoria3";
			this.lblEfeiteDivisoria3.Size = new System.Drawing.Size(861, 13);
			this.lblEfeiteDivisoria3.TabIndex = 15;
			this.lblEfeiteDivisoria3.Text = "_________________________________________________________________________________" +
    "_________________________________________";
			// 
			// lblEfeiteNavegacao
			// 
			this.lblEfeiteNavegacao.AutoSize = true;
			this.lblEfeiteNavegacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteNavegacao.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lblEfeiteNavegacao.Location = new System.Drawing.Point(632, 360);
			this.lblEfeiteNavegacao.Name = "lblEfeiteNavegacao";
			this.lblEfeiteNavegacao.Size = new System.Drawing.Size(158, 15);
			this.lblEfeiteNavegacao.TabIndex = 15;
			this.lblEfeiteNavegacao.Text = "Navegação entre perguntas";
			// 
			// lblEfeiteDivisoria4
			// 
			this.lblEfeiteDivisoria4.AutoSize = true;
			this.lblEfeiteDivisoria4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEfeiteDivisoria4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lblEfeiteDivisoria4.Location = new System.Drawing.Point(594, 364);
			this.lblEfeiteDivisoria4.Name = "lblEfeiteDivisoria4";
			this.lblEfeiteDivisoria4.Size = new System.Drawing.Size(196, 13);
			this.lblEfeiteDivisoria4.TabIndex = 34;
			this.lblEfeiteDivisoria4.Text = "___________________________";
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
			// pcbEfeiteEstudar
			// 
			this.pcbEfeiteEstudar.Image = global::daniel_grazina_3935.Properties.Resources._default;
			this.pcbEfeiteEstudar.Location = new System.Drawing.Point(0, -1);
			this.pcbEfeiteEstudar.Name = "pcbEfeiteEstudar";
			this.pcbEfeiteEstudar.Size = new System.Drawing.Size(240, 601);
			this.pcbEfeiteEstudar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbEfeiteEstudar.TabIndex = 0;
			this.pcbEfeiteEstudar.TabStop = false;
			// 
			// ApoioEstudo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 600);
			this.ControlBox = false;
			this.Controls.Add(this.tcApoioEstudo);
			this.Controls.Add(this.lblBemVindo);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.lblEfeiteApoioAoEstudo);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pcbEfeiteEstudar);
			this.Controls.Add(this.lblEfeiteDivisória1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ApoioEstudo";
			this.Text = "ApoioEstudo";
			this.Load += new System.EventHandler(this.ApoioEstudo_Load);
			this.tcApoioEstudo.ResumeLayout(false);
			this.tpQuestoes.ResumeLayout(false);
			this.tpQuestoes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbQuestoes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbEfeiteEstudar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbEfeiteEstudar;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblEfeiteApoioAoEstudo;
		private System.Windows.Forms.Label lblEfeiteDivisória1;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Label lblBemVindo;
		private System.Windows.Forms.TabControl tcApoioEstudo;
		private System.Windows.Forms.TabPage tpQuestoes;
		private System.Windows.Forms.TabPage tpResultados;
		private System.Windows.Forms.TabPage tpGestao;
		private System.Windows.Forms.Label lblEfeiteMatéria;
		private System.Windows.Forms.ComboBox cbMaterias;
		private System.Windows.Forms.Label lblEfeiteDivisoria3;
		private System.Windows.Forms.Label lblEfeiteQuestoes;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.PictureBox pcbQuestoes;
		private System.Windows.Forms.Label lblNumPergunta;
		private System.Windows.Forms.Label lblPergunta;
		private System.Windows.Forms.Label lblEfeiteReposta2;
		private System.Windows.Forms.Label lblEfeiteReposta3;
		private System.Windows.Forms.Label lblEfeiteReposta4;
		private System.Windows.Forms.Label lblEfeiteReposta1;
		private System.Windows.Forms.CheckBox cbD;
		private System.Windows.Forms.CheckBox cbC;
		private System.Windows.Forms.CheckBox cbB;
		private System.Windows.Forms.CheckBox cbA;
		private System.Windows.Forms.Label lblRespostaD;
		private System.Windows.Forms.Label lblRespostaC;
		private System.Windows.Forms.Label lblRespostaB;
		private System.Windows.Forms.Label lblRespostaA;
		private System.Windows.Forms.Button btnPerguntaAnterior;
		private System.Windows.Forms.Button btnProximaPergunta;
		private System.Windows.Forms.Label lblEfeiteNavegacao;
		private System.Windows.Forms.Label lblEfeiteDivisoria4;
	}
}