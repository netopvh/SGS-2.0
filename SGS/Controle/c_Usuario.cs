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
    public class c_Usuario
    {
        public DataTable CarregarUsuarios()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from usuario;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
        }
        public DataTable CarregarUsuariosPermissao()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "SELECT usuario.idusuario,usuario.nome,usuario.login,usuario.senha,usuario.`status`,usuario.fk_permissao_usuario,permissao.idpermissao,permissao.nome,permissao.nivel FROM usuario INNER JOIN permissao ON usuario.fk_permissao_usuario = permissao.idpermissao;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
        }

        public bool AutenticarUsuario(string login, string senha)
        {
            bool resultado;
            
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from usuario where login  = '" + login + "'and senha = MD5('" + senha + "') and status = 1;";
                /*"select u.idusuario,u.login,u.senha,u.status,u.fk_permissao_usuario,p.idpermissao,p.nome,p.nivel from usuario as u inner join permissao as p on u.idusuario = p.idpermissao "+
                " where login = '"+login+"'and senha = MD5('"+senha+"') and status = 1;";*/
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            
            resultado = reader.HasRows;
            if (resultado == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void NovoUsuario(m_Usuario m_usuario)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into usuario(nome,login,senha,status,fk_permissao_usuario) values(@nome,@login,MD5(@senha),@status,@fk_permissao_usuario);";
            comando.Parameters.Add(new MySqlParameter("@nome", m_usuario.nome));
            comando.Parameters.Add(new MySqlParameter("@login", m_usuario.login));
            comando.Parameters.Add(new MySqlParameter("@senha", m_usuario.senha));
            comando.Parameters.Add(new MySqlParameter("@status", m_usuario.status));
            comando.Parameters.Add(new MySqlParameter("@fk_permissao_usuario", m_usuario.fk_permissao_usuario));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        
        public void ExcluirUsuario(m_Usuario m_usuario)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from usuario where idusuario = @idusuario;";
            comando.Parameters.Add(new MySqlParameter("@idusuario", m_usuario.idusuario));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        
        public void AlterarUsuario(m_Usuario m_usuario)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuario set nome = @nome,login = @login,senha = md5(@senha), status = @status,fk_permissao_usuario = @fk_permissao_usuario where idusuario = @idusuario;";
            comando.Parameters.Add(new MySqlParameter("@idusuario", m_usuario.idusuario));
            comando.Parameters.Add(new MySqlParameter("@nome", m_usuario.nome));
            comando.Parameters.Add(new MySqlParameter("@login", m_usuario.login));
            comando.Parameters.Add(new MySqlParameter("@senha", m_usuario.senha));
            comando.Parameters.Add(new MySqlParameter("@status", m_usuario.status));
            comando.Parameters.Add(new MySqlParameter("@fk_permissao_usuario", m_usuario.fk_permissao_usuario));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        

    }
}
