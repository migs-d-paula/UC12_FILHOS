namespace UC12_FILHOS
{
    partial class FormPRINCIPAL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRESPOSTA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelIMAGEM1 = new System.Windows.Forms.Label();
            this.labelTEXTO = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItemCADASTRO_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // labelRESPOSTA
            // 
            this.labelRESPOSTA.AutoSize = true;
            this.labelRESPOSTA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelRESPOSTA.Location = new System.Drawing.Point(0, 439);
            this.labelRESPOSTA.Name = "labelRESPOSTA";
            this.labelRESPOSTA.Size = new System.Drawing.Size(0, 13);
            this.labelRESPOSTA.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTEXTO);
            this.panel1.Controls.Add(this.labelIMAGEM1);
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 29);
            this.panel1.TabIndex = 8;
            // 
            // labelIMAGEM1
            // 
            this.labelIMAGEM1.AutoSize = true;
            this.labelIMAGEM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMAGEM1.Image = global::UC12_FILHOS.Properties.Resources.escudo;
            this.labelIMAGEM1.Location = new System.Drawing.Point(4, 4);
            this.labelIMAGEM1.Name = "labelIMAGEM1";
            this.labelIMAGEM1.Size = new System.Drawing.Size(29, 20);
            this.labelIMAGEM1.TabIndex = 0;
            this.labelIMAGEM1.Text = "     ";
            // 
            // labelTEXTO
            // 
            this.labelTEXTO.AutoSize = true;
            this.labelTEXTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTEXTO.Location = new System.Drawing.Point(45, 4);
            this.labelTEXTO.Name = "labelTEXTO";
            this.labelTEXTO.Size = new System.Drawing.Size(51, 20);
            this.labelTEXTO.TabIndex = 9;
            this.labelTEXTO.Text = "label2";
            // 
            // FormPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRESPOSTA);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPRINCIPAL";
            this.Text = "PRINCIPAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.Label labelRESPOSTA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTEXTO;
        private System.Windows.Forms.Label labelIMAGEM1;
    }
}

