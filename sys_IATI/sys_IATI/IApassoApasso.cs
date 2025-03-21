using System;
using System.Windows.Forms;

namespace sys_IATI
{
    public partial class IApassoApasso : Form
    {
        // Construtor que recebe as instruções da IA
        public IApassoApasso(string instrucoes)
        {
            InitializeComponent();
            ExibirInstrucoes(instrucoes);
        }

        // Método para exibir as instruções na tela
        private void ExibirInstrucoes(string instrucoes)
        {
            // Cria um RichTextBox para exibir as instruções
            RichTextBox rtbInstrucoes = new RichTextBox();
            rtbInstrucoes.Dock = DockStyle.Fill; // Preenche toda a área do formulário
            rtbInstrucoes.ReadOnly = true; // Impede a edição do texto
            rtbInstrucoes.Text = instrucoes; // Define o texto com as instruções

            // Adiciona o RichTextBox ao formulário
            this.Controls.Add(rtbInstrucoes);
        }
    }
}