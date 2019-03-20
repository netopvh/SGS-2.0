using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGS.Modelo;


namespace SGS.Controle
{
    public class c_Loteamento
    {
        public string CarregarObra(m_Loteamento m_loteamento)
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
               "select obra from loteamento where idloteamento = @idloteamento;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idloteamento", m_loteamento.idloteamento));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetString(0);

            }
            conexao.Clone();
            return resultado;

        }
        public string CarregarEmpresa(m_Loteamento m_loteamento)
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
               "select empresa from loteamento where idloteamento = @idloteamento;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idloteamento", m_loteamento.idloteamento));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetString(0);

            }
            conexao.Clone();
            return resultado;

        }
        public DataTable CarregarLoteamentos()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from loteamento;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarLoteamento()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idloteamento,nome from loteamento;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarLoteamentosAtivos()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idloteamento,nome,empresa,obra from loteamento where status = 1;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarLoteamentoEmpresaObraConcatenado()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select concat(empresa,obra) AS EmpresaObra, nome from loteamento where status = 1;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarLoteamentoObra(string Obra)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idloteamento,nome,obra from loteamento where obra = "+Obra+";";
            //comando.Parameters.Add(new MySqlParameter("@obra", m_loteamento.obra));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public void NovoLoteamento(m_Loteamento m_loteamento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into loteamento(empresa,nome,obra,status,datacad,usuariocad) "+
                " values(@empresa, @nome, @obra, @status, @datacad, @usuariocad); ";
            comando.Parameters.Add(new MySqlParameter("@empresa", m_loteamento.empresa));
            comando.Parameters.Add(new MySqlParameter("@nome", m_loteamento.nome));
            comando.Parameters.Add(new MySqlParameter("@obra", m_loteamento.obra));
            comando.Parameters.Add(new MySqlParameter("@status", m_loteamento.status));
            comando.Parameters.Add(new MySqlParameter("@datacad", m_loteamento.datacad));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_loteamento.usuariocad));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void ExcluirLoteamento(m_Loteamento m_loteamento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from loteamento where idloteamento = @idloteamento;";
            comando.Parameters.Add(new MySqlParameter("@idloteamento", m_loteamento.idloteamento));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void AlterarLoteamento(m_Loteamento m_loteamento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update loteamento set empresa = @empresa,nome = @nome,obra = @obra,datacad = @datacad, status = @status,usuariocad = @usuariocad where idloteamento = @idloteamento;";
            comando.Parameters.Add(new MySqlParameter("@idloteamento", m_loteamento.idloteamento));
            comando.Parameters.Add(new MySqlParameter("@empresa", m_loteamento.empresa));
            comando.Parameters.Add(new MySqlParameter("@nome", m_loteamento.nome));
            comando.Parameters.Add(new MySqlParameter("@obra", m_loteamento.obra));
            comando.Parameters.Add(new MySqlParameter("@status", m_loteamento.status));
            comando.Parameters.Add(new MySqlParameter("@datacad", m_loteamento.datacad));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_loteamento.usuariocad));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }


    }
}
