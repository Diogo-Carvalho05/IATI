using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sys_IATI
{
    public partial class Menu_IATI: Form
    {

        private conexaoIA conexao;
        private string sugestaoSelecionada;

        public Menu_IATI(string nomeUsuario)
        {
            InitializeComponent();

            lblMenuUser.Text = nomeUsuario;
            AdicionarTiposDeServico();

            conexao = new conexaoIA("XYsLAIEOYCkjZVprKTizRNiqPQhloKh2ZclJaNii");

           
        }

        private void AdicionarTiposDeServico()
        {
            // Limpa a ComboBox caso já tenha itens
            selecaoTxtServico.Items.Clear();

            // Adiciona os tipos de serviço
            selecaoTxtServico.Items.Add("Suporte Técnico");
            selecaoTxtServico.Items.Add("Problemas de Rede");
            selecaoTxtServico.Items.Add("Problemas de Software");
            selecaoTxtServico.Items.Add("Problemas de Hardware");
            selecaoTxtServico.Items.Add("Outros");

           
            selecaoTxtServico.SelectedIndex = 0;

        }

      

        //label nome do usuario 
        private void lblMenuUser_Click(object sender, EventArgs e)
        {
           

        }
        //label sreviço
        private void lblServico_Click(object sender, EventArgs e)
        {

        }
        //Caixa de selecionar o motivo do chamado 
        private void selecaoTxtServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       
        //caixa de texto decriçao
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        //caixa de texto titulo 
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        //botao de iniciar o chamado 
        private async void btchamado_Click(object sender, EventArgs e)
        {
           

            try
            {
                // Gera o passo a passo com base na sugestão selecionada
                string passoAPasso = await conexao.GetAIResponse($"Passo a passo para: {sugestaoSelecionada}");

                // Abre a nova tela com o passo a passo
                IApassoApasso instrucoesForm = new IApassoApasso(passoAPasso);
                instrucoesForm.Show(); // Exibe a nova tela
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter passo a passo: {ex.Message}");
            }
        }


        //botao de gerar sugestao
        private async void gerarSugestao_Click(object sender, EventArgs e)
        {
            // Verifica se a descrição foi preenchida
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, insira uma descrição para o problema.");
                return;
            }

            // Obtém o tipo de serviço selecionado
            string tipoServico = selecaoTxtServico.SelectedItem.ToString();

            // Cria a mensagem para a IA
            string mensagemParaIA = $"Tipo de serviço: {tipoServico}. Descrição: {txtDescricao.Text}";

            try
            {
                // Chama a API da Cohere para gerar um passo a passo
                string passoAPasso = await conexao.GetAIResponse(mensagemParaIA, true);

                // Exibe o passo a passo na caixa de texto
                txtGeraResposta.Text = passoAPasso;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter passo a passo: {ex.Message}");
            }
        }


        //botao de sair 
        private void btDeSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblIati_Click(object sender, EventArgs e)
        {

        }

       
        

        private void txtGeraResposta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
