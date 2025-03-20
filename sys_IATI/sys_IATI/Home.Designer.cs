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
            this.lblNomeIati = new System.Windows.Forms.Label();
            this.listaDeVisualizarChamado = new System.Windows.Forms.ListView();
            this.lblChamados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastroEmpresa
            // 
            this.btCadastroEmpresa.BackColor = System.Drawing.Color.SlateGray;
            this.btCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastroEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastroEmpresa.Location = new System.Drawing.Point(71, 113);
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
            this.btCadastroUsuario.Location = new System.Drawing.Point(254, 112);
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
            this.btCadastroAdm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastroAdm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastroAdm.Location = new System.Drawing.Point(442, 112);
            this.btCadastroAdm.Name = "btCadastroAdm";
            this.btCadastroAdm.Size = new System.Drawing.Size(158, 70);
            this.btCadastroAdm.TabIndex = 3;
            this.btCadastroAdm.Text = "Cadastro Funcionario";
            this.btCadastroAdm.UseVisualStyleBackColor = false;
            this.btCadastroAdm.Click += new System.EventHandler(this.btCadastroAdm_Click);
            // 
            // lblNomeIati
            // 
            this.lblNomeIati.AutoSize = true;
            this.lblNomeIati.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeIati.Location = new System.Drawing.Point(82, 25);
            this.lblNomeIati.Name = "lblNomeIati";
            this.lblNomeIati.Size = new System.Drawing.Size(112, 55);
            this.lblNomeIati.TabIndex = 4;
            this.lblNomeIati.Text = "IATI";
            // 
            // listaDeVisualizarChamado
            // 
            this.listaDeVisualizarChamado.BackColor = System.Drawing.Color.SlateGray;
            this.listaDeVisualizarChamado.HideSelection = false;
            this.listaDeVisualizarChamado.Location = new System.Drawing.Point(71, 238);
            this.listaDeVisualizarChamado.Name = "listaDeVisualizarChamado";
            this.listaDeVisualizarChamado.Size = new System.Drawing.Size(529, 137);
            this.listaDeVisualizarChamado.TabIndex = 5;
            this.listaDeVisualizarChamado.UseCompatibleStateImageBehavior = false;
            this.listaDeVisualizarChamado.SelectedIndexChanged += new System.EventHandler(this.listaDeVisualizarChamado_SelectedIndexChanged);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(663, 453);
            this.Controls.Add(this.lblChamados);
            this.Controls.Add(this.listaDeVisualizarChamado);
            this.Controls.Add(this.lblNomeIati);
            this.Controls.Add(this.btCadastroAdm);
            this.Controls.Add(this.btCadastroUsuario);
            this.Controls.Add(this.logoHome);
            this.Controls.Add(this.btCadastroEmpresa);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastroEmpresa;
        private System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.Button btCadastroUsuario;
        private System.Windows.Forms.Button btCadastroAdm;
        private System.Windows.Forms.Label lblNomeIati;
        private System.Windows.Forms.ListView listaDeVisualizarChamado;
        private System.Windows.Forms.Label lblChamados;
    }
}