using System;
using System.Windows.Forms;

namespace sys_IATI
{
    public partial class Tela_de_Carregar : Form
    {
        private bool homeAberto = false; 
        public Tela_de_Carregar()
        {
            InitializeComponent();
        }

        // Evento Load do formulário
        private void Tela_de_Carregar_Load(object sender, EventArgs e)
        {
            // Configura o Timer para 100 milissegundos (atualiza a barra de progresso a cada 100ms)
            timer.Interval = 100; 
            timer.Tick += timer_Tick; 
            timer.Start(); // Inicia o Timer

            // Inicializa a barra de progresso
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
        }

        
        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (circularProgressBar1.Value < circularProgressBar1.Maximum)
            {
                circularProgressBar1.Value += 1;
            }
            else
            {
               timer.Stop();

                if (!homeAberto) // Verifica se o formulário Home já foi aberto
                {
                    homeAberto = true; // Marca como aberto
                    Login_IATI login = new Login_IATI();
                    login.Show(); // Abre o formulário Home
                    this.Hide(); // Oculta a tela de carregamento
                }
            }
        }
            
        

        // Evento de clique na barra de progresso (opcional)
        private void circularProgressBar1_Click(object sender, EventArgs e)
        {
            // Lógica opcional para o clique na barra de progresso
        }
    }
}