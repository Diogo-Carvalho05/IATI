namespace sys_IATI
{
    partial class Menu_IATI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_IATI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenuUser = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblIati = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.selecaoTxtServico = new System.Windows.Forms.ComboBox();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.btchamado = new System.Windows.Forms.Button();
            this.btDeSair = new System.Windows.Forms.PictureBox();
            this.gerarSugestao = new System.Windows.Forms.Button();
            this.txtGeraResposta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenuUser
            // 
            this.lblMenuUser.AutoSize = true;
            this.lblMenuUser.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuUser.Location = new System.Drawing.Point(254, 9);
            this.lblMenuUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuUser.Name = "lblMenuUser";
            this.lblMenuUser.Size = new System.Drawing.Size(190, 43);
            this.lblMenuUser.TabIndex = 8;
            this.lblMenuUser.Text = "USUARIO";
            this.lblMenuUser.Click += new System.EventHandler(this.lblMenuUser_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(84, 190);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 18);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(88, 211);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitulo.Size = new System.Drawing.Size(331, 21);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(84, 142);
            this.lblServico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(66, 18);
            this.lblServico.TabIndex = 7;
            this.lblServico.Text = "Serviço";
            this.lblServico.Click += new System.EventHandler(this.lblServico_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(84, 234);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(86, 18);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblIati
            // 
            this.lblIati.AutoSize = true;
            this.lblIati.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIati.Location = new System.Drawing.Point(201, 88);
            this.lblIati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIati.Name = "lblIati";
            this.lblIati.Size = new System.Drawing.Size(88, 43);
            this.lblIati.TabIndex = 0;
            this.lblIati.Text = "IATI";
            this.lblIati.Click += new System.EventHandler(this.lblIati_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 255);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.Size = new System.Drawing.Size(331, 21);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // selecaoTxtServico
            // 
            this.selecaoTxtServico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selecaoTxtServico.BackColor = System.Drawing.SystemColors.Menu;
            this.selecaoTxtServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selecaoTxtServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selecaoTxtServico.ForeColor = System.Drawing.Color.Black;
            this.selecaoTxtServico.FormattingEnabled = true;
            this.selecaoTxtServico.Location = new System.Drawing.Point(88, 166);
            this.selecaoTxtServico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selecaoTxtServico.Name = "selecaoTxtServico";
            this.selecaoTxtServico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selecaoTxtServico.Size = new System.Drawing.Size(331, 21);
            this.selecaoTxtServico.TabIndex = 10;
            this.selecaoTxtServico.SelectedIndexChanged += new System.EventHandler(this.selecaoTxtServico_SelectedIndexChanged);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(84, 294);
            this.lblAjuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(61, 18);
            this.lblAjuda.TabIndex = 10;
            this.lblAjuda.Text = "AJUDA";
            // 
            // btchamado
            // 
            this.btchamado.BackColor = System.Drawing.Color.Green;
            this.btchamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btchamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btchamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchamado.Location = new System.Drawing.Point(179, 423);
            this.btchamado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btchamado.Name = "btchamado";
            this.btchamado.Size = new System.Drawing.Size(130, 23);
            this.btchamado.TabIndex = 11;
            this.btchamado.Text = "Iniciar Chamado ";
            this.btchamado.UseVisualStyleBackColor = false;
            this.btchamado.Click += new System.EventHandler(this.btchamado_Click);
            // 
            // btDeSair
            // 
            this.btDeSair.Image = global::sys_IATI.Properties.Resources.download_removebg_preview;
            this.btDeSair.Location = new System.Drawing.Point(463, 0);
            this.btDeSair.Name = "btDeSair";
            this.btDeSair.Size = new System.Drawing.Size(61, 37);
            this.btDeSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btDeSair.TabIndex = 16;
            this.btDeSair.TabStop = false;
            this.btDeSair.Click += new System.EventHandler(this.btDeSair_Click);
            // 
            // gerarSugestao
            // 
            this.gerarSugestao.Location = new System.Drawing.Point(375, 289);
            this.gerarSugestao.Name = "gerarSugestao";
            this.gerarSugestao.Size = new System.Drawing.Size(137, 23);
            this.gerarSugestao.TabIndex = 17;
            this.gerarSugestao.Text = "GERA SUGESTÃO";
            this.gerarSugestao.UseVisualStyleBackColor = true;
            this.gerarSugestao.Click += new System.EventHandler(this.gerarSugestao_Click);
            // 
            // txtGeraResposta
            // 
            this.txtGeraResposta.Location = new System.Drawing.Point(88, 318);
            this.txtGeraResposta.Multiline = true;
            this.txtGeraResposta.Name = "txtGeraResposta";
            this.txtGeraResposta.Size = new System.Drawing.Size(331, 69);
            this.txtGeraResposta.TabIndex = 18;
            // 
            // Menu_IATI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(524, 458);
            this.Controls.Add(this.txtGeraResposta);
            this.Controls.Add(this.gerarSugestao);
            this.Controls.Add(this.btDeSair);
            this.Controls.Add(this.btchamado);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.selecaoTxtServico);
            this.Controls.Add(this.lblIati);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblServico);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMenuUser);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu_IATI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_IATI";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenuUser;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblIati;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox selecaoTxtServico;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Button btchamado;
        private System.Windows.Forms.PictureBox btDeSair;
        private System.Windows.Forms.Button gerarSugestao;
        private System.Windows.Forms.TextBox txtGeraResposta;
    }
}