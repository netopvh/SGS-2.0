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
    public class c_DistribuicaoFolhasAvulsas
    {
        public DataTable CarregarDistribuicoes()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT distribuicaofolhasavulsas.iddistribuicaofolhasavulsas,distribuicaofolhasavulsas.folhapagina,distribuicaofolhasavulsas.`status`,distribuicaofolhasavulsas.datadistribuicao,distribuicaofolhasavulsas.datacancelado," +
                "distribuicaofolhasavulsas.formapagamento,distribuicaofolhasavulsas.valorfolha,distribuicaofolhasavulsas.datadevolucao,distribuicaofolhasavulsas.usuariocad,distribuicaofolhasavulsas.fk_corretor_distribuicaofolhasavulsas,distribuicaofolhasavulsas.fk_loteamento_distribuicaofolhasavulsas," +
                "loteamento.nome,loteamento.idloteamento,corretor.idcorretor,corretor.nome FROM distribuicaofolhasavulsas INNER JOIN corretor ON distribuicaofolhasavulsas.fk_corretor_distribuicaofolhasavulsas = corretor.idcorretor INNER JOIN loteamento ON distribuicaofolhasavulsas.fk_loteamento_distribuicaofolhasavulsas = loteamento.idloteamento";

            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

        }
        public DataTable CarregarDistribuicao()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from distribuicaofolhasavulsas;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

        }
        public void NovaDistribuicao(m_DistribuicaoFolhasAvulsas m_distribuicaoFolhasAvulsas)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "INSERT INTO distribuicaofolhasavulsas(folhapagina,formapagamento,status,usuariocad,valorfolha,datadistribuicao,fk_corretor_distribuicaofolhasavulsas,fk_loteamento_distribuicaofolhasavulsas) VALUES(@folhapagina,@formapagamento,@status,@usuariocad,@valorfolha,@datadistribuicao,@fk_corretor_distribuicaofolhasavulsas,@fk_loteamento_distribuicaofolhasavulsas);";
            comando.Parameters.Add(new MySqlParameter("@folhapagina", m_distribuicaoFolhasAvulsas.folhapagina));
            comando.Parameters.Add(new MySqlParameter("@formapagamento", m_distribuicaoFolhasAvulsas.formapagamento));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoFolhasAvulsas.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoFolhasAvulsas.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@valorfolha", m_distribuicaoFolhasAvulsas.valorfolha));
            comando.Parameters.Add(new MySqlParameter("@datadistribuicao", m_distribuicaoFolhasAvulsas.datadistribuicao));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_distribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.fk_corretor_distribuicaofolhasavulsas));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_distribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.fk_loteamento_distribuicaofolhasavulsas));
            comando.ExecuteNonQuery();
        }
        public void ExcluirDistribuicao(m_DistribuicaoFolhasAvulsas m_distribuicaoFolhasAvulsas)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from distribuicaofolhasavulsas where iddistribuicaofolhasavulsas = @iddistribuicaofolhasavulsas;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.iddistribuicaofolhasavulsas));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicao(m_DistribuicaoFolhasAvulsas m_distribuicaoFolhasAvulsas)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaofolhasavulsas SET folhapagina = @folhapagina, formapagamento = @formapagamento, status = @status, usuariocad = @usuariocad, valorfolha = @valorfolha, datadistribuicao = @datadistribuicao,fk_corretor_distribuicaofolhasavulsas = @fk_corretor_distribuicaofolhasavulsas,fk_loteamento_distribuicaofolhasavulsas = @fk_loteamento_distribuicaofolhasavulsas WHERE iddistribuicaofolhasavulsas = @iddistribuicaofolhasavulsas;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.iddistribuicaofolhasavulsas));
            comando.Parameters.Add(new MySqlParameter("@folhapagina", m_distribuicaoFolhasAvulsas.folhapagina));
            comando.Parameters.Add(new MySqlParameter("@formapagamento", m_distribuicaoFolhasAvulsas.formapagamento));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoFolhasAvulsas.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoFolhasAvulsas.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@valorfolha", m_distribuicaoFolhasAvulsas.valorfolha));
            comando.Parameters.Add(new MySqlParameter("@datadistribuicao", m_distribuicaoFolhasAvulsas.datadistribuicao));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_distribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.fk_corretor_distribuicaofolhasavulsas));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_distribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.fk_loteamento_distribuicaofolhasavulsas));
            comando.ExecuteNonQuery();
        }

        public void AlterarDistribuicaoParaCancelado(m_DistribuicaoFolhasAvulsas m_distribuicaoFolhasAvulsas)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaofolhasavulsas SET datacancelado = @datacancelado,usuariocad = @usuariocad,status = @status WHERE iddistribuicaofolhasavulsas = @iddistribuicaofolhasavulsas;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.iddistribuicaofolhasavulsas));
            comando.Parameters.Add(new MySqlParameter("@datacancelado", m_distribuicaoFolhasAvulsas.datacancelado));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoFolhasAvulsas.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoFolhasAvulsas.status));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicaoParaDevolvido(m_DistribuicaoFolhasAvulsas m_distribuicaoFolhasAvulsas)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaofolhasavulsas SET datadevolucao = @datadevolucao,usuariocad = @usuariocad,status = @status WHERE iddistribuicaofolhasavulsas = @iddistribuicaofolhasavulsas;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaofolhasavulsas", m_distribuicaoFolhasAvulsas.iddistribuicaofolhasavulsas));
            comando.Parameters.Add(new MySqlParameter("@datadevolucao", m_distribuicaoFolhasAvulsas.datadevolucao));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoFolhasAvulsas.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoFolhasAvulsas.status));
            comando.ExecuteNonQuery();
        }


    }
}
