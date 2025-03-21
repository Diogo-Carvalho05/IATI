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
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //botao de cadastro da empressa
        private void btCadastroEmpresa_Click(object sender, EventArgs e)
        {

        }
       
        //botao de cadastro do usuario
        private void btCadastroUsuario_Click(object sender, EventArgs e)
        {

        }

        //botao de cadastro do admFunconario
        private void btCadastroAdm_Click(object sender, EventArgs e)
        {
            cadastroAdm  cadAdm = new cadastroAdm();
            cadAdm.Show();
            this.Hide(); // Oculta a tela de login


        }


        //onde vai ser feito a visualizaçao do dos chamados aberto  
        private void listaDeVisualizarChamado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            // Se o usuário confirmar, fecha a aplicação
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Fecha a aplicação
            }
        }
    }
}
