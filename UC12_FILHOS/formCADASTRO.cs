using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_FILHOS
{
    public partial class formCADASTRO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        int tamanhominimo = 8;

        public formCADASTRO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=login_db;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUSUARIO.Text != "" || textBoxSENHA.Text != "" || textBoxCONFIRMARSENHA.Text != "")
                {
                    if (textBoxSENHA.Text.Length > 8)
                    {
                        if (textBoxSENHA.Text == textBoxCONFIRMARSENHA.Text)
                        {
                            if (radioButtonADMINISTRADOR.Checked)
                            {
                                conexao.Open();
                                comando.CommandText = "SELECT usuario FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "';";
                                MySqlDataReader nome = comando.ExecuteReader();

                                if (nome.Read())
                                {
                                    MessageBox.Show("Este usuario ja existe");
                                }
                                else
                                {
                                    conexao.Close();
                                    conexao.Open();
                                    comando.CommandText = "INSERT INTO tbl_usuarios(usuario, senha, permissao) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "', 'admin');";
                                    comando.ExecuteNonQuery();
                                    MessageBox.Show("Usuário cadastrado");
                                }
                            }
                            if (radioButtonUSUARIO.Checked)
                            {
                                conexao.Open();
                                comando.CommandText = "SELECT usuario FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "';";
                                MySqlDataReader nome = comando.ExecuteReader();

                                if (nome.Read())
                                {
                                    MessageBox.Show("Este usuario ja existe");
                                }
                                else
                                {
                                    conexao.Close();
                                    conexao.Open();
                                    comando.CommandText = "INSERT INTO tbl_usuarios(usuario, senha, permissao) VALUES ('" + textBoxUSUARIO.Text + "', '" + textBoxSENHA.Text + "', 'user');";
                                    comando.ExecuteNonQuery();
                                    MessageBox.Show("Usuário cadastrado");
                                }
                            }
                        }

                        else
                        {
                            MessageBox.Show("As senhas devem ser iguais");

                        }
                    }
                    else
                    {
                        MessageBox.Show("A senha requer mais que 8 caracteres");
                    }
                }
                else
                {
                    MessageBox.Show("CAMPOS INCOMPLETOS");
                }
                
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
