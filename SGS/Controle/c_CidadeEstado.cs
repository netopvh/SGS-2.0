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
    public class c_CidadeEstado
    {
        public DataTable GetCidadeEstadoConcatenado()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select concat(cidade.nomecidade, ' - ' , estado.uf)as 'CidadeEstado' from cidade inner join estado on cidade.fk_cidadeestado = estado.idestado order by cidade.nomecidade;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        
    }
}
