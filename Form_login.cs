using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace pagina_inicio
{
    public partial class Form_login : Form
    {
        Conexao conexao = new Conexao();
        MySqlCommand execute = new MySqlCommand();
        MySqlDataAdapter consultar;
        public Form_login()
        {
            InitializeComponent();
        }
        private void Form_login_Load(object sender, EventArgs e)
        {

        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            globais.nomelog = nome_log.Text;
            globais.senhalog = senha_log.Text;

            if (globais.nomelog == "" || globais.senhalog == "")
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE");
                nome_log.Focus();
                return;
            }

            execute.CommandText = "SELECT * FROM FORM_LOGIN WHERE nomelog= '" + globais.nomelog + "' AND senhalog= '" + globais.senhalog + "' ";
            try
            {
                execute.Connection = conexao.Conectar();
                consultar = new MySqlDataAdapter(execute.CommandText, execute.Connection);
                DataTable dt = new DataTable();
                consultar.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    globais.nivel = dt.Rows[0].ItemArray[2].ToString();
                    Close();
                }
                else
                {
                    MessageBox.Show("USUARIO OU SENHA INCORRETOS");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            nome_log.Clear();
            senha_log.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    class globais
    {
        public static string nivel, nomelog, senhalog;
    }
}