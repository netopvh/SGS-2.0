using MySql.Data.MySqlClient;
using SGS.Modelo;
using SGS.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SGS.Controle
{
    public class c_Corretor
    {
        public DataTable CarregarCorretores()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from corretor;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarCorretor()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idcorretor,nome from corretor;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public string GetEmailCorretor(m_Corretor m_corretor)
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select email from corretor where idcorretor = @idcorretor;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            conexao.Clone();
            return resultado;

        }
        public void NovoCorretor(m_Corretor m_corretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into corretor(nome,cpf,email,telefone,status,usuariocad,fk_corretor_empresacorretor) values(@nome,@cpf,@email,@telefone,@status,@usuariocad,@fk_corretor_empresacorretor);";
            comando.Parameters.Add(new MySqlParameter("@nome", m_corretor.nome));
            comando.Parameters.Add(new MySqlParameter("@cpf", m_corretor.cpf));
            comando.Parameters.Add(new MySqlParameter("@email", m_corretor.email));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_corretor.telefone));
            comando.Parameters.Add(new MySqlParameter("@status", m_corretor.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_corretor.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_empresacorretor", m_corretor.fk_corretor_empresacorretor));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void ExcluirCorretor(m_Corretor m_corretor)
        {
            try
            {
                MySqlConnection conexao = c_ConexaoMySql.GetConexao();
                MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText =
                    "delete from corretor where idcorretor = @idcorretor;";
                comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
                comando.ExecuteNonQuery();
                conexao.Clone();
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {
                MessageBox.Show("Error:"+mex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void AlterarCorretor(m_Corretor m_corretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update corretor set nome = @nome,cpf = @cpf,email = @email, telefone = @telefone, status = @status,usuariocad = @usuariocad, fk_corretor_empresacorretor = @fk_corretor_empresacorretor where idcorretor = @idcorretor;";
            comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
            comando.Parameters.Add(new MySqlParameter("@nome", m_corretor.nome));
            comando.Parameters.Add(new MySqlParameter("@cpf", m_corretor.cpf));
            comando.Parameters.Add(new MySqlParameter("@email", m_corretor.email));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_corretor.telefone));
            comando.Parameters.Add(new MySqlParameter("@status", m_corretor.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_corretor.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_empresacorretor", m_corretor.fk_corretor_empresacorretor));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
    }
}
