using Npgsql;
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

        private void btAcesso_Click(object sender, EventArgs e)
        {

            string nome = txtUsuario.Text;
            string senha = txtPasseword.Text;

            // Validação básica
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verificar as credenciais no banco de dados
            using (var db = new dbConnection())
            {
                try
                {
                    // Verifica se é um funcionário
                    if (VerificarCredenciais(db, "funcionario", nome, senha))
                    {
                        MessageBox.Show("Login de funcionário realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Home home = new Home();
                        home.Show();
                        this.Hide(); // Oculta a tela de login
                    }
                    // Verifica se é um usuário
                    else if (VerificarCredenciais(db, "usuario", nome, senha))
                    {
                        MessageBox.Show("Login de usuário realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      Menu_IATI menu = new Menu_IATI(); 
                        menu.Show();
                        this.Hide(); // Oculta a tela de login
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar fazer login: " + ex.Message);
                }
            }

        }

        private bool VerificarCredenciais(dbConnection db, string tabela, string nome, string senha)
        {
            // Consulta SQL para verificar o usuário e senha
            var query = $"SELECT COUNT(*) FROM {tabela} WHERE nome = @nome AND senha = @senha";
            using (var cmd = new NpgsqlCommand(query, db.Connection))
            {
                // Passando os parâmetros corretamente
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0; // Retorna true se encontrar um registro
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
        private void btAcesso_Click_1(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {  
                Application.Exit(); // Fecha a aplicação
        }
    }
}
