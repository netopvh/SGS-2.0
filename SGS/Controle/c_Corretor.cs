using MySql.Data.MySqlClient;
using SGS.Modelo;
using SGS.Controle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Controle
{
    public class c_Corretor
    {
        public void NovoCorretor(m_Corretor m_corretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into corretor(nome,cpf,email,telefone,status,usuariocad) values(@nome,@cpf,@email,@telefone,@status,@usuariocad);";
            comando.Parameters.Add(new MySqlParameter("@nome", m_corretor.nome));
            comando.Parameters.Add(new MySqlParameter("@cpf", m_corretor.cpf));
            comando.Parameters.Add(new MySqlParameter("@email", m_corretor.email));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_corretor.telefone));
            comando.Parameters.Add(new MySqlParameter("@status", m_corretor.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_corretor.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void ExcluirCorretor(m_Corretor m_corretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from corretor where idcorretor = @idcorretor;";
            comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
            comando.ExecuteNonQuery();
        }
        public void AlterarCorretor(m_Corretor m_corretor)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update corretor set nome = @nome,cpf = @cpf,email = @email, telefone = @telefone, status = @status,usuariocad = @usuariocad where idcorretor = @idcorretor;";
            comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
            comando.Parameters.Add(new MySqlParameter("@nome", m_corretor.nome));
            comando.Parameters.Add(new MySqlParameter("@cpf", m_corretor.cpf));
            comando.Parameters.Add(new MySqlParameter("@email", m_corretor.email));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_corretor.telefone));
            comando.Parameters.Add(new MySqlParameter("@status", m_corretor.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_corretor.usuariocad));
            comando.ExecuteNonQuery();
        }
    }
}
