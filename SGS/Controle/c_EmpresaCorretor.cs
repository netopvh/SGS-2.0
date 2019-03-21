using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.Modelo;
namespace SGS.Controle
{
    public class c_EmpresaCorretor
    {

        public DataTable CarregarEmpresaCorretores()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from empresacorretor;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarEmpresaCorretor()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idempresacorretor,nomeempresa from empresacorretor;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarCorretorEmpresa()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT corretor.idcorretor,corretor.nome,corretor.cpf,corretor.email,corretor.telefone,corretor.status,corretor.creci,corretor.usuariocad,corretor.fk_corretor_empresacorretor,empresacorretor.idempresacorretor,empresacorretor.nomeempresa from corretor inner join empresacorretor on corretor.fk_corretor_empresacorretor = empresacorretor.idempresacorretor;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }

        public void NovoEmpresaCorretor(m_EmpresaCorretor m_empresaCorretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into empresacorretor(nomeempresa,status,usuariocad,crecijuridico,cnpj,datacadastro) values(@nomeempresa,@status,@usuariocad,@crecijuridico,@cnpj,@datacadastro);";
            comando.Parameters.Add(new MySqlParameter("@nomeempresa", m_empresaCorretor.nomeempresa));
            comando.Parameters.Add(new MySqlParameter("@status", m_empresaCorretor.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_empresaCorretor.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@crecijuridico", m_empresaCorretor.crecijuridico));
            comando.Parameters.Add(new MySqlParameter("@cnpj", m_empresaCorretor.cnpj));
            comando.Parameters.Add(new MySqlParameter("@datacadastro", m_empresaCorretor.datacadastro));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void ExcluirEmpresaCorretor(m_EmpresaCorretor m_empresaCorretor)
        {
            
                MySqlConnection conexao = c_ConexaoMySql.GetConexao();
                MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText =
                    "delete from empresacorretor where idempresacorretor = @idempresacorretor;";
                comando.Parameters.Add(new MySqlParameter("@idempresacorretor", m_empresaCorretor.idempresacorretor));
                comando.ExecuteNonQuery();
                conexao.Clone();
            
        }
        public void AlterarEmpresaCorretor(m_EmpresaCorretor m_empresaCorretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update empresacorretor set nomeempresa = @nomeempresa,status = @status, crecijuridico = @crecijuridico,cnpj = @cnpj where idempresacorretor = @idempresacorretor;";
            comando.Parameters.Add(new MySqlParameter("@idempresacorretor", m_empresaCorretor.idempresacorretor));
            comando.Parameters.Add(new MySqlParameter("@nomeempresa", m_empresaCorretor.nomeempresa));
            comando.Parameters.Add(new MySqlParameter("@status", m_empresaCorretor.status));
            comando.Parameters.Add(new MySqlParameter("@crecijuridico", m_empresaCorretor.crecijuridico));
            comando.Parameters.Add(new MySqlParameter("@cnpj", m_empresaCorretor.cnpj));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
    }
}
