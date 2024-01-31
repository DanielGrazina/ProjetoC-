using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using daniel_grazina_3935.classes;
using daniel_grazina_3935.Properties;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace daniel_grazina_3935
{
	public partial class ApoioEstudo : Form
	{
		MySqlConnection con;
		MySqlCommand cmd;
		MySqlCommand cmd2;
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

		private void btnVerLista_Click(object sender, EventArgs e)
		{
			con.Open();
			cmd = new MySqlCommand();
			cmd.Connection = con;

			String query = "Select * from tbl_login";
			cmd.CommandText = query;

			MySqlDataAdapter da = new MySqlDataAdapter();
			da.SelectCommand = cmd;

			DataTable dt = new DataTable();	
			da.Fill(dt);
			gridView.DataSource = dt;

			da.Dispose();
			con.Close();
		}

		private void btnInserirUser_Click(object sender, EventArgs e)
		{
			if(txtUserName.Text == "" || txtPassword.Text == "" || cbNivel.Text == "")
			{
				MessageBox.Show("Erro!!\n Falta de informação para criar novo user!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;
				String inserir = "INSERT INTO tbl_login (lg_nome, lg_pass, lg_nivel) values ('"+txtUserName.Text+"', '"+txtPassword.Text+"','"+cbNivel.Text+"')";
				cmd.CommandText = inserir;
				dr = cmd.ExecuteReader();
				con.Close();
				MessageBox.Show("Utilizador criado com sucesso!!", "Novo utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAtualizarUser_Click(object sender, EventArgs e)
		{
			con.Open();

			cmd.Connection = con;
			cmd.CommandText = "Select lg_nome from tbl_login where lg_id='" + txtId.Text + "'";
			String VerificacaoUser = (String)cmd.ExecuteScalar();


			if (txtId.Text == "" || VerificacaoUser == null)
			{
				MessageBox.Show("Erro!!\nId inválido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (txtUserName.Text == "" || txtPassword.Text == "" || cbNivel.Text == "")
				{
					MessageBox.Show("Erro!!\n Falta de informação para editar user!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					cmd2 = new MySqlCommand();
					cmd2.Connection = con;
					cmd2.CommandText = "update tbl_login set lg_nome = '" + txtUserName.Text + "', lg_pass = '" + txtPassword.Text + "', lg_nivel='"+cbNivel.Text+"' where lg_id = '" + txtId.Text + "'";
					dr = cmd2.ExecuteReader();
					MessageBox.Show("User Alterado com sucesso!!", "Atualiza User", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			con.Close();
		}

		private void btnEliminarUser_Click(object sender, EventArgs e)
		{
			con.Open();

			cmd.Connection = con;
			cmd.CommandText = "Select lg_nome from tbl_login where lg_id='" + txtId.Text + "'";
			String VerificacaoUser = (String)cmd.ExecuteScalar();

			if (txtId.Text == "" || VerificacaoUser == null)
			{
				MessageBox.Show("Erro!!\nId inválido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				DialogResult simnao = MessageBox.Show("Tem a certeza que quer eliminar o user??", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (simnao == DialogResult.Yes)
				{
					cmd2 = new MySqlCommand();
					cmd2.Connection = con;
					cmd2.CommandText = "delete from tbl_login where lg_id = '" + txtId.Text + "'";
					dr = cmd2.ExecuteReader();
					MessageBox.Show("User Eliminado!!", "Eliminar User", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			con.Close();
		}


		Questoes[] p = new Questoes[10];
		int indiceAtual;
		CheckBox temp;

		//Bool para resolver bug de ter de dar double clique nas checkboxs
		private bool doublecheck = false;
		private void UncheckAllCheckBoxesExcept_CheckedChanged(object sender, EventArgs e)
		{
			
			if (sender is CheckBox selectedCheckBox && !doublecheck)
			{
				p[indiceAtual].SetCheckbox(selectedCheckBox);
				temp = selectedCheckBox;
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

		private void getPerguntasRespostas(int[] idperguntas, String materia)
		{
			for (int i = 0; i < 10; i++)
			{
				List<string> respostas = new List<string>();
				String buscarPerguntas = "Select pergunta from tbl_perguntas where id='"+ materia + idperguntas[i] + "'";
				String buscarRespotas = "Select resposta from tbl_respostas where id_pergunta='"+ materia + idperguntas[i] + "'";
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;
				cmd.CommandText = buscarPerguntas;
				String pergunta = (String)cmd.ExecuteScalar();

				cmd2 = new MySqlCommand();
				cmd2.Connection = con;
				cmd2.CommandText = buscarRespotas;
				MySqlDataReader reader = cmd2.ExecuteReader();
				while (reader.Read())
				{
					// Supondo que a coluna se chama 'resposta'
					string resposta = Convert.ToString(reader["resposta"]);

					// Adiciona cada resposta à lista
					respostas.Add(resposta);
				}

				p[i] = new Questoes(pergunta, respostas[0], respostas[1], respostas[2], respostas[3]);
				con.Close();
			}
		}

		private void ExibirPergunta()
		{
			if (indiceAtual >= 0 && indiceAtual < 10)
			{
				lblNumPergunta.Text = (indiceAtual + 1).ToString();
				lblPergunta.Text = p[indiceAtual].GetPergunta();
				lblRespostaA.Text = p[indiceAtual].GetRespostaA();
				lblRespostaB.Text = p[indiceAtual].GetRespostaB();
				lblRespostaC.Text = p[indiceAtual].GetRespostaC();
				lblRespostaD.Text = p[indiceAtual].GetRespostaD();
				if (p[indiceAtual].GetCheck() != null)
					p[indiceAtual].GetCheck().Checked = true;
				else
					if(temp != null)
						temp.Checked = false;
			}
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			indiceAtual = 0;
			temp = null;
			Random rnd = new Random();
			int[] idperguntas = new int[10];
			for(int i = 0; i<10; i++)
			{
				bool repetido = true;
				do
				{
					int temp = rnd.Next(1, 20);
					if(idperguntas.Contains(temp)){
						repetido = true;
					}
					else
					{
						idperguntas[i] = temp;
						repetido=false;
					}
				} while (repetido);
			}

			switch (cbMaterias.Text)
			{
				case "Português":
					getPerguntasRespostas(idperguntas, "portugues");
					pcbQuestoes.Image = Resources.portugues;
					ExibirPergunta();
					break;
				case "Matemática":
					getPerguntasRespostas(idperguntas, "matematica");
					pcbQuestoes.Image = Resources.matematica;
					ExibirPergunta();
					break;
				case "Programação":
					getPerguntasRespostas(idperguntas, "programacao");
					pcbQuestoes.Image = Resources.programacao;
					ExibirPergunta();
					break;
				default:
					MessageBox.Show("Erro!!\nDisciplina Invalida","ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}

		}

		private void btnProximaPergunta_Click(object sender, EventArgs e)
		{
			indiceAtual++;
			ExibirPergunta();
		}

		private void btnPerguntaAnterior_Click(object sender, EventArgs e)
		{
			if (indiceAtual-- < 0)
			{
				MessageBox.Show("Primeiro Registo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				indiceAtual--;
				ExibirPergunta();
			}
		}
	}
}
