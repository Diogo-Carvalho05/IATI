namespace sys_IATI
{
    partial class cadastroAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroAdm));
            this.logoCadastroAdm = new System.Windows.Forms.PictureBox();
            this.lblCadastroAdm = new System.Windows.Forms.Label();
            this.txtNomeAdm = new System.Windows.Forms.TextBox();
            this.lblNomeAdm = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDataAdmissao = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSalarioMensal = new System.Windows.Forms.Label();
            this.txtSalarioMensal = new System.Windows.Forms.TextBox();
            this.lblStato = new System.Windows.Forms.Label();
            this.btStatosAtivo = new System.Windows.Forms.RadioButton();
            this.btStatosInativo = new System.Windows.Forms.RadioButton();
            this.btSalvarAdm = new System.Windows.Forms.Button();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btDeSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoCadastroAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeSair)).BeginInit();
            this.SuspendLayout();
            // 
            // logoCadastroAdm
            // 
            this.logoCadastroAdm.Image = ((System.Drawing.Image)(resources.GetObject("logoCadastroAdm.Image")));
            this.logoCadastroAdm.Location = new System.Drawing.Point(1, 0);
            this.logoCadastroAdm.Name = "logoCadastroAdm";
            this.logoCadastroAdm.Size = new System.Drawing.Size(77, 100);
            this.logoCadastroAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoCadastroAdm.TabIndex = 0;
            this.logoCadastroAdm.TabStop = false;
            this.logoCadastroAdm.Click += new System.EventHandler(this.logoCadastroAdm_Click);
            // 
            // lblCadastroAdm
            // 
            this.lblCadastroAdm.AutoSize = true;
            this.lblCadastroAdm.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroAdm.Location = new System.Drawing.Point(228, 29);
            this.lblCadastroAdm.Name = "lblCadastroAdm";
            this.lblCadastroAdm.Size = new System.Drawing.Size(311, 46);
            this.lblCadastroAdm.TabIndex = 1;
            this.lblCadastroAdm.Text = "Cadastro de ADM";
            // 
            // txtNomeAdm
            // 
            this.txtNomeAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAdm.Location = new System.Drawing.Point(145, 143);
            this.txtNomeAdm.Name = "txtNomeAdm";
            this.txtNomeAdm.Size = new System.Drawing.Size(168, 23);
            this.txtNomeAdm.TabIndex = 1;
            this.txtNomeAdm.TextChanged += new System.EventHandler(this.txtNomeAdm_TextChanged);
            // 
            // lblNomeAdm
            // 
            this.lblNomeAdm.AutoSize = true;
            this.lblNomeAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAdm.Location = new System.Drawing.Point(142, 124);
            this.lblNomeAdm.Name = "lblNomeAdm";
            this.lblNomeAdm.Size = new System.Drawing.Size(43, 16);
            this.lblNomeAdm.TabIndex = 3;
            this.lblNomeAdm.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(363, 124);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(32, 16);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(23, 124);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 16);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(26, 143);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(61, 23);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(569, 124);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(83, 16);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "Nascimento";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(569, 202);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 16);
            this.lblEndereco.TabIndex = 17;
            this.lblEndereco.Text = "ENDEREÇO";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(572, 221);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(168, 23);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(363, 202);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(74, 16);
            this.lblTelefone.TabIndex = 15;
            this.lblTelefone.Text = "TELEFONE";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(142, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(145, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblDataAdmissao
            // 
            this.lblDataAdmissao.AutoSize = true;
            this.lblDataAdmissao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAdmissao.Location = new System.Drawing.Point(569, 280);
            this.lblDataAdmissao.Name = "lblDataAdmissao";
            this.lblDataAdmissao.Size = new System.Drawing.Size(139, 16);
            this.lblDataAdmissao.TabIndex = 23;
            this.lblDataAdmissao.Text = "DATA DE ADMISSÃO";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(142, 280);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 16);
            this.lblCargo.TabIndex = 21;
            this.lblCargo.Text = "CARGO";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(145, 299);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(168, 23);
            this.txtCargo.TabIndex = 7;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(363, 280);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(51, 16);
            this.lblSetor.TabIndex = 19;
            this.lblSetor.Text = "SETOR";
            // 
            // txtSetor
            // 
            this.txtSetor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(366, 299);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(168, 23);
            this.txtSetor.TabIndex = 8;
            this.txtSetor.TextChanged += new System.EventHandler(this.txtSetor_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(569, 357);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 16);
            this.lblSenha.TabIndex = 29;
            this.lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(572, 376);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 23);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblSalarioMensal
            // 
            this.lblSalarioMensal.AutoSize = true;
            this.lblSalarioMensal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMensal.Location = new System.Drawing.Point(142, 357);
            this.lblSalarioMensal.Name = "lblSalarioMensal";
            this.lblSalarioMensal.Size = new System.Drawing.Size(122, 16);
            this.lblSalarioMensal.TabIndex = 27;
            this.lblSalarioMensal.Text = "SALARIO MENSAL";
            // 
            // txtSalarioMensal
            // 
            this.txtSalarioMensal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMensal.Location = new System.Drawing.Point(145, 376);
            this.txtSalarioMensal.Name = "txtSalarioMensal";
            this.txtSalarioMensal.Size = new System.Drawing.Size(168, 23);
            this.txtSalarioMensal.TabIndex = 10;
            this.txtSalarioMensal.TextChanged += new System.EventHandler(this.txtSalarioMensal_TextChanged);
            // 
            // lblStato
            // 
            this.lblStato.AutoSize = true;
            this.lblStato.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStato.Location = new System.Drawing.Point(377, 357);
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(60, 16);
            this.lblStato.TabIndex = 25;
            this.lblStato.Text = "STATOS";
            // 
            // btStatosAtivo
            // 
            this.btStatosAtivo.AutoSize = true;
            this.btStatosAtivo.Location = new System.Drawing.Point(380, 376);
            this.btStatosAtivo.Name = "btStatosAtivo";
            this.btStatosAtivo.Size = new System.Drawing.Size(57, 17);
            this.btStatosAtivo.TabIndex = 11;
            this.btStatosAtivo.TabStop = true;
            this.btStatosAtivo.Text = "ATIVO";
            this.btStatosAtivo.UseVisualStyleBackColor = true;
            this.btStatosAtivo.CheckedChanged += new System.EventHandler(this.btStatosAtivo_CheckedChanged);
            // 
            // btStatosInativo
            // 
            this.btStatosInativo.AutoSize = true;
            this.btStatosInativo.Location = new System.Drawing.Point(380, 399);
            this.btStatosInativo.Name = "btStatosInativo";
            this.btStatosInativo.Size = new System.Drawing.Size(79, 17);
            this.btStatosInativo.TabIndex = 12;
            this.btStatosInativo.TabStop = true;
            this.btStatosInativo.Text = "DESATIVO";
            this.btStatosInativo.UseVisualStyleBackColor = true;
            this.btStatosInativo.CheckedChanged += new System.EventHandler(this.btStatosInativo_CheckedChanged);
            // 
            // btSalvarAdm
            // 
            this.btSalvarAdm.BackColor = System.Drawing.Color.YellowGreen;
            this.btSalvarAdm.FlatAppearance.BorderSize = 0;
            this.btSalvarAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btSalvarAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarAdm.Location = new System.Drawing.Point(26, 366);
            this.btSalvarAdm.Name = "btSalvarAdm";
            this.btSalvarAdm.Size = new System.Drawing.Size(75, 42);
            this.btSalvarAdm.TabIndex = 14;
            this.btSalvarAdm.Text = "SALVAR";
            this.btSalvarAdm.UseVisualStyleBackColor = false;
            this.btSalvarAdm.Click += new System.EventHandler(this.btSalvarAdm_Click);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(572, 146);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(168, 20);
            this.txtDataNascimento.TabIndex = 33;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            this.txtDataNascimento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataNascimento_MaskInputRejected);
            // 
            // txtDataAdmissao
            // 
            this.txtDataAdmissao.Location = new System.Drawing.Point(572, 302);
            this.txtDataAdmissao.Mask = "00/00/0000";
            this.txtDataAdmissao.Name = "txtDataAdmissao";
            this.txtDataAdmissao.Size = new System.Drawing.Size(168, 20);
            this.txtDataAdmissao.TabIndex = 34;
            this.txtDataAdmissao.ValidatingType = typeof(System.DateTime);
            this.txtDataAdmissao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataAdmissao_MaskInputRejected);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(366, 221);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 35;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(366, 143);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(168, 20);
            this.txtCpf.TabIndex = 36;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Location = new System.Drawing.Point(665, 52);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 37;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btDeSair
            // 
            this.btDeSair.Image = global::sys_IATI.Properties.Resources.download_removebg_preview;
            this.btDeSair.Location = new System.Drawing.Point(735, 12);
            this.btDeSair.Name = "btDeSair";
            this.btDeSair.Size = new System.Drawing.Size(53, 32);
            this.btDeSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btDeSair.TabIndex = 38;
            this.btDeSair.TabStop = false;
            this.btDeSair.Click += new System.EventHandler(this.btDeSair_Click);
            // 
            // cadastroAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDeSair);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataAdmissao);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.btSalvarAdm);
            this.Controls.Add(this.btStatosInativo);
            this.Controls.Add(this.btStatosAtivo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSalarioMensal);
            this.Controls.Add(this.txtSalarioMensal);
            this.Controls.Add(this.lblStato);
            this.Controls.Add(this.lblDataAdmissao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNomeAdm);
            this.Controls.Add(this.txtNomeAdm);
            this.Controls.Add(this.lblCadastroAdm);
            this.Controls.Add(this.logoCadastroAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadastroAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastroAdm";
            this.Load += new System.EventHandler(this.cadastroAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoCadastroAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDeSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoCadastroAdm;
        private System.Windows.Forms.Label lblCadastroAdm;
        private System.Windows.Forms.TextBox txtNomeAdm;
        private System.Windows.Forms.Label lblNomeAdm;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDataAdmissao;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSalarioMensal;
        private System.Windows.Forms.TextBox txtSalarioMensal;
        private System.Windows.Forms.Label lblStato;
        private System.Windows.Forms.RadioButton btStatosAtivo;
        private System.Windows.Forms.RadioButton btStatosInativo;
        private System.Windows.Forms.Button btSalvarAdm;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtDataAdmissao;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.PictureBox btDeSair;
    }
}