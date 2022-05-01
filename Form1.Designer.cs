namespace Projeto_Escolha_Veiculos
{
    partial class frmVeiculos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeiculos));
            this.radCarros = new System.Windows.Forms.RadioButton();
            this.radMotos = new System.Windows.Forms.RadioButton();
            this.picBugati = new System.Windows.Forms.PictureBox();
            this.picFerrari = new System.Windows.Forms.PictureBox();
            this.picMt03 = new System.Windows.Forms.PictureBox();
            this.picMt09 = new System.Windows.Forms.PictureBox();
            this.radBugat = new System.Windows.Forms.RadioButton();
            this.radFerrari = new System.Windows.Forms.RadioButton();
            this.radMt03 = new System.Windows.Forms.RadioButton();
            this.radMt09 = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBugati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFerrari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMt03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMt09)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarros
            // 
            this.radCarros.AutoSize = true;
            this.radCarros.Location = new System.Drawing.Point(111, 30);
            this.radCarros.Name = "radCarros";
            this.radCarros.Size = new System.Drawing.Size(55, 17);
            this.radCarros.TabIndex = 5;
            this.radCarros.TabStop = true;
            this.radCarros.Text = "Carros";
            this.radCarros.UseVisualStyleBackColor = true;
            this.radCarros.CheckedChanged += new System.EventHandler(this.radCarros_CheckedChanged);
            // 
            // radMotos
            // 
            this.radMotos.AutoSize = true;
            this.radMotos.Location = new System.Drawing.Point(500, 30);
            this.radMotos.Name = "radMotos";
            this.radMotos.Size = new System.Drawing.Size(54, 17);
            this.radMotos.TabIndex = 6;
            this.radMotos.TabStop = true;
            this.radMotos.Text = "Motos";
            this.radMotos.UseVisualStyleBackColor = true;
            this.radMotos.CheckedChanged += new System.EventHandler(this.radMotos_CheckedChanged);
            // 
            // picBugati
            // 
            this.picBugati.Image = ((System.Drawing.Image)(resources.GetObject("picBugati.Image")));
            this.picBugati.Location = new System.Drawing.Point(41, 53);
            this.picBugati.Name = "picBugati";
            this.picBugati.Size = new System.Drawing.Size(204, 133);
            this.picBugati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBugati.TabIndex = 2;
            this.picBugati.TabStop = false;
            this.picBugati.Visible = false;
            // 
            // picFerrari
            // 
            this.picFerrari.Image = ((System.Drawing.Image)(resources.GetObject("picFerrari.Image")));
            this.picFerrari.Location = new System.Drawing.Point(41, 192);
            this.picFerrari.Name = "picFerrari";
            this.picFerrari.Size = new System.Drawing.Size(204, 133);
            this.picFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFerrari.TabIndex = 3;
            this.picFerrari.TabStop = false;
            this.picFerrari.Visible = false;
            // 
            // picMt03
            // 
            this.picMt03.Image = ((System.Drawing.Image)(resources.GetObject("picMt03.Image")));
            this.picMt03.Location = new System.Drawing.Point(433, 53);
            this.picMt03.Name = "picMt03";
            this.picMt03.Size = new System.Drawing.Size(204, 133);
            this.picMt03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMt03.TabIndex = 4;
            this.picMt03.TabStop = false;
            this.picMt03.Visible = false;
            // 
            // picMt09
            // 
            this.picMt09.Image = ((System.Drawing.Image)(resources.GetObject("picMt09.Image")));
            this.picMt09.Location = new System.Drawing.Point(433, 192);
            this.picMt09.Name = "picMt09";
            this.picMt09.Size = new System.Drawing.Size(204, 133);
            this.picMt09.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMt09.TabIndex = 5;
            this.picMt09.TabStop = false;
            this.picMt09.Visible = false;
            // 
            // radBugat
            // 
            this.radBugat.AutoSize = true;
            this.radBugat.Location = new System.Drawing.Point(252, 114);
            this.radBugat.Name = "radBugat";
            this.radBugat.Size = new System.Drawing.Size(55, 17);
            this.radBugat.TabIndex = 7;
            this.radBugat.TabStop = true;
            this.radBugat.Text = "Bugati";
            this.radBugat.UseVisualStyleBackColor = true;
            this.radBugat.Visible = false;
            this.radBugat.CheckedChanged += new System.EventHandler(this.radBugat_CheckedChanged);
            // 
            // radFerrari
            // 
            this.radFerrari.AutoSize = true;
            this.radFerrari.Location = new System.Drawing.Point(252, 244);
            this.radFerrari.Name = "radFerrari";
            this.radFerrari.Size = new System.Drawing.Size(54, 17);
            this.radFerrari.TabIndex = 8;
            this.radFerrari.TabStop = true;
            this.radFerrari.Text = "Ferrari";
            this.radFerrari.UseVisualStyleBackColor = true;
            this.radFerrari.Visible = false;
            this.radFerrari.CheckedChanged += new System.EventHandler(this.radFerrari_CheckedChanged);
            // 
            // radMt03
            // 
            this.radMt03.AutoSize = true;
            this.radMt03.Location = new System.Drawing.Point(643, 114);
            this.radMt03.Name = "radMt03";
            this.radMt03.Size = new System.Drawing.Size(56, 17);
            this.radMt03.TabIndex = 9;
            this.radMt03.TabStop = true;
            this.radMt03.Text = "MT-03";
            this.radMt03.UseVisualStyleBackColor = true;
            this.radMt03.Visible = false;
            this.radMt03.CheckedChanged += new System.EventHandler(this.radMt03_CheckedChanged);
            // 
            // radMt09
            // 
            this.radMt09.AutoSize = true;
            this.radMt09.Location = new System.Drawing.Point(643, 244);
            this.radMt09.Name = "radMt09";
            this.radMt09.Size = new System.Drawing.Size(56, 17);
            this.radMt09.TabIndex = 10;
            this.radMt09.TabStop = true;
            this.radMt09.Text = "MT-09";
            this.radMt09.UseVisualStyleBackColor = true;
            this.radMt09.Visible = false;
            this.radMt09.CheckedChanged += new System.EventHandler(this.radMt09_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(265, 349);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(367, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(49, 349);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(35, 13);
            this.lblMensagem.TabIndex = 11;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.Visible = false;
            // 
            // frmVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 384);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.radMt09);
            this.Controls.Add(this.radMt03);
            this.Controls.Add(this.radFerrari);
            this.Controls.Add(this.radBugat);
            this.Controls.Add(this.picMt09);
            this.Controls.Add(this.picMt03);
            this.Controls.Add(this.picFerrari);
            this.Controls.Add(this.picBugati);
            this.Controls.Add(this.radMotos);
            this.Controls.Add(this.radCarros);
            this.Name = "frmVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.picBugati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFerrari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMt03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMt09)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCarros;
        private System.Windows.Forms.RadioButton radMotos;
        private System.Windows.Forms.PictureBox picBugati;
        private System.Windows.Forms.PictureBox picFerrari;
        private System.Windows.Forms.PictureBox picMt03;
        private System.Windows.Forms.PictureBox picMt09;
        private System.Windows.Forms.RadioButton radBugat;
        private System.Windows.Forms.RadioButton radFerrari;
        private System.Windows.Forms.RadioButton radMt03;
        private System.Windows.Forms.RadioButton radMt09;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMensagem;
    }
}

