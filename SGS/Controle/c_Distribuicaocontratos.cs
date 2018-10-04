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
    public class c_Distribuicaocontratos
    {
        public DataTable CarregarDistribuicoes()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT distribuicaocontratos.iddistribuicaocontratos,distribuicaocontratos.numerocontrato,distribuicaocontratos.`status`,distribuicaocontratos.datadistribuicao,distribuicaocontratos.dataextravio,distribuicaocontratos.datacancelado,distribuicaocontratos.datadevolucao,distribuicaocontratos.usuariocad,distribuicaocontratos.fk_corretor_distribuicaocontratos,distribuicaocontratos.fk_loteamento_distribuicaocontratos,distribuicaocontratos.datavenda,loteamento.idloteamento,loteamento.nome,corretor.idcorretor,corretor.nome FROM distribuicaocontratos "+
            "INNER JOIN corretor ON distribuicaocontratos.fk_corretor_distribuicaocontratos = corretor.idcorretor "+
            "INNER JOIN loteamento ON distribuicaocontratos.fk_loteamento_distribuicaocontratos = loteamento.idloteamento";
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
            comando.CommandText = "select * from distribuicaocontratos;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

        }
        public void NovaDistribuicao(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "INSERT INTO distribuicaocontratos(numerocontrato,status,datadistribuicao,usuariocad,fk_corretor_distribuicaocontratos,fk_loteamento_distribuicaocontratos) VALUES(@numerocontrato,@status,@datadistribuicao,@usuariocad,@fk_corretor_distribuicaocontratos,@fk_loteamento_distribuicaocontratos);";
            comando.Parameters.Add(new MySqlParameter("@numerocontrato", m_distribuicaoContratos.numerocontrato));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoContratos.status));
            comando.Parameters.Add(new MySqlParameter("@datadistribuicao", m_distribuicaoContratos.datadistribuicao));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_distribuicaocontratos", m_distribuicaoContratos.fk_corretor_distribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_distribuicaocontratos", m_distribuicaoContratos.fk_loteamento_distribuicaocontratos));
            comando.ExecuteNonQuery();
        }
        public void ExcluirDistribuicao(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from distribuicaocontratos where iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicao(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaocontratos SET numerocontrato = @numerocontrato,usuariocad = @usuariocad,datadistribuicao = @datadistribuicao,fk_corretor_distribuicaocontratos = @fk_corretor_distribuicaocontratos, fk_loteamento_distribuicaocontratos = @fk_loteamento_distribuicaocontratos WHERE iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@numerocontrato", m_distribuicaoContratos.numerocontrato));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@datadistribuicao", m_distribuicaoContratos.datadistribuicao));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_distribuicaocontratos", m_distribuicaoContratos.fk_corretor_distribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_distribuicaocontratos", m_distribuicaoContratos.fk_loteamento_distribuicaocontratos));
            comando.ExecuteNonQuery();
        }
        
        public void AlterarDistribuicaoParaCancelado(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaocontratos SET datacancelado = @datacancelado,usuariocad = @usuariocad,status = @status WHERE iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@datacancelado", m_distribuicaoContratos.datacancelado));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoContratos.status));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicaoParaDevolvido(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaocontratos SET datadevolucao = @datadevolucao,usuariocad = @usuariocad,status = @status WHERE iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@datadevolucao", m_distribuicaoContratos.datadevolucao));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoContratos.status));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicaoParaExtraviado(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaocontratos SET dataextravio = @dataextravio,usuariocad = @usuariocad,status = @status WHERE iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@dataextravio", m_distribuicaoContratos.dataextravio));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoContratos.status));
            comando.ExecuteNonQuery();
        }
        public void AlterarDistribuicaoParaVendido(m_Distribuicaocontratos m_distribuicaoContratos)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "UPDATE distribuicaocontratos SET datavenda = @datavenda,usuariocad = @usuariocad,status = @status WHERE iddistribuicaocontratos = @iddistribuicaocontratos;";
            comando.Parameters.Add(new MySqlParameter("@iddistribuicaocontratos", m_distribuicaoContratos.iddistribuicaocontratos));
            comando.Parameters.Add(new MySqlParameter("@datavenda", m_distribuicaoContratos.datavenda));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_distribuicaoContratos.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@status", m_distribuicaoContratos.status));
            comando.ExecuteNonQuery();
        }
    }
}
