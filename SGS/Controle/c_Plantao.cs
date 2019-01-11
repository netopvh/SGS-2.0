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
    public class c_Plantao
    {
        public DataTable CarregarPlantoes()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from plantao;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
        }
        public DataTable CarregarPlantoesCorretores()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "SELECT plantao.idplantao,plantao.equipe,plantao.dataplantao,plantao.horainicial,plantao.horafinal,plantao.tempoporpessoa,plantao.usuariocad,corretorplantao.idcorretorplantao,corretorplantao.posicao,corretorplantao.nomecorretor,corretorplantao.fk_plantao_corretorplantao FROM plantao INNER JOIN corretorplantao ON corretorplantao.fk_plantao_corretorplantao = plantao.idplantao;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;
        }
        public int CarregarUltimaIDPlantao()
        {
            int resultado = 0;
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "SELECT idplantao from plantao ORDER BY idplantao DESC LIMIT 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            conexao.Clone();
            return resultado;
        }
        public string CarregarNomeEquipePlantao(m_Plantao m_plantao)
        {
            string resultado = "";
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select equipe from plantao where idplantao = @idplantao;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idplantao", m_plantao.idplantao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            conexao.Clone();
            return resultado;
        }
        public TimeSpan CarregarTempoPorPessoa(m_Plantao m_plantao)
        {
            TimeSpan resultado = new TimeSpan(0, 0, 0);
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select tempoporpessoa from plantao where idplantao = @idplantao;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idplantao", m_plantao.idplantao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetTimeSpan(0);
            }
            conexao.Clone();
            return resultado;
        }
        public TimeSpan CarregarTempoFinalPlantao(m_Plantao m_plantao)
        {
            TimeSpan resultado = new TimeSpan(0, 0, 0);
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select horafinal from plantao where idplantao = @idplantao;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idplantao", m_plantao.idplantao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetTimeSpan(0);
            }
            conexao.Clone();
            return resultado;
        }
        public void NovoPlantao(m_Plantao m_plantao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into plantao(equipe,dataplantao,horainicial,horafinal,tempoporpessoa,usuariocad) values (@equipe,@dataplantao,@horainicial,@horafinal,@tempoporpessoa,@usuariocad);";

            comando.Parameters.Add(new MySqlParameter("@equipe", m_plantao.equipe));
            comando.Parameters.Add(new MySqlParameter("@dataplantao", m_plantao.dataplantao));
            comando.Parameters.Add(new MySqlParameter("@horainicial", m_plantao.horainicial));
            comando.Parameters.Add(new MySqlParameter("@horafinal", m_plantao.horafinal));
            comando.Parameters.Add(new MySqlParameter("@tempoporpessoa", m_plantao.tempoporpessoa));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_plantao.usuariocad));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        public void ExcluirPlantao(m_Plantao m_plantao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from plantao where idplantao = @idplantao;";
            comando.Parameters.Add(new MySqlParameter("@idplantao", m_plantao.idplantao));
            comando.ExecuteNonQuery();
            conexao.Clone();
        }
        /*public void AlterarPlantao(m_Plantao m_plantao)
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
