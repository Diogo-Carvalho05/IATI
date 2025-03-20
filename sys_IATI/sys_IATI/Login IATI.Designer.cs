namespace sys_IATI
{
    partial class Login_IATI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_IATI));
            this.txtPasseword = new System.Windows.Forms.TextBox();
            this.lblPasseword = new System.Windows.Forms.Label();
            this.btAcesso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasseword
            // 
            this.txtPasseword.Location = new System.Drawing.Point(85, 135);
            this.txtPasseword.Name = "txtPasseword";
            this.txtPasseword.Size = new System.Drawing.Size(100, 20);
            this.txtPasseword.TabIndex = 1;
            this.txtPasseword.TextChanged += new System.EventHandler(this.txtPasseword_TextChanged);
            // 
            // lblPasseword
            // 
            this.lblPasseword.AutoSize = true;
            this.lblPasseword.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasseword.ForeColor = System.Drawing.Color.White;
            this.lblPasseword.Location = new System.Drawing.Point(36, 135);
            this.lblPasseword.Name = "lblPasseword";
            this.lblPasseword.Size = new System.Drawing.Size(46, 13);
            this.lblPasseword.TabIndex = 1;
            this.lblPasseword.Text = "SENHA";
            // 
            // btAcesso
            // 
            this.btAcesso.BackColor = System.Drawing.Color.SeaGreen;
            this.btAcesso.ForeColor = System.Drawing.Color.White;
            this.btAcesso.Location = new System.Drawing.Point(85, 161);
            this.btAcesso.Name = "btAcesso";
            this.btAcesso.Size = new System.Drawing.Size(90, 25);
            this.btAcesso.TabIndex = 3;
            this.btAcesso.Text = "&ACESSO";
            this.btAcesso.UseVisualStyleBackColor = false;
            this.btAcesso.Click += new System.EventHandler(this.btAcesso_Click_1);
            this.btAcesso.Enter += new System.EventHandler(this.btAcesso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "IATI";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(85, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(1, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(81, 97);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(21, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "USUARIO";
            // 
            // Login_IATI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(236, 238);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btAcesso);
            this.Controls.Add(this.lblPasseword);
            this.Controls.Add(this.txtPasseword);
            this.Controls.Add(this.label1);
            this.Name = "Login_IATI";
            this.Text = "Login_IATI";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasseword;
        private System.Windows.Forms.Label lblPasseword;
        private System.Windows.Forms.Button btAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblUsuario;
    }
}