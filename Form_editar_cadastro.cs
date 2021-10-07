using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace pagina_inicio
{
    public partial class Form_editar_cadastro : Form
    {
        Conexao conexao = new Conexao(); // referencia da classe de conexão
        MySqlCommand execute = new MySqlCommand(); // classe de comando do sql
        MySqlDataReader exibir; //classe de comando sql para acesso e exibição de dados
        string tipo_pessoa, sexo;
        public Form_editar_cadastro()
        {
            InitializeComponent();
        }
        private void Form_editar_cadastro_Load(object sender, EventArgs e)
        {
        }
        private void btn_exibir_Click(object sender, EventArgs e)
        {
            execute.CommandText = "SELECT* FROM FORM_CADASTRO_CLIENTE WHERE cod_cliente = '" + cod_cliente.Text + "' "; // minha classe recebe o comando sql   
            try
            {
                execute.Connection = conexao.Conectar(); //comando slq executa a classe de conexão contendo a string para conectar ao banco                                     
                exibir = execute.ExecuteReader(); // executo o comando da classe criado para a função do sistema
                while (exibir.Read())
                {
                    tipo_pessoa = Convert.ToString(exibir["tipo_pessoa"]);
                    cpf.Text = Convert.ToString(exibir["cpf"]);
                    cnpj.Text = Convert.ToString(exibir["cnpj"]);
                    nome.Text = Convert.ToString(exibir["nome"]);
                    sexo = Convert.ToString(exibir["sexo"]);
                    sobrenome.Text = Convert.ToString(exibir["sobrenome"]);
                    data_nasc.Text = Convert.ToString(exibir["data_nasc"]);
                    EMAIL.Text = Convert.ToString(exibir["email"]);
                    rua.Text = Convert.ToString(exibir["rua"]);
                    num.Text = Convert.ToString(exibir["num"]);
                    cep.Text = Convert.ToString(exibir["cep"]);
                    complemento.Text = Convert.ToString(exibir["complemento"]);
                    bairro.Text = Convert.ToString(exibir["bairro"]);
                    cidade.Text = Convert.ToString(exibir["cidade"]);
                    estado.Text = Convert.ToString(exibir["estado"]);
                    limite_cred.Text = Convert.ToString(exibir["limite_cred"]);
                    informacoes.Text = Convert.ToString(exibir["informacoes"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar(); // encerro a conexão com o banco                
            }
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            execute.CommandText = "UPDATE FORM_CADASTRO_CLIENTE SET tipo_pessoa = '" + tipo_pessoa + "', cpf = '" + cpf.Text + "', cnpj = '" + cnpj.Text + "', nome = '" + nome.Text + "'," +
               "sexo = '" + sexo + "', sobrenome = '" + sobrenome.Text + "', data_nasc = '" + data_nasc.Text + "', email = '" + EMAIL.Text + "', rua = '" + rua.Text + "', num = '" + num.Text + "'," +
               "cep = '" + cep.Text + "', complemento = '" + complemento.Text + "', bairro = '" + bairro.Text + "', cidade = '" + cidade.Text + "',estado = '" + estado.Text + "'," +
               " limite_cred = '" + limite_cred.Text + "', informacoes = '" + informacoes.Text + "' WHERE cod_cliente = '" + cod_cliente.Text + "' "; // minha classe recebe o comando de update sql   
            try
            {
                execute.Connection = conexao.Conectar(); //comando slq executa a classe de conexão contendo a string para conectar ao banco 
                execute.ExecuteNonQuery(); // executo o comando da classe criado para a função do sistema
                MessageBox.Show("CADASTRO EDITADO COM SUCESSO!");
                limpardados();  // função criada para limpar box depois da operação           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar(); // encerro a conexão com o banco                  
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            execute.CommandText = "DELETE FROM FORM_CADASTRO_CLIENTE WHERE cod_cliente = '" + cod_cliente.Text + "' "; // minha classe recebe o comando sql  
            try
            {
                execute.Connection = conexao.Conectar();  //comando slq executa a classe de conexão para conectar ao banco
                execute.ExecuteNonQuery(); // executo o comando criado para a função do sistema    
                MessageBox.Show("CADASTRO EXCLUIDO COM SUCESSO!");
                limpardados(); // função criada para limpar box depois da operação
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Desconectar(); // encerro a conexão com o banco   
            }
        }
        private void pessoa_fisica_CheckedChanged(object sender, EventArgs e)
        {
            tipo_pessoa = "Pessoa Fisica";
        }
        private void pessoa_juridica_CheckedChanged(object sender, EventArgs e)
        {
            tipo_pessoa = "Pessoa Jurica";
        }
        private void checkboxsexo_m_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }
        private void checkboxsexo_f_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }
        private void limpardados()
        {
            cod_cliente.Clear();
            cpf.Clear();
            cnpj.Clear();
            nome.Clear();
            sobrenome.Clear();
            data_nasc.Clear();
            EMAIL.Clear();
            rua.Clear();
            num.Clear();
            cep.Clear();
            complemento.Clear();
            bairro.Clear();
            cidade.Clear();
            estado.Clear();
            limite_cred.Clear();
            informacoes.Clear();
            checkboxsexo_m.Checked = false;
            checkboxsexo_f.Checked = false;
            pessoa_fisica.Checked = false;
            pessoa_juridica.Checked = false;
        }
    }    
}