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
    public class c_TempoAtendimento
    {
        public DataTable CarregarTemposAtendimentos()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from tempoatendimento;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
            
        }
        public int CarregarUltimaID_Inserida()
        {
            int resultado = 0;
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "SELECT idtempoatendimento from tempoatendimento ORDER BY idtempoatendimento DESC LIMIT 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            conexao.Clone();
            return resultado;
        }
        public void NovoTempoAtendimento(m_TempoAtendimento m_tempoAtendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into tempoatendimento(atendimentohorainicial,fk_plantao_tempoatendimento,fk_corretorplantao_tempoatendimento) values (@atendimentohorainicial,@fk_plantao_tempoatendimento,@fk_corretorplantao_tempoatendimento);";

            comando.Parameters.Add(new MySqlParameter("@atendimentohorainicial", m_tempoAtendimento.atendimentohorainicial));
            comando.Parameters.Add(new MySqlParameter("@fk_corretorplantao_tempoatendimento", m_tempoAtendimento.fk_corretorplantao_tempoatendimento));
            comando.Parameters.Add(new MySqlParameter("@fk_plantao_tempoatendimento", m_tempoAtendimento.fk_plantao_tempoatendimento));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void ExcluirTempoAtendimento(m_TempoAtendimento m_tempoAtendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from tempoatendimento where idtempoatendimento = @idtempoatendimento;";
            comando.Parameters.Add(new MySqlParameter("@idtempoatendimento", m_tempoAtendimento.idtempoatendimento));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void AlterarAtendimentoHoraFinal(m_TempoAtendimento m_tempoAtendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update tempoatendimento set atendimentohorafinal = @atendimentohorafinal where idtempoatendimento = @idtempoatendimento;";
            
            comando.Parameters.Add(new MySqlParameter("@idtempoatendimento", m_tempoAtendimento.idtempoatendimento));
            comando.Parameters.Add(new MySqlParameter("@atendimentohorafinal", m_tempoAtendimento.atendimentohorafinal));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }


    }

}
