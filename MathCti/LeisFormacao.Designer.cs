namespace MathCTI
{
    partial class frmLeisFormacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeisFormacao));
            this.btnVoltarLeisMenu = new System.Windows.Forms.Button();
            this.grpFormulas = new System.Windows.Forms.GroupBox();
            this.lblPG = new System.Windows.Forms.Label();
            this.lblPA = new System.Windows.Forms.Label();
            this.pcbFormPG = new System.Windows.Forms.PictureBox();
            this.pcbFormPa = new System.Windows.Forms.PictureBox();
            this.lblIntroduction = new System.Windows.Forms.Label();
            this.grpFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFormPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFormPa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarLeisMenu
            // 
            this.btnVoltarLeisMenu.Location = new System.Drawing.Point(151, 262);
            this.btnVoltarLeisMenu.Name = "btnVoltarLeisMenu";
            this.btnVoltarLeisMenu.Size = new System.Drawing.Size(84, 29);
            this.btnVoltarLeisMenu.TabIndex = 8;
            this.btnVoltarLeisMenu.Text = "&Voltar";
            this.btnVoltarLeisMenu.UseVisualStyleBackColor = true;
            this.btnVoltarLeisMenu.Click += new System.EventHandler(this.btnVoltarLeisMenu_Click);
            // 
            // grpFormulas
            // 
            this.grpFormulas.Controls.Add(this.lblPG);
            this.grpFormulas.Controls.Add(this.lblPA);
            this.grpFormulas.Controls.Add(this.pcbFormPG);
            this.grpFormulas.Controls.Add(this.pcbFormPa);
            this.grpFormulas.Location = new System.Drawing.Point(72, 105);
            this.grpFormulas.Name = "grpFormulas";
            this.grpFormulas.Size = new System.Drawing.Size(238, 150);
            this.grpFormulas.TabIndex = 7;
            this.grpFormulas.TabStop = false;
            this.grpFormulas.Text = "Fórmulas";
            // 
            // lblPG
            // 
            this.lblPG.AutoSize = true;
            this.lblPG.Location = new System.Drawing.Point(-1, 86);
            this.lblPG.Name = "lblPG";
            this.lblPG.Size = new System.Drawing.Size(28, 13);
            this.lblPG.TabIndex = 8;
            this.lblPG.Text = "P.G.";
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(1, 31);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(27, 13);
            this.lblPA.TabIndex = 7;
            this.lblPA.Text = "P.A.";
            // 
            // pcbFormPG
            // 
            this.pcbFormPG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbFormPG.BackgroundImage")));
            this.pcbFormPG.Image = ((System.Drawing.Image)(resources.GetObject("pcbFormPG.Image")));
            this.pcbFormPG.Location = new System.Drawing.Point(41, 86);
            this.pcbFormPG.Name = "pcbFormPG";
            this.pcbFormPG.Size = new System.Drawing.Size(191, 49);
            this.pcbFormPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFormPG.TabIndex = 6;
            this.pcbFormPG.TabStop = false;
            // 
            // pcbFormPa
            // 
            this.pcbFormPa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbFormPa.BackgroundImage")));
            this.pcbFormPa.Image = ((System.Drawing.Image)(resources.GetObject("pcbFormPa.Image")));
            this.pcbFormPa.Location = new System.Drawing.Point(42, 31);
            this.pcbFormPa.Name = "pcbFormPa";
            this.pcbFormPa.Size = new System.Drawing.Size(190, 49);
            this.pcbFormPa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFormPa.TabIndex = 5;
            this.pcbFormPa.TabStop = false;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblIntroduction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.Location = new System.Drawing.Point(39, 22);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(309, 63);
            this.lblIntroduction.TabIndex = 6;
            this.lblIntroduction.Click += new System.EventHandler(this.lblIntroduction_Click);
            // 
            // frmLeisFormacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 331);
            this.Controls.Add(this.btnVoltarLeisMenu);
            this.Controls.Add(this.grpFormulas);
            this.Controls.Add(this.lblIntroduction);
            this.Name = "frmLeisFormacao";
            this.Text = "Leis de Formação";
            this.grpFormulas.ResumeLayout(false);
            this.grpFormulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFormPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFormPa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarLeisMenu;
        private System.Windows.Forms.GroupBox grpFormulas;
        private System.Windows.Forms.Label lblPG;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.PictureBox pcbFormPG;
        private System.Windows.Forms.PictureBox pcbFormPa;
        private System.Windows.Forms.Label lblIntroduction;
    }
}