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
    public partial class Login_IATI: Form
    {
        public Login_IATI()
        {
            InitializeComponent();
        }
        
        //botao de acesso 
        private void btAcesso_Click(object sender, EventArgs e)
        {
            string user = "a";
            string senha = "a";

            if(txtPasseword.Text == senha & txtUsuario.Text == user)
            {
                Menu_IATI menu = new Menu_IATI();
                menu.Show();
                this.Hide();
            }


        }
           
          //caixa de texto senha
        private void txtPasseword_TextChanged(object sender, EventArgs e)
        {
            txtPasseword.PasswordChar = '*';

        }

        //caixa de texto usuario
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
