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
    public class c_Atendimento
    {
        public DataTable GetAtendimento()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from atendimento;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public DataTable GetAtendimento(m_Atendimento m_atendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from atendimento where idatendimento = @idatendimento;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idatendimento", m_atendimento.idatendimento));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void NovoAtendimento(m_Atendimento m_atendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into atendimento(nomecliente,telefone,cidadeuf,atendimentoanterior,identificador,localizou,comprou,corretoratual,dataatendimento,datacompra,empreendimento,usuariocad) " +
            "values(@nomecliente, @telefone, @cidadeuf, @atendimentoanterior, @identificador, @localizou, @comprou, @corretoratual, @dataatendimento, @datacompra,@empreendimento,@usuariocad); ";
            comando.Parameters.Add(new MySqlParameter("@nomecliente", m_atendimento.nomeCliente));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_atendimento.telefone));
            comando.Parameters.Add(new MySqlParameter("@cidadeuf", m_atendimento.cidadeUF));
            comando.Parameters.Add(new MySqlParameter("@atendimentoanterior", m_atendimento.atendimentoAnterior));
            comando.Parameters.Add(new MySqlParameter("@identificador", m_atendimento.identificador));
            comando.Parameters.Add(new MySqlParameter("@localizou", m_atendimento.localizou));
            comando.Parameters.Add(new MySqlParameter("@comprou", m_atendimento.comprou));
            comando.Parameters.Add(new MySqlParameter("@corretoratual", m_atendimento.corretorAtual));
            comando.Parameters.Add(new MySqlParameter("@empreendimento", m_atendimento.empreendimento));
            comando.Parameters.Add(new MySqlParameter("@dataatendimento", m_atendimento.dataAtendimento));
            comando.Parameters.Add(new MySqlParameter("@datacompra", m_atendimento.dataCompra));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_atendimento.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void AlterarAtendimento(m_Atendimento m_atendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update atendimento set nomeCliente = @nomecliente,telefone = @telefone,cidadeuf = @cidadeuf,atendimentoAnterior = @atendimentoanterior,identificador = @identificador,localizou = @localizou,comprou = @comprou,corretorAtual = @corretoratual,dataAtendimento = @dataatendimento,dataCompra = @datacompra,empreendimento = @empreendimento, usuariocad = @usuariocad where idatendimento = @idatendimento;";
            comando.Parameters.Add(new MySqlParameter("@idatendimento", m_atendimento.idatendimento));
            comando.Parameters.Add(new MySqlParameter("@nomecliente", m_atendimento.nomeCliente));
            comando.Parameters.Add(new MySqlParameter("@telefone", m_atendimento.telefone));
            comando.Parameters.Add(new MySqlParameter("@cidadeuf", m_atendimento.cidadeUF));
            comando.Parameters.Add(new MySqlParameter("@atendimentoanterior", m_atendimento.atendimentoAnterior));
            comando.Parameters.Add(new MySqlParameter("@identificador", m_atendimento.identificador));
            comando.Parameters.Add(new MySqlParameter("@localizou", m_atendimento.localizou));
            comando.Parameters.Add(new MySqlParameter("@comprou", m_atendimento.comprou));
            comando.Parameters.Add(new MySqlParameter("@corretoratual", m_atendimento.corretorAtual));
            comando.Parameters.Add(new MySqlParameter("@empreendimento", m_atendimento.empreendimento));
            comando.Parameters.Add(new MySqlParameter("@dataatendimento", m_atendimento.dataAtendimento));
            comando.Parameters.Add(new MySqlParameter("@datacompra", m_atendimento.dataCompra));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_atendimento.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void AlterarAtendimentoParaComprou(m_Atendimento m_atendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update atendimento set comprou = @comprou,datacompra = @datacompra, usuariocad = @usuariocad where idatendimento = @idatendimento;";
            comando.Parameters.Add(new MySqlParameter("@idatendimento", m_atendimento.idatendimento));
            comando.Parameters.Add(new MySqlParameter("@comprou", m_atendimento.comprou));
            comando.Parameters.Add(new MySqlParameter("@datacompra", m_atendimento.dataCompra));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_atendimento.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void ExcluirAtendimento(m_Atendimento m_atendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from atendimento where idatendimento = @idatendimento;";
            comando.Parameters.Add(new MySqlParameter("@idatendimento", m_atendimento.idatendimento));
            comando.ExecuteNonQuery();
        }

    }
}
