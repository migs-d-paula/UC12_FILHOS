namespace UC12_FILHOS
{
    partial class formCADASTRO
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
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textBoxCONFIRMARSENHA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonADMINISTRADOR = new System.Windows.Forms.RadioButton();
            this.radioButtonUSUARIO = new System.Windows.Forms.RadioButton();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Location = new System.Drawing.Point(124, 76);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(496, 20);
            this.textBoxUSUARIO.TabIndex = 0;
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Location = new System.Drawing.Point(124, 136);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.PasswordChar = '*';
            this.textBoxSENHA.Size = new System.Drawing.Size(496, 20);
            this.textBoxSENHA.TabIndex = 1;
            // 
            // textBoxCONFIRMARSENHA
            // 
            this.textBoxCONFIRMARSENHA.Location = new System.Drawing.Point(124, 196);
            this.textBoxCONFIRMARSENHA.Name = "textBoxCONFIRMARSENHA";
            this.textBoxCONFIRMARSENHA.PasswordChar = '*';
            this.textBoxCONFIRMARSENHA.Size = new System.Drawing.Size(496, 20);
            this.textBoxCONFIRMARSENHA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar senha";
            // 
            // radioButtonADMINISTRADOR
            // 
            this.radioButtonADMINISTRADOR.AutoSize = true;
            this.radioButtonADMINISTRADOR.Location = new System.Drawing.Point(124, 251);
            this.radioButtonADMINISTRADOR.Name = "radioButtonADMINISTRADOR";
            this.radioButtonADMINISTRADOR.Size = new System.Drawing.Size(88, 17);
            this.radioButtonADMINISTRADOR.TabIndex = 7;
            this.radioButtonADMINISTRADOR.TabStop = true;
            this.radioButtonADMINISTRADOR.Text = "Administrador";
            this.radioButtonADMINISTRADOR.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSUARIO
            // 
            this.radioButtonUSUARIO.AutoSize = true;
            this.radioButtonUSUARIO.Location = new System.Drawing.Point(124, 292);
            this.radioButtonUSUARIO.Name = "radioButtonUSUARIO";
            this.radioButtonUSUARIO.Size = new System.Drawing.Size(61, 17);
            this.radioButtonUSUARIO.TabIndex = 8;
            this.radioButtonUSUARIO.TabStop = true;
            this.radioButtonUSUARIO.Text = "Usuário";
            this.radioButtonUSUARIO.UseVisualStyleBackColor = true;
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.Location = new System.Drawing.Point(312, 339);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(117, 52);
            this.buttonCADASTRAR.TabIndex = 9;
            this.buttonCADASTRAR.Text = "Cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // formCADASTRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Controls.Add(this.radioButtonUSUARIO);
            this.Controls.Add(this.radioButtonADMINISTRADOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCONFIRMARSENHA);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Name = "formCADASTRO";
            this.Text = "CADASTRO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.TextBox textBoxCONFIRMARSENHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonADMINISTRADOR;
        private System.Windows.Forms.RadioButton radioButtonUSUARIO;
        private System.Windows.Forms.Button buttonCADASTRAR;
    }
}