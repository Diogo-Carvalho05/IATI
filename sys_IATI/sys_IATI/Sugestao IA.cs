using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_IATI
{
    public partial class Sugestao_IA: Form
    {
        public Sugestao_IA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja finalizar o sistema?", "Finalizar Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar, fecha o aplicativo
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
