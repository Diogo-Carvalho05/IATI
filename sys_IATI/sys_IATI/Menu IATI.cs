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


        public Menu_IATI()
        {
            InitializeComponent();
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
        private void btchamado_Click(object sender, EventArgs e)
        {           

        }
        
        //abaixo esta os 3 botões que mostra as sugestões da IA
        private void btSugestao1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btSugestao2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSugestao3_CheckedChanged(object sender, EventArgs e)
        {

        }

        //botao de sair 
        private void btDeSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
