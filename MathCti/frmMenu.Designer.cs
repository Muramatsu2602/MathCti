namespace MathCti
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnLeisDeFormacao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPaPg = new System.Windows.Forms.Button();
            this.lblCampoNome = new System.Windows.Forms.Label();
            this.pnlOpcoes = new System.Windows.Forms.Panel();
            this.pnlFechar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlLeisFormacao = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.pnlOpcoes.SuspendLayout();
            this.pnlFechar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlLeisFormacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeisDeFormacao
            // 
            this.btnLeisDeFormacao.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLeisDeFormacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeisDeFormacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeisDeFormacao.ForeColor = System.Drawing.Color.White;
            this.btnLeisDeFormacao.Location = new System.Drawing.Point(-1, -1);
            this.btnLeisDeFormacao.Name = "btnLeisDeFormacao";
            this.btnLeisDeFormacao.Size = new System.Drawing.Size(87, 49);
            this.btnLeisDeFormacao.TabIndex = 3;
            this.btnLeisDeFormacao.Text = "&LEIS DE FORMAÇÃO";
            this.btnLeisDeFormacao.UseVisualStyleBackColor = false;
            this.btnLeisDeFormacao.Click += new System.EventHandler(this.btnLeisDeFormacao_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(-1, -1);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 51);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Cyan;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtNome.Location = new System.Drawing.Point(74, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(113, 27);
            this.txtNome.TabIndex = 1;
            // 
            // btnPaPg
            // 
            this.btnPaPg.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPaPg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaPg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaPg.ForeColor = System.Drawing.Color.White;
            this.btnPaPg.Location = new System.Drawing.Point(-1, -1);
            this.btnPaPg.Name = "btnPaPg";
            this.btnPaPg.Size = new System.Drawing.Size(87, 49);
            this.btnPaPg.TabIndex = 2;
            this.btnPaPg.Text = "&PA PG";
            this.btnPaPg.UseVisualStyleBackColor = false;
            this.btnPaPg.Click += new System.EventHandler(this.btnPaPg_Click);
            // 
            // lblCampoNome
            // 
            this.lblCampoNome.AutoSize = true;
            this.lblCampoNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCampoNome.ForeColor = System.Drawing.Color.White;
            this.lblCampoNome.Location = new System.Drawing.Point(3, 19);
            this.lblCampoNome.Name = "lblCampoNome";
            this.lblCampoNome.Size = new System.Drawing.Size(67, 18);
            this.lblCampoNome.TabIndex = 2;
            this.lblCampoNome.Text = "NOME:";
            // 
            // pnlOpcoes
            // 
            this.pnlOpcoes.BackColor = System.Drawing.Color.Aqua;
            this.pnlOpcoes.Controls.Add(this.pnlFechar);
            this.pnlOpcoes.Controls.Add(this.panel3);
            this.pnlOpcoes.Controls.Add(this.pnlLeisFormacao);
            this.pnlOpcoes.Location = new System.Drawing.Point(408, 0);
            this.pnlOpcoes.Name = "pnlOpcoes";
            this.pnlOpcoes.Size = new System.Drawing.Size(110, 348);
            this.pnlOpcoes.TabIndex = 4;
            // 
            // pnlFechar
            // 
            this.pnlFechar.BackColor = System.Drawing.Color.Red;
            this.pnlFechar.Controls.Add(this.btnSair);
            this.pnlFechar.Location = new System.Drawing.Point(13, 77);
            this.pnlFechar.Name = "pnlFechar";
            this.pnlFechar.Size = new System.Drawing.Size(82, 49);
            this.pnlFechar.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.btnPaPg);
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 47);
            this.panel3.TabIndex = 7;
            // 
            // pnlLeisFormacao
            // 
            this.pnlLeisFormacao.BackColor = System.Drawing.Color.Blue;
            this.pnlLeisFormacao.Controls.Add(this.btnLeisDeFormacao);
            this.pnlLeisFormacao.Location = new System.Drawing.Point(13, 229);
            this.pnlLeisFormacao.Name = "pnlLeisFormacao";
            this.pnlLeisFormacao.Size = new System.Drawing.Size(85, 47);
            this.pnlLeisFormacao.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(22, 21);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(60, 18);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlLogin.Controls.Add(this.lblMenu);
            this.pnlLogin.Location = new System.Drawing.Point(408, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(110, 59);
            this.pnlLogin.TabIndex = 6;
            // 
            // pnlNome
            // 
            this.pnlNome.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlNome.Controls.Add(this.lblCampoNome);
            this.pnlNome.Controls.Add(this.txtNome);
            this.pnlNome.Location = new System.Drawing.Point(105, 259);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(200, 61);
            this.pnlNome.TabIndex = 7;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(518, 347);
            this.Controls.Add(this.pnlNome);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaPg";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlOpcoes.ResumeLayout(false);
            this.pnlFechar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlLeisFormacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeisDeFormacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnPaPg;
        private System.Windows.Forms.Label lblCampoNome;
        private System.Windows.Forms.Panel pnlOpcoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlLeisFormacao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.Panel pnlFechar;
    }
}

