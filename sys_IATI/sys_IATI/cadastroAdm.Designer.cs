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
            ((System.ComponentModel.ISupportInitialize)(this.logoCadastroAdm)).BeginInit();
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
            // cadastroAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCadastroAdm);
            this.Controls.Add(this.logoCadastroAdm);
            this.Name = "cadastroAdm";
            this.Text = "cadastroAdm";
            ((System.ComponentModel.ISupportInitialize)(this.logoCadastroAdm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoCadastroAdm;
        private System.Windows.Forms.Label lblCadastroAdm;
    }
}