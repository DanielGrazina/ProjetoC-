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

		/*			
		#####################
		#                   #
		# Variaveis Globais #
		#                   #
		#####################
		*/

		//ID do utilizador para utilizar no histórico
		private int id;
		
		//Criar 10 objetos para as perguntas e respostas
		private Questoes[] p = new Questoes[10];

		//Número da pergunta
		private int indiceAtual;

		//Variavel para checkbox
		private CheckBox verificacaoCheckbox;

		//Contagem das respostas certas e erradas
		private int corretas = 0;
		private int erradas = 0;

		//Bool para resolver bug de ter de dar double clique nas checkboxs
		private bool doublecheck = false;

		//Bool para caso tenha finalizado a prova
		private bool finalizado = false;


		/*
		#################
		#               #
		# "Iniciar app" #  
		#               #
		#################
		 */
		public ApoioEstudo()
		{
			con = new MySqlConnection("Server=127.0.0.1;Database=projeto;Uid=root;Pwd=Qop2006a;");
			InitializeComponent();
		}

		//Ao carregar o form prepar algumas funcionalidades
		private void ApoioEstudo_Load(object sender, EventArgs e)
		{
				//abrir coneccao para a DB
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;
				
				//Query para pedir o nivel do utilizador
				cmd.CommandText = "Select lg_id, lg_nivel from tbl_login where lg_nome='" + nome + "' and lg_pass='" + pass + "';";
				dr = cmd.ExecuteReader();
				String nivel = "";
				while (dr.Read())
				{
					id = dr.GetInt32("lg_id");
					nivel = dr.GetString("lg_nivel");
				}
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

		/*
		######################
		#                    #
		# Questões de Estudo #
		#                    #
		######################
		*/

		//Função para dar uncheck as checkboxs
		private void UncheckAllCheckBoxesExcept_CheckedChanged(object sender, EventArgs e)
		{
			if (sender is CheckBox selectedCheckBox && !doublecheck)
			{
				verificacaoCheckbox = selectedCheckBox;
				doublecheck = true;

				// Obtém a TabPage que contém a CheckBox selecionada
				TabPage tabPage = selectedCheckBox.Parent as TabPage;

				if (tabPage != null)
				{
					//Procura as checkbox diferentes da selecionada
					foreach (CheckBox checkBox in tabPage.Controls.OfType<CheckBox>().Where(cb => cb != selectedCheckBox))
					{
						// Desmarca apenas se já estiver marcada
						if (checkBox.Checked)
						{
							checkBox.Checked = false;
						}
					}
				}
				doublecheck = false;
			}
		}

		//Função para receber perguntas e respostas
		private void getPerguntasRespostas(int[] idperguntas, String materia)
		{
			//loop para selecionar o número do objeto Questões
			for (int i = 0; i < 10; i++)
			{
				//Lista para guardar respostas
				List<string> respostas = new List<string>();
				
				//Query para busacar à DB as perguntas e respostas
				String buscarPerguntas = "Select pergunta from tbl_perguntas where id='"+ materia + idperguntas[i] + "'";
				String buscarRespotas = "Select resposta from tbl_respostas where id_pergunta='"+ materia + idperguntas[i] + "' order by rand()";
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
					string resposta = Convert.ToString(reader["resposta"]);
					// Adiciona cada resposta à lista
					respostas.Add(resposta);
				}

				//Adicionar pergunta e respostas à classe Questoes
				p[i] = new Questoes(materia+idperguntas[i], pergunta, respostas[0], respostas[1], respostas[2], respostas[3]);
				p[i].SetCheckbox(null);
				con.Close();
			}
		}


		//Função para exibir a pergunta e as opções de resposta no ecrã
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
				{
					p[indiceAtual].GetCheck().Checked = true;
					verificacaoCheckbox = p[indiceAtual].GetCheck();
				}
				else
				{
					if (verificacaoCheckbox != null) {
						verificacaoCheckbox.Checked = false;
						verificacaoCheckbox = null;
					}
				}
			}
		}

		//Função para verificar se a resposta está correta ou errada
		private void getVerificacaoResposta(String idpergunta, String resposta)
		{
			con.Open();
			String query = "Select correta from tbl_respostas where id_pergunta ='" + idpergunta + "' and resposta ='" + resposta + "'";
			cmd = new MySqlCommand();
			cmd.Connection = con;
			cmd.CommandText = query;
			Boolean verificacaoCorreta = (Boolean)cmd.ExecuteScalar();

			if (verificacaoCorreta)
			{
				corretas++;
			}
			else
			{
				erradas++;
			}
			con.Close();
		}


		//Botão para iniciar as perguntas de acordo com a disciplina
		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//Resetar variaveis
			finalizado = false;
			indiceAtual = 0;
			corretas = 0;
			erradas = 0;
			verificacaoCheckbox = null;
			lblPergunta.Text = null;
			lblRespostaA.Text = null;
			lblRespostaB.Text = null;
			lblRespostaC.Text = null;
			lblRespostaD.Text = null;
			cbA.Enabled = true;
			cbB.Enabled = true;
			cbC.Enabled = true;
			cbD.Enabled = true;
			lblCorretas.Location = new Point(6, 116);
			lblErradas.Location = new Point(6, 223);
			

			//Recolher IDs aleatorios para perguntas
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

		//botão para avançar de pergunta e finalizar a prova
		private void btnProximaPergunta_Click(object sender, EventArgs e)
		{
			if (indiceAtual + 1 > 9)
			{
				if (finalizado)
				{
					MessageBox.Show("Ultimo Registo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					DialogResult simnao = MessageBox.Show("Fim das perguntas!\nQuer finalizar?", "Final", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (simnao == DialogResult.Yes)
					{
						/*
						##############
						#            #
						# Resultados #
						#            #
						##############
						*/

						//Marcar como finalizado
						finalizado = true;

						//Desativar checkboxs para não modificar respostas depois de acabar a prova
						cbA.Enabled = false;
						cbB.Enabled = false;
						cbC.Enabled = false;
						cbD.Enabled = false;
						//Verificar respostas
						for (int i = 0; i < 10; i++)
						{
							CheckBox ondePergunta = p[i].GetCheck();
							if (ondePergunta != null)
							{
								switch (ondePergunta.Name)
								{
									case "cbA":
										getVerificacaoResposta(p[i].getId(), p[i].GetRespostaA());
										break;
									case "cbB":
										getVerificacaoResposta(p[i].getId(), p[i].GetRespostaB());
										break;
									case "cbC":
										getVerificacaoResposta(p[i].getId(), p[i].GetRespostaC());
										break;
									case "cbD":
										getVerificacaoResposta(p[i].getId(), p[i].GetRespostaD());
										break;
								}
							}
						}

						//Modificar grafico dos resultados
						int stepSize = 250 / 10;
						txtCorretas.Size = new Size(stepSize * corretas, 34);
						txtErradas.Size = new Size(stepSize * erradas, 34);
						lblCorretas.Location = new Point(lblCorretas.Location.X + (stepSize * corretas + 5), lblCorretas.Location.Y);
						lblErradas.Location = new Point(lblErradas.Location.X + (stepSize * erradas + 5), lblErradas.Location.Y);
						lblCorretas.Text = corretas.ToString();
						lblErradas.Text = erradas.ToString();

						//Query para inserir informações no histórico e query para mostrar historico
						String inserir = "Insert Into tbl_historico values (" + id + ", '" + nome + "', '" + cbMaterias.Text + "', " + corretas + ", " + erradas + ", '" + lblData.Text + "')";
						String mostrar = "Select * from tbl_historico where id=" + id;
						con.Open();
						cmd = new MySqlCommand();
						cmd.Connection = con;
						cmd.CommandText = inserir;
						cmd.ExecuteReader();
						con.Close();

						con.Open();
						cmd2 = new MySqlCommand();
						cmd2.Connection = con;
						cmd2.CommandText = mostrar;

						MySqlDataAdapter da = new MySqlDataAdapter();
						da.SelectCommand = cmd2;

						DataTable dt = new DataTable();
						da.Fill(dt);
						gdViewHistórico.DataSource = dt;

						da.Dispose();
						con.Close();

						//mostrar tab Resultados no final das perguntas
						tcApoioEstudo.SelectTab(tpResultados);
					}
				}
			}
			else
			{
				//Guardar respost
				p[indiceAtual].SetCheckbox(verificacaoCheckbox);

				//Avançar página
				indiceAtual++;
				ExibirPergunta();
			}
		}

		 //botão para voltar a trás nas perguntas
		private void btnPerguntaAnterior_Click(object sender, EventArgs e)
		{
			if (indiceAtual-1 < 0)
			{
				MessageBox.Show("Primeiro Registo!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				//Guardar respost
				p[indiceAtual].SetCheckbox(verificacaoCheckbox);

				indiceAtual--;
				ExibirPergunta();
			}
		}

		/*
			#######################
		    #                     #
			# Gestão Utilizadores #
			#                     #
			#######################
		*/

		//Ver lista de utilizadores (Tabela login)
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

		//Criar novo utilizador
		private void btnInserirUser_Click(object sender, EventArgs e)
		{
			//Verificação se todos os dados estão preenchidos
			if (txtUserName.Text == "" || txtPassword.Text == "" || cbNivel.Text == "")
			{
				MessageBox.Show("Erro!!\n Falta de informação para criar novo user!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				con.Open();
				cmd = new MySqlCommand();
				cmd.Connection = con;
				String inserir = "INSERT INTO tbl_login (lg_nome, lg_pass, lg_nivel) values ('" + txtUserName.Text + "', '" + txtPassword.Text + "','" + cbNivel.Text + "')";
				cmd.CommandText = inserir;
				dr = cmd.ExecuteReader();
				con.Close();
				MessageBox.Show("Utilizador criado com sucesso!!", "Novo utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		//Atualizar dados de um utilizador
		private void btnAtualizarUser_Click(object sender, EventArgs e)
		{
			//Verificar ID
			con.Open();
			cmd.Connection = con;
			cmd.CommandText = "Select lg_nome from tbl_login where lg_id='" + txtId.Text + "'";
			String VerificacaoUser = (String)cmd.ExecuteScalar();

			//Verificar se o ID foi preenchido ou se o utilizador existe
			if (txtId.Text == "" || VerificacaoUser == null)
			{
				MessageBox.Show("Erro!!\nId inválido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//Verificacar se todos os dados estão preenchidos
				if (txtUserName.Text == "" || txtPassword.Text == "" || cbNivel.Text == "")
				{
					MessageBox.Show("Erro!!\n Falta de informação para editar user!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					cmd2 = new MySqlCommand();
					cmd2.Connection = con;
					cmd2.CommandText = "update tbl_login set lg_nome = '" + txtUserName.Text + "', lg_pass = '" + txtPassword.Text + "', lg_nivel='" + cbNivel.Text + "' where lg_id = '" + txtId.Text + "'";
					dr = cmd2.ExecuteReader();
					MessageBox.Show("User Alterado com sucesso!!", "Atualiza User", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			con.Close();
		}

		//Eliminar utilizador
		private void btnEliminarUser_Click(object sender, EventArgs e)
		{

			//Verificar ID
			con.Open();
			cmd.Connection = con;
			cmd.CommandText = "Select lg_nome from tbl_login where lg_id='" + txtId.Text + "'";
			String VerificacaoUser = (String)cmd.ExecuteScalar();

			//Verificar se o ID foi preenchido ou se o utilizador existe
			if (txtId.Text == "" || VerificacaoUser == null)
			{
				MessageBox.Show("Erro!!\nId inválido!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				//Confirmação para eliminar utilizador
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

		//Sair da aplicação
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}