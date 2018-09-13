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
    public class c_Ftpconfig
    {
        public DataTable CarregarFtpConfig(string ComandoSQL)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = ComandoSQL;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

        }
        public string CarregarSenhaFTP()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select senhaftp from ftpconfig where idftpconfig = 1;";
            return comando.ExecuteScalar().ToString();
            
        }
        public void NovoFtpConfig(m_Ftpconfig m_FtpConfig)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into ftpconfig(idftpconfig,remotoversao,remotosetup,localsetuparquivo,usuarioftp,senhaftp) values(@idftpconfig,@remotoversao,@remotosetup,@localsetuparquivo,@usuarioftp,@senhaftp);";
            comando.Parameters.Add(new MySqlParameter("@idftpconfig", m_FtpConfig.idftpconfig));
            comando.Parameters.Add(new MySqlParameter("@localsetuparquivo", m_FtpConfig.localsetuparquivo));
            comando.Parameters.Add(new MySqlParameter("@remotosetup", m_FtpConfig.remotosetup));
            comando.Parameters.Add(new MySqlParameter("@remotoversao", m_FtpConfig.remotoversao));
            comando.Parameters.Add(new MySqlParameter("@usuarioftp", m_FtpConfig.usuarioftp));
            comando.Parameters.Add(new MySqlParameter("@senhaftp", m_FtpConfig.senhaftp));
            comando.ExecuteNonQuery();
        }
        public void ExcluirFtpConfig(m_Ftpconfig m_FtpConfig)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from ftpconfig where idftpconfig = @idftpconfig;";
            comando.Parameters.Add(new MySqlParameter("@idftpconfig", m_FtpConfig.idftpconfig));
            comando.ExecuteNonQuery();
        }
        public void AlterarFtpConfig(m_Ftpconfig m_FtpConfig)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update ftpconfig set localsetuparquivo = @localsetuparquivo, remotosetup = @remotosetup, remotoversao = @remotoversao, usuarioftp = @usuarioftp, senhaftp = @senhaftp  where idftpconfig = @idftpconfig";
            comando.Parameters.Add(new MySqlParameter("@idftpconfig", m_FtpConfig.idftpconfig));
            comando.Parameters.Add(new MySqlParameter("@localsetuparquivo", m_FtpConfig.localsetuparquivo));
            comando.Parameters.Add(new MySqlParameter("@remotosetup", m_FtpConfig.remotosetup));
            comando.Parameters.Add(new MySqlParameter("@remotoversao", m_FtpConfig.remotoversao));
            comando.Parameters.Add(new MySqlParameter("@usuarioftp", m_FtpConfig.usuarioftp));
            comando.Parameters.Add(new MySqlParameter("@senhaftp", m_FtpConfig.senhaftp));
            comando.ExecuteNonQuery();
        }


    }
}
