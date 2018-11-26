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
    public class c_EstruturaComissao
    {
        public DataTable CarregarEstruturasComissoes()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from estruturacomissao;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

        }
        public decimal CarregarPorcentagenImob(m_EstruturaComissao m_estruturaComissao)
        {
            decimal resultado = 0;
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select porcentagemimob from estruturacomissao where idestruturacomissao = @idestruturacomissao and status = 1;";
            comando.Parameters.Add(new MySqlParameter("@idestruturacomissao", m_estruturaComissao.idestruturacomissao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetDecimal(0);

            }
            return resultado;

        }
        public decimal CarregarPorcentagenCorretor(m_EstruturaComissao m_estruturaComissao)
        {
            decimal resultado = 0;
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select porcentagemcorretor from estruturacomissao where idestruturacomissao = @idestruturacomissao and status = 1;";
            comando.Parameters.Add(new MySqlParameter("@idestruturacomissao", m_estruturaComissao.idestruturacomissao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetDecimal(0);

            }
            return resultado;

        }
        public void NovaEstruturaComissao(m_EstruturaComissao m_estruturaComissao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into estruturacomissao(descricao,porcentagemimob,porcentagemcorretor,status,usuariocad) values(@descricao,@porcentagemimob,@porcentagemcorretor,@status,@usuariocad);";
            comando.Parameters.Add(new MySqlParameter("@descricao", m_estruturaComissao.descricao));
            comando.Parameters.Add(new MySqlParameter("@porcentagemimob", m_estruturaComissao.porcentagemimob));
            comando.Parameters.Add(new MySqlParameter("@porcentagemcorretor", m_estruturaComissao.porcentagemcorretor));
            comando.Parameters.Add(new MySqlParameter("@status", m_estruturaComissao.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_estruturaComissao.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void ExcluirEstruturaComissao(m_EstruturaComissao m_estruturaComissao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from estruturacomissao where idestruturacomissao = @idestruturacomissao;";
            comando.Parameters.Add(new MySqlParameter("@idestruturacomissao", m_estruturaComissao.idestruturacomissao));
            comando.ExecuteNonQuery();
        }
        public void AlterarEstruturaComissao(m_EstruturaComissao m_estruturaComissao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update estruturacomissao set descricao = @descricao,porcentagemimob = @porcentagemimob,porcentagemcorretor = @porcentagemcorretor, status = @status,usuariocad = @usuariocad where idestruturacomissao = @idestruturacomissao;";
            comando.Parameters.Add(new MySqlParameter("@idestruturacomissao", m_estruturaComissao.idestruturacomissao));
            comando.Parameters.Add(new MySqlParameter("@descricao", m_estruturaComissao.descricao));
            comando.Parameters.Add(new MySqlParameter("@porcentagemimob", m_estruturaComissao.porcentagemimob));
            comando.Parameters.Add(new MySqlParameter("@porcentagemcorretor", m_estruturaComissao.porcentagemcorretor));
            comando.Parameters.Add(new MySqlParameter("@status", m_estruturaComissao.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_estruturaComissao.usuariocad));
            comando.ExecuteNonQuery();
        }
    }
}
