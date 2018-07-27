using MySql.Data.MySqlClient;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Controle
{
    public class c_Empresalicenca
    {
        public string AutenticarLicencaMD5()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from empresalicenca where idempresalicenca  = 1";
            
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(3);
            }
            return resultado;
            
        }
        public string AutenticarKey1()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select key1 from empresalicenca where idempresalicenca  = 1;";

            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            return resultado;
        }
        public string AutenticarKey2()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select key2 from empresalicenca where idempresalicenca  = 1;";

            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            return resultado;
        }
        public string CarregarNomeEmpresa()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from empresalicenca where idempresalicenca = 1;";

            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(1);
            }
            return resultado;

        }
        public byte[] CarrregarLogoMarca()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select logomarca from empresalicenca where idempresalicenca = 1;";
            comando.CommandType = CommandType.Text;
            return (byte[])comando.ExecuteScalar();
        }
        public void PrimeiraEmpresaLicenca(m_EmpresaLicenca m_empresalicenca)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into empresalicenca(idempresalicenca,nomeEmpresa,logomarca,keymd5,key1,key2) values(1,@nomeEmpresa,@logomarca,@keymd5,@key1,@key2);";
            comando.Parameters.Add(new MySqlParameter("@nomeEmpresa", m_empresalicenca.nomeEmpresa));
            comando.Parameters.Add(new MySqlParameter("@logomarca", m_empresalicenca.logomarca));
            comando.Parameters.Add(new MySqlParameter("@keymd5",m_empresalicenca.keyMD5));
            comando.Parameters.Add(new MySqlParameter("@key1", m_empresalicenca.key1));
            comando.Parameters.Add(new MySqlParameter("@key2", m_empresalicenca.key2));
            comando.ExecuteNonQuery();
        }
        public void AlterarEmpresaLicenca(m_EmpresaLicenca m_empresalicenca)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update empresalicenca set nomeEmpresa = @nomeEmpresa, logomarca = @logomarca, keymd5 = @keymd5, key1 = @key1, key2 = @key2 where idempresalicenca = 1;";
            comando.Parameters.Add(new MySqlParameter("@nomeEmpresa", m_empresalicenca.nomeEmpresa));
            comando.Parameters.Add(new MySqlParameter("@logomarca", m_empresalicenca.logomarca));
            comando.Parameters.Add(new MySqlParameter("@keymd5", m_empresalicenca.keyMD5));
            comando.Parameters.Add(new MySqlParameter("@key1", m_empresalicenca.key1));
            comando.Parameters.Add(new MySqlParameter("@key2", m_empresalicenca.key2));
            comando.ExecuteNonQuery();
        }
        public void AtualizarKeysVencidadas(m_EmpresaLicenca m_empresalicenca)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update empresalicenca set keymd5 = @keymd5, key1 = @key1, key2 = @key2 where idempresalicenca = 1;";
            
            comando.Parameters.Add(new MySqlParameter("@keymd5", m_empresalicenca.keyMD5));
            comando.Parameters.Add(new MySqlParameter("@key1", m_empresalicenca.key1));
            comando.Parameters.Add(new MySqlParameter("@key2", m_empresalicenca.key2));
            comando.ExecuteNonQuery();
        }
        public void ExcluirEmpresaLicenca()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from empresalicenca where idempresalicenca = 1";
            comando.ExecuteNonQuery();


        }


    }
}
