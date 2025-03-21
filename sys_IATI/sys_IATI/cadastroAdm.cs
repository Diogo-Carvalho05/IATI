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
    public partial class cadastroAdm : Form
    {
        public cadastroAdm()
        {
            InitializeComponent();
        }


        //caixa de texto nome
        private void txtNomeAdm_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto email
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto telefone
        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto cargo
        private void txtCargo_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto setor
        private void txtSetor_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto salario mensal
        private void txtSalarioMensal_TextChanged(object sender, EventArgs e)
        {

        }

        //botao ativo
        private void btStatosAtivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        //botao desativo
        private void btStatosInativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto senha
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        //botao de salvar
        private void btSalvarAdm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Por favor, insira o CPF.");
                return;
            }

            // Validação do CPF
            if (!IsValidCpf(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            try
            {
                // Cria uma instância da conexão com o banco de dados
                using (dbConnection dbConnection = new dbConnection())
                {
                    // Query SQL para inserir os dados na tabela Funcionario
                    string query = @"
                INSERT INTO Funcionario 
                (nome, cpf, data_nascimento, email, telefone, endereco, cargo, setor, data_admissao, salario_mensal, statos, senha) 
                VALUES 
                (@nome, @cpf, @data_nascimento, @email, @telefone, @endereco, @cargo, @setor, @data_admissao, @salario_mensal, @statos, @senha)";

                    // Cria um comando SQL usando a conexão aberta
                    using (NpgsqlCommand command = new NpgsqlCommand(query, dbConnection.Connection))
                    {
                        // Adiciona os parâmetros com os valores dos campos do formulário
                        command.Parameters.AddWithValue("@nome", txtNomeAdm.Text);
                        command.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        command.Parameters.AddWithValue("@data_nascimento", DateTime.Parse(txtDataNascimento.Text));
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@cargo", txtCargo.Text);
                        command.Parameters.AddWithValue("@setor", txtSetor.Text);
                        command.Parameters.AddWithValue("@data_admissao", DateTime.Parse(txtDataAdmissao.Text));
                        command.Parameters.AddWithValue("@salario_mensal", decimal.Parse(txtSalarioMensal.Text));
                        command.Parameters.AddWithValue("@statos", btStatosAtivo.Checked ? "ativo" : "inativo");
                        command.Parameters.AddWithValue("@senha", txtSenha.Text);

                        // Executa o comando SQL
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar funcionário: " + ex.Message);
            }




        }

        //caixa de texto data de nascimento
        private void txtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //caixa de texto telefone
        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //caixa de texto data admissão
        private void txtDataAdmissao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //acabei clickando sem querer porem é atela de fundo 
        private void cadastroAdm_Load(object sender, EventArgs e)
        {


        }

        //caixa de texto cpf
        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        //Botão de voltar
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();    

        }

        //abaixo esta algumas validações



        // Função para validar CPF
        static bool IsValidCpf(string cpf)
        {
            // Remove caracteres que não são dígitos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos são iguais (ex: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Validação dos dígitos verificadores
            int firstDigit = CalculateCpfDigit(cpf.Substring(0, 9), 10);
            int secondDigit = CalculateCpfDigit(cpf.Substring(0, 9) + firstDigit, 11);

            return cpf[9] == (char)(firstDigit + '0') && cpf[10] == (char)(secondDigit + '0');
        }

        // Função para calcular o dígito verificador do CPF
        static int CalculateCpfDigit(string str, int weight)
        {
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                sum += (str[i] - '0') * weight--;
            }

            int remainder = (sum * 10) % 11;
            return remainder == 10 ? 0 : remainder;
        }

        private void logoCadastroAdm_Click(object sender, EventArgs e)
        {
             
        }

        private void btDeSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário confirmar, fecha a aplicação
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Fecha a aplicação
            }
        }
    }
}
