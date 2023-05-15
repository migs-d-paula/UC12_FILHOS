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
    public partial class FormLOGIN : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormLOGIN()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=login_db;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT usuario, senha FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {

                    conexao.Close();

                    conexao.Open();
                    comando.CommandText = "SELECT permissao FROM tbl_usuarios WHERE usuario = '" + textBoxUSUARIO.Text + "' AND permissao = 'admin';";
                    MySqlDataReader resposta = comando.ExecuteReader();

                    if (resposta.Read())
                    {
                        //vendo se é admin ou user
                        ClassVARIAVEIS.usuario = textBoxUSUARIO.Text;

                        ClassVARIAVEIS.permissao = "admin";

                        Form telaPRINCIPAL = new FormPRINCIPAL();
                        telaPRINCIPAL.Show();
                    }
                    else
                    {
                        //vendo se é admin ou user
                        ClassVARIAVEIS.usuario = textBoxUSUARIO.Text;

                        ClassVARIAVEIS.permissao = "user";

                        Form telaPRINCIPAL = new FormPRINCIPAL();
                        telaPRINCIPAL.Show();
                    }

                    
                }
                else
                {
                    MessageBox.Show("Usuario e/ou senha incorretos");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
