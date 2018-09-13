using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Controle
{
    public static class c_ConexaoMySql
    {
        public static MySqlConnection GetConexao()
        {
            MySqlConnection conexao = new
                MySqlConnection(ConfigurationManager.ConnectionStrings["SGS.Properties.Settings.dbsgsConnectionString"].ConnectionString);
            
            try
            {
                //início do código de criptografia
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var _cs = (ConnectionStringsSection)config.GetSection("connectionStrings");

                if (!_cs.SectionInformation.IsProtected)
                {
                    _cs.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    config.Save();
                }
                //fim do código de criptografia

                /*string Server = (ConfigurationManager.AppSettings["Server"]);
                string Database = (ConfigurationManager.AppSettings["DataBase"]);
                string Port = (ConfigurationManager.AppSettings["Port"]);*/
                /*MySqlConnection conexao = new
                    MySqlConnection(ConfigurationManager.ConnectionStrings["SGS.Properties.Settings.dbsgsConnectionString"].ConnectionString);*/
                
                conexao.Open();
                return conexao;
            }
            
            catch(MySql.Data.MySqlClient.MySqlException exc)
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados do sistema!\n" + exc.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Application.Exit();
                return conexao;
            }
            

        }
        public static MySqlCommand GetComando(MySqlConnection conexao)
        {
            
                MySqlCommand comando = conexao.CreateCommand();
                return comando;
            
        }
        public static MySqlDataReader GetDataReader(MySqlCommand comando)
        {
           
                return comando.ExecuteReader();
            
        }
        
    }
}
