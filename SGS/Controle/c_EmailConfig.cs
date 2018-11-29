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
    public class c_EmailConfig
    {
        public string GetSMTpEmail()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(5);
            }
            return resultado;

        }
        public string GetSMTPSenhaEmail()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(6);
            }
            return resultado;

        }
        public string GetSMTPHost()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(1);
            }
            return resultado;

        }
        public string GetSMTPPorta()
        {
            string resultado = "";

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetString(2);
            }
            return resultado;

        }
        public bool GetSMTPSSL()
        {
            bool resultado = false;

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetBoolean(3);
            }
            return resultado;

        }
        public bool GetSMTPCredencialPadrao()
        {
            bool resultado = false;

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select * from emailconfig where idemailconfig = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);

            while (reader.Read())
            {
                resultado = reader.GetBoolean(4);
            }
            return resultado;

        }
        public void PrimeiraConfigEmail(m_EmailConfig m_emailConfig)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into emailconfig(idemailconfig,smtpcredencialpadrao,smtpemail,smtphost,smtpporta,smtpsenhaemail,smtpssl) values(1,@smtpcredencialpadrao,@smtpemail,@smtphost,@smtpporta,@smtpsenhaemail,@smtpssl);";
            comando.Parameters.Add(new MySqlParameter("@smtpcredencialpadrao", m_emailConfig.smtpcredencialpadrao));
            comando.Parameters.Add(new MySqlParameter("@smtpemail", m_emailConfig.smtpemail));
            comando.Parameters.Add(new MySqlParameter("@smtphost", m_emailConfig.smtphost));
            comando.Parameters.Add(new MySqlParameter("@smtpporta", m_emailConfig.smtpporta));
            comando.Parameters.Add(new MySqlParameter("@smtpsenhaemail", m_emailConfig.smtpsenhaemail));
            comando.Parameters.Add(new MySqlParameter("@smtpssl", m_emailConfig.smtpssl));
            comando.ExecuteNonQuery();
        }
        public void AlterarConfigEmail(m_EmailConfig m_emailConfig)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update emailconfig set smtpcredencialpadrao = @smtpcredencialpadrao,smtpemail = @smtpemail, smtphost = @smtphost, smtpporta = @smtpporta, smtpsenhaemail = @smtpsenhaemail, smtpssl = @smtpssl where idemailconfig = 1;";
            comando.Parameters.Add(new MySqlParameter("@smtpcredencialpadrao", m_emailConfig.smtpcredencialpadrao));
            comando.Parameters.Add(new MySqlParameter("@smtpemail", m_emailConfig.smtpemail));
            comando.Parameters.Add(new MySqlParameter("@smtphost", m_emailConfig.smtphost));
            comando.Parameters.Add(new MySqlParameter("@smtpporta", m_emailConfig.smtpporta));
            comando.Parameters.Add(new MySqlParameter("@smtpsenhaemail", m_emailConfig.smtpsenhaemail));
            comando.Parameters.Add(new MySqlParameter("@smtpssl", m_emailConfig.smtpssl));
            comando.ExecuteNonQuery();
        }
        public void ExcluirConfigEmail()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from emailconfig where idemailconfig = 1";
            comando.ExecuteNonQuery();
        }
    }
}
