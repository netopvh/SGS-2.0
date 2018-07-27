using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Controle
{
    public class c_Permissao
    {
        public int AutenticarPermissao(string login)
        {
            int resultado = 0;

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
               "select u.idusuario,u.login,u.status,u.fk_permissao_usuario,p.idpermissao,p.nome,p.nivel from usuario as u inner join permissao as p on u.idusuario = p.idpermissao "+
                "where login = '"+login+"' and status = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(6);
                
            }

            return resultado;
            
        }


    }
}
