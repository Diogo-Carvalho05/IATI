namespace sys_IATI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btCadastroEmpresa = new System.Windows.Forms.Button();
            this.logoHome = new System.Windows.Forms.PictureBox();
            this.btCadastroUsuario = new System.Windows.Forms.Button();
            this.btCadastroAdm = new System.Windows.Forms.Button();
            this.lblChamados = new System.Windows.Forms.Label();
            this.btEditarFuncionario = new System.Windows.Forms.Button();
            this.btEditarUsuario = new System.Windows.Forms.Button();
            this.btEdidarEmpresa = new System.Windows.Forms.Button();
            this.listaDeChamado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastroEmpresa
            // 
            this.btCadastroEmpresa.BackColor = System.Drawing.Color.SlateGray;
            this.btCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastroEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastroEmpresa.Location = new System.Drawing.Point(83, 30);
            this.btCadastroEmpresa.Name = "btCadastroEmpresa";
            this.btCadastroEmpresa.Size = new System.Drawing.Size(140, 69);
            this.btCadastroEmpresa.TabIndex = 0;
            this.btCadastroEmpresa.Text = "Cadastra Empresa";
            this.btCadastroEmpresa.UseVisualStyleBackColor = false;
            this.btCadastroEmpresa.Click += new System.EventHandler(this.btCadastroEmpresa_Click);
            // 
            // logoHome
            // 
            this.logoHome.Image = ((System.Drawing.Image)(resources.GetObject("logoHome.Image")));
            this.logoHome.Location = new System.Drawing.Point(2, 0);
            this.logoHome.Name = "logoHome";
            this.logoHome.Size = new System.Drawing.Size(74, 99);
            this.logoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoHome.TabIndex = 1;
            this.logoHome.TabStop = false;
            // 
            // btCadastroUsuario
            // 
            this.btCadastroUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.btCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastroUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastroUsuario.Location = new System.Drawing.Point(266, 29);
            this.btCadastroUsuario.Name = "btCadastroUsuario";
            this.btCadastroUsuario.Size = new System.Drawing.Size(142, 70);
            this.btCadastroUsuario.TabIndex = 2;
            this.btCadastroUsuario.Text = "Cadastro Usuario";
            this.btCadastroUsuario.UseVisualStyleBackColor = false;
            this.btCadastroUsuario.Click += new System.EventHandler(this.btCadastroUsuario_Click);
            // 
            // btCadastroAdm
            // 
            this.btCadastroAdm.BackColor = System.Drawing.Color.SlateGray;
            this.btCadastroAdm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btCadastroAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastroAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastroAdm.Location = new System.Drawing.Point(454, 29);
            this.btCadastroAdm.Name = "btCadastroAdm";
            this.btCadastroAdm.Size = new System.Drawing.Size(158, 70);
            this.btCadastroAdm.TabIndex = 3;
            this.btCadastroAdm.Text = "Cadastro Funcionario";
            this.btCadastroAdm.UseVisualStyleBackColor = false;
            this.btCadastroAdm.Click += new System.EventHandler(this.btCadastroAdm_Click);
            // 
            // lblChamados
            // 
            this.lblChamados.AutoSize = true;
            this.lblChamados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamados.Location = new System.Drawing.Point(68, 219);
            this.lblChamados.Name = "lblChamados";
            this.lblChamados.Size = new System.Drawing.Size(74, 16);
            this.lblChamados.TabIndex = 6;
            this.lblChamados.Text = "Chamados";
            // 
            // btEditarFuncionario
            // 
            this.btEditarFuncionario.BackColor = System.Drawing.Color.SlateGray;
            this.btEditarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditarFuncionario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditarFuncionario.Location = new System.Drawing.Point(454, 129);
            this.btEditarFuncionario.Name = "btEditarFuncionario";
            this.btEditarFuncionario.Size = new System.Drawing.Size(158, 70);
            this.btEditarFuncionario.TabIndex = 9;
            this.btEditarFuncionario.Text = "Editar Funcionario";
            this.btEditarFuncionario.UseVisualStyleBackColor = false;
            // 
            // btEditarUsuario
            // 
            this.btEditarUsuario.BackColor = System.Drawing.Color.SlateGray;
            this.btEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEditarUsuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditarUsuario.Location = new System.Drawing.Point(266, 129);
            this.btEditarUsuario.Name = "btEditarUsuario";
            this.btEditarUsuario.Size = new System.Drawing.Size(142, 70);
            this.btEditarUsuario.TabIndex = 8;
            this.btEditarUsuario.Text = "Editar Usuario";
            this.btEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btEdidarEmpresa
            // 
            this.btEdidarEmpresa.BackColor = System.Drawing.Color.SlateGray;
            this.btEdidarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEdidarEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdidarEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.btEdidarEmpresa.Location = new System.Drawing.Point(83, 130);
            this.btEdidarEmpresa.Name = "btEdidarEmpresa";
            this.btEdidarEmpresa.Size = new System.Drawing.Size(140, 69);
            this.btEdidarEmpresa.TabIndex = 7;
            this.btEdidarEmpresa.Text = "Editar Empresa";
            this.btEdidarEmpresa.UseVisualStyleBackColor = false;
            // 
            // listaDeChamado
            // 
            this.listaDeChamado.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listaDeChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDeChamado.Location = new System.Drawing.Point(71, 242);
            this.listaDeChamado.Name = "listaDeChamado";
            this.listaDeChamado.Size = new System.Drawing.Size(541, 150);
            this.listaDeChamado.TabIndex = 11;
            this.listaDeChamado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.controleDaCelulaDeChamado);
            this.listaDeChamado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaDeChamado_CellContentClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.listaDeChamado);
            this.Controls.Add(this.btEditarFuncionario);
            this.Controls.Add(this.btEditarUsuario);
            this.Controls.Add(this.btEdidarEmpresa);
            this.Controls.Add(this.lblChamados);
            this.Controls.Add(this.btCadastroAdm);
            this.Controls.Add(this.btCadastroUsuario);
            this.Controls.Add(this.logoHome);
            this.Controls.Add(this.btCadastroEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastroEmpresa;
        private System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.Button btCadastroUsuario;
        private System.Windows.Forms.Button btCadastroAdm;
        private System.Windows.Forms.Label lblChamados;
        private System.Windows.Forms.Button btEditarFuncionario;
        private System.Windows.Forms.Button btEditarUsuario;
        private System.Windows.Forms.Button btEdidarEmpresa;
        private System.Windows.Forms.DataGridView listaDeChamado;
    }
}