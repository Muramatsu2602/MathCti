namespace CalculoPaPg
{
    partial class frmPaPg
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
            this.lblA1 = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmcIndice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.grpTermos = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltarPaPgMenu = new System.Windows.Forms.Button();
            this.lstPA = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmcIndice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.grpTermos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(26, 33);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(94, 13);
            this.lblA1.TabIndex = 0;
            this.lblA1.Text = "a1 (Primeiro termo)";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Location = new System.Drawing.Point(26, 79);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(38, 13);
            this.lblRazao.TabIndex = 1;
            this.lblRazao.Text = "Razão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N =";
            // 
            // nmcIndice
            // 
            this.nmcIndice.Location = new System.Drawing.Point(126, 129);
            this.nmcIndice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmcIndice.Name = "nmcIndice";
            this.nmcIndice.Size = new System.Drawing.Size(84, 20);
            this.nmcIndice.TabIndex = 3;
            this.nmcIndice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 33);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(126, 79);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpTermos
            // 
            this.grpTermos.Controls.Add(this.btnVer);
            this.grpTermos.Controls.Add(this.numericUpDown2);
            this.grpTermos.Controls.Add(this.numericUpDown1);
            this.grpTermos.Controls.Add(this.nmcIndice);
            this.grpTermos.Controls.Add(this.label1);
            this.grpTermos.Controls.Add(this.lblRazao);
            this.grpTermos.Controls.Add(this.lblA1);
            this.grpTermos.Location = new System.Drawing.Point(18, 12);
            this.grpTermos.Name = "grpTermos";
            this.grpTermos.Size = new System.Drawing.Size(312, 168);
            this.grpTermos.TabIndex = 6;
            this.grpTermos.TabStop = false;
            this.grpTermos.Text = "Digite os valores";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(232, 131);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(65, 20);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(56, 272);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(88, 23);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "&Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(188, 272);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnVoltarPaPgMenu
            // 
            this.btnVoltarPaPgMenu.Location = new System.Drawing.Point(318, 272);
            this.btnVoltarPaPgMenu.Name = "btnVoltarPaPgMenu";
            this.btnVoltarPaPgMenu.Size = new System.Drawing.Size(88, 23);
            this.btnVoltarPaPgMenu.TabIndex = 9;
            this.btnVoltarPaPgMenu.Text = "&Voltar";
            this.btnVoltarPaPgMenu.UseVisualStyleBackColor = true;
            // 
            // lstPA
            // 
            this.lstPA.FormattingEnabled = true;
            this.lstPA.Location = new System.Drawing.Point(424, 32);
            this.lstPA.Name = "lstPA";
            this.lstPA.Size = new System.Drawing.Size(54, 147);
            this.lstPA.TabIndex = 10;
            this.lstPA.SelectedIndexChanged += new System.EventHandler(this.lstPA_SelectedIndexChanged);
            // 
            // frmPaPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 327);
            this.ControlBox = false;
            this.Controls.Add(this.lstPA);
            this.Controls.Add(this.btnVoltarPaPgMenu);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.grpTermos);
            this.Name = "frmPaPg";
            this.Text = "Math - Pa Pg";
            ((System.ComponentModel.ISupportInitialize)(this.nmcIndice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.grpTermos.ResumeLayout(false);
            this.grpTermos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmcIndice;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox grpTermos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltarPaPgMenu;
        private System.Windows.Forms.ListBox lstPA;
    }
}

