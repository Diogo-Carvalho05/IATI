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
            this.btSugestao1 = new System.Windows.Forms.RadioButton();
            this.btSugestao2 = new System.Windows.Forms.RadioButton();
            this.btSugestao3 = new System.Windows.Forms.RadioButton();
            this.btchamado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenuUser
            // 
            this.lblMenuUser.AutoSize = true;
            this.lblMenuUser.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuUser.Location = new System.Drawing.Point(233, -2);
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
            this.lblTitulo.Location = new System.Drawing.Point(98, 196);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 18);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(101, 217);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(284, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServico.Location = new System.Drawing.Point(98, 148);
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
            this.lblDescricao.Location = new System.Drawing.Point(98, 240);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(86, 18);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblIati
            // 
            this.lblIati.AutoSize = true;
            this.lblIati.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIati.Location = new System.Drawing.Point(197, 88);
            this.lblIati.Name = "lblIati";
            this.lblIati.Size = new System.Drawing.Size(88, 43);
            this.lblIati.TabIndex = 7;
            this.lblIati.Text = "IATI";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(101, 261);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(284, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // selecaoTxtServico
            // 
            this.selecaoTxtServico.BackColor = System.Drawing.SystemColors.Window;
            this.selecaoTxtServico.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.selecaoTxtServico.FormattingEnabled = true;
            this.selecaoTxtServico.Location = new System.Drawing.Point(101, 172);
            this.selecaoTxtServico.Name = "selecaoTxtServico";
            this.selecaoTxtServico.Size = new System.Drawing.Size(284, 21);
            this.selecaoTxtServico.TabIndex = 0;
            this.selecaoTxtServico.Text = " -Escolha um serviço";
            this.selecaoTxtServico.SelectedIndexChanged += new System.EventHandler(this.selecaoTxtServico_SelectedIndexChanged);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.Location = new System.Drawing.Point(98, 300);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(61, 18);
            this.lblAjuda.TabIndex = 10;
            this.lblAjuda.Text = "AJUDA";
            // 
            // btSugestao1
            // 
            this.btSugestao1.AutoSize = true;
            this.btSugestao1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSugestao1.Location = new System.Drawing.Point(115, 330);
            this.btSugestao1.Name = "btSugestao1";
            this.btSugestao1.Size = new System.Drawing.Size(14, 13);
            this.btSugestao1.TabIndex = 3;
            this.btSugestao1.TabStop = true;
            this.btSugestao1.UseVisualStyleBackColor = true;
            this.btSugestao1.CheckedChanged += new System.EventHandler(this.btSugestao1_CheckedChanged);
            // 
            // btSugestao2
            // 
            this.btSugestao2.AutoSize = true;
            this.btSugestao2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSugestao2.Location = new System.Drawing.Point(115, 353);
            this.btSugestao2.Name = "btSugestao2";
            this.btSugestao2.Size = new System.Drawing.Size(104, 20);
            this.btSugestao2.TabIndex = 4;
            this.btSugestao2.TabStop = true;
            this.btSugestao2.Text = "sugestão IA";
            this.btSugestao2.UseVisualStyleBackColor = true;
            this.btSugestao2.CheckedChanged += new System.EventHandler(this.btSugestao2_CheckedChanged);
            // 
            // btSugestao3
            // 
            this.btSugestao3.AutoSize = true;
            this.btSugestao3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSugestao3.Location = new System.Drawing.Point(115, 376);
            this.btSugestao3.Name = "btSugestao3";
            this.btSugestao3.Size = new System.Drawing.Size(104, 20);
            this.btSugestao3.TabIndex = 5;
            this.btSugestao3.TabStop = true;
            this.btSugestao3.Text = "sugestao IA";
            this.btSugestao3.UseVisualStyleBackColor = true;
            this.btSugestao3.CheckedChanged += new System.EventHandler(this.btSugestao3_CheckedChanged);
            // 
            // btchamado
            // 
            this.btchamado.BackColor = System.Drawing.Color.SeaGreen;
            this.btchamado.Location = new System.Drawing.Point(190, 414);
            this.btchamado.Name = "btchamado";
            this.btchamado.Size = new System.Drawing.Size(111, 23);
            this.btchamado.TabIndex = 11;
            this.btchamado.Text = "Iniciar Chamado ";
            this.btchamado.UseVisualStyleBackColor = false;
            this.btchamado.Click += new System.EventHandler(this.btchamado_Click);
            // 
            // Menu_IATI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(493, 458);
            this.Controls.Add(this.btchamado);
            this.Controls.Add(this.btSugestao3);
            this.Controls.Add(this.btSugestao2);
            this.Controls.Add(this.btSugestao1);
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
            this.Name = "Menu_IATI";
            this.Text = "Menu_IATI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RadioButton btSugestao1;
        private System.Windows.Forms.RadioButton btSugestao2;
        private System.Windows.Forms.RadioButton btSugestao3;
        private System.Windows.Forms.Button btchamado;
    }
}