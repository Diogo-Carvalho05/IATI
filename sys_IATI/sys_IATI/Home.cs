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


        //onde vai ser feito a manipulaçao de chamados  
        private void controleDaCelulaDeChamado(object sender, DataGridViewCellEventArgs e)
        {

        }

        //lista de chamados
        private void listaDeChamado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Home_Load(object sender, EventArgs e)
        {

        }

        //botao de sair 
        private void btSair_Click(object sender, EventArgs e)
        {
                Application.Exit(); // Fecha a aplicação
            
        }
    }
}
