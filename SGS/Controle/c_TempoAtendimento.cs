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
            return dataTable;
        }

        public void NovoTempoAtendimento(m_TempoAtendimento m_tempoAtendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into tempoatendimento(atendimentohorainicial,atendimentohorafinal,corretordavez,fk_plantao_tempoatendimento) values (@atendimentohorainicial,@atendimentohorafinal,@corretordavez,@fk_plantao_tempoatendimento);";

            comando.Parameters.Add(new MySqlParameter("@atendimentohorainicial", m_tempoAtendimento.atendimentohorainicial));
            comando.Parameters.Add(new MySqlParameter("@atendimentohorafinal", m_tempoAtendimento.atendimentohorafinal));
            comando.Parameters.Add(new MySqlParameter("@corretordavez", m_tempoAtendimento.corretordavez));
            comando.Parameters.Add(new MySqlParameter("@fk_plantao_tempoatendimento", m_tempoAtendimento.fk_plantao_tempoatendimento));
            comando.ExecuteNonQuery();
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
        }
        /*public void AlterarDataPagmentoComissao(m_TempoAtendimento m_tempoAtendimento)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update comissoes set datapagamentocomissao = @datapagamentocomissao  where idcomissoes = @idcomissoes;";
            comando.Parameters.Add(new MySqlParameter("@idcomissoes", m_comissoes.idcomissoes));
            comando.Parameters.Add(new MySqlParameter("@datapagamentocomissao", m_comissoes.datapagamentocomissao));
            comando.ExecuteNonQuery();
        }*/


    }

}
