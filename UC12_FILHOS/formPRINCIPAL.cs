﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_FILHOS
{
    public partial class FormPRINCIPAL : Form
    {
        public FormPRINCIPAL()
        {
            InitializeComponent();

            MessageBox.Show(ClassVARIAVEIS.usuario);

            validaPERMSSAO();
        }

        private void validaPERMSSAO()
        {
            if (ClassVARIAVEIS.permissao == "admin")
            {
                cadastroToolStripMenuItem.Visible = true;
                labelIMAGEM1.Image = Properties.Resources.escudo;
                labelTEXTO.Text = ClassVARIAVEIS.usuario;
            }
            else
            {
                cadastroToolStripMenuItem.Visible = false;
                labelIMAGEM1.Image = Properties.Resources.pessoa__1_;
                labelTEXTO.Text = ClassVARIAVEIS.usuario;
            }

        }

        private void cadastroToolStripMenuItemCADASTRO_Click(object sender, EventArgs e)
        {
            Form telaCADASTRO = new formCADASTRO();
            telaCADASTRO.MdiParent = this;
            telaCADASTRO.WindowState = FormWindowState.Maximized;
            telaCADASTRO.Show();

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form telaRELATORIO = new formRELATORIO();
            telaRELATORIO.MdiParent = this;
            telaRELATORIO.WindowState = FormWindowState.Maximized;
            telaRELATORIO.Show();
        }
    }
}
