namespace UC12_FILHOS
{
    partial class FormLOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.checkBoxADM = new System.Windows.Forms.CheckBox();
            this.buttonENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(71, 63);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(214, 20);
            this.textBoxUSUARIO.TabIndex = 1;
            // 
            // checkBoxADM
            // 
            this.checkBoxADM.AutoSize = true;
            this.checkBoxADM.Location = new System.Drawing.Point(124, 114);
            this.checkBoxADM.Name = "checkBoxADM";
            this.checkBoxADM.Size = new System.Drawing.Size(88, 17);
            this.checkBoxADM.TabIndex = 2;
            this.checkBoxADM.Text = "administrador";
            this.checkBoxADM.UseVisualStyleBackColor = true;
            // 
            // buttonENTRAR
            // 
            this.buttonENTRAR.Location = new System.Drawing.Point(129, 165);
            this.buttonENTRAR.Name = "buttonENTRAR";
            this.buttonENTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonENTRAR.TabIndex = 3;
            this.buttonENTRAR.Text = "entrar";
            this.buttonENTRAR.UseVisualStyleBackColor = true;
            this.buttonENTRAR.Click += new System.EventHandler(this.buttonENTRAR_Click);
            // 
            // FormLOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.buttonENTRAR);
            this.Controls.Add(this.checkBoxADM);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.label1);
            this.Name = "FormLOGIN";
            this.Text = "FormLOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.CheckBox checkBoxADM;
        private System.Windows.Forms.Button buttonENTRAR;
    }
}