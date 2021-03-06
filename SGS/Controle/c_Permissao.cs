﻿using MySql.Data.MySqlClient;
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
        public DataTable CarregarPermissao()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from permissao;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
        }
        public int AutenticarPermissao(string login)
        {
            int resultado = 0;

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
               "select usuario.idusuario,usuario.login,usuario.status,usuario.fk_permissao_usuario,permissao.idpermissao,permissao.nome,permissao.nivel from usuario inner join permissao on usuario.fk_permissao_usuario = permissao.idpermissao where usuario.login = '"+login+"' and usuario.status = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(6);
                
            }
            conexao.Clone();
            return resultado;
            
        }


    }
}
