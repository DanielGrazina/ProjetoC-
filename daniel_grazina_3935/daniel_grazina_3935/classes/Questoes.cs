using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daniel_grazina_3935.classes
{
	public class Questoes
	{
		private String id;
		private String pergunta;
		private String respostaA;
		private String respostaB;
		private String respostaC;
		private String respostaD;
		private CheckBox CheckChecked;

		public Questoes(String id, String pergunta, String respostaA, String respostaB, String respostaC, String respostaD)
		{
			this.id = id;
			this.pergunta = pergunta;
			this.respostaA = respostaA;
			this.respostaB = respostaB;
			this.respostaC = respostaC;
			this.respostaD = respostaD;
		}

		public String getId() { return id; }
		public String GetPergunta() {  return pergunta; }
		public String GetRespostaA() {  return respostaA; }
		public String GetRespostaB() { return respostaB; }
		public String GetRespostaC() {  return respostaC; }
		public String GetRespostaD() { return respostaD; }
		public CheckBox GetCheck() { return CheckChecked; }
		public void SetCheckbox(CheckBox checkBox) { this.CheckChecked = checkBox; }


	}
}
