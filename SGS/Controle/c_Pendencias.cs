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
    public class c_Pendencias
    {
        public DataTable CarregarPendenciaCorretorLoteamento()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "SELECT p.idpendencias, p.quadra, p.lote, p.nomeCliente, p.venda, p.numerocontrato, p.pendencia, p.status, p.datavenda, p.datacadastro, p.datacadpendencia, p.usuariocad, p.datadevolucao,p.dataentregacorretor, p.fk_corretor_pendencias, p.fk_loteamento_pendencias,c.idcorretor,c.nome,l.idloteamento,l.nome as nomeemp FROM pendencias p inner join corretor c on c.idcorretor = p.fk_corretor_pendencias inner join loteamento l on l.idloteamento = p.fk_loteamento_pendencias;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void NovoPendencias(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into pendencias(nomecliente,numerocontrato,pendencia,quadra,lote,usuariocad,venda,status,datacadastro,datacadpendencia,datavenda,fk_corretor_pendencias,fk_loteamento_pendencias) values "+
                " (@nomecliente,@numerocontrato,@pendencia,@quadra,@lote,@usuariocad,@venda,@status,@datacadastro,@datacadpendencia,@datavenda,@fk_corretor_pendencias,@fk_loteamento_pendencias);";
            comando.Parameters.Add(new MySqlParameter("@nomeCliente", m_pendencias.nomecliente));
            comando.Parameters.Add(new MySqlParameter("@numerocontrato", m_pendencias.numerocontrato));
            comando.Parameters.Add(new MySqlParameter("@pendencia", m_pendencias.pendencia));
            comando.Parameters.Add(new MySqlParameter("@quadra", m_pendencias.quadra));
            comando.Parameters.Add(new MySqlParameter("@lote", m_pendencias.lote));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_pendencias.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@venda", m_pendencias.venda));
            comando.Parameters.Add(new MySqlParameter("@status", m_pendencias.status));
            comando.Parameters.Add(new MySqlParameter("@datacadastro", m_pendencias.datacadastro));
            comando.Parameters.Add(new MySqlParameter("@datacadpendencia", m_pendencias.datacadpendencia));
            //comando.Parameters.Add(new MySqlParameter("@datadevolucao", m_pendencias.datadevolucao));
            comando.Parameters.Add(new MySqlParameter("@datavenda", m_pendencias.datavenda));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_pendencias", m_pendencias.fk_corretor_pendencias));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_pendencias", m_pendencias.fk_loteamento_pendencias));
            comando.ExecuteNonQuery();
        }
        public void ExcluirPendencias(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from pendencias where idpendencias = @idpendencias;";
            comando.Parameters.Add(new MySqlParameter("@idpendencias", m_pendencias.idpendencias));
            comando.ExecuteNonQuery();
        }
        public void AlterarPendencias(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update pendencias set nomecliente = @nomeCliente, numerocontrato = @numerocontrato, pendencia = @pendencia, quadra = @quadra, lote = @lote, "+
                " usuariocad = @usuariocad, venda = @venda,datacadastro = @datacadastro,datacadpendencia = @datacadpendencia, "+
                " fk_corretor_pendencias = @fk_corretor_pendencias,fk_loteamento_pendencias = @fk_loteamento_pendencias where idpendencias = @idpendencias; ";
            comando.Parameters.Add(new MySqlParameter("@idpendencias", m_pendencias.idpendencias));
            comando.Parameters.Add(new MySqlParameter("@nomeCliente", m_pendencias.nomecliente));
            comando.Parameters.Add(new MySqlParameter("@numerocontrato", m_pendencias.numerocontrato));
            comando.Parameters.Add(new MySqlParameter("@pendencia", m_pendencias.pendencia));
            comando.Parameters.Add(new MySqlParameter("@quadra", m_pendencias.quadra));
            comando.Parameters.Add(new MySqlParameter("@lote", m_pendencias.lote));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_pendencias.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@venda", m_pendencias.venda));
            //comando.Parameters.Add(new MySqlParameter("@status", m_pendencias.status));
            comando.Parameters.Add(new MySqlParameter("@datacadastro", m_pendencias.datacadastro));
            comando.Parameters.Add(new MySqlParameter("@datacadpendencia", m_pendencias.datacadpendencia));
            //comando.Parameters.Add(new MySqlParameter("@datadevolucao", m_pendencias.datadevolucao));
            comando.Parameters.Add(new MySqlParameter("@datavenda", m_pendencias.datavenda));
            comando.Parameters.Add(new MySqlParameter("@fk_corretor_pendencias", m_pendencias.fk_corretor_pendencias));
            comando.Parameters.Add(new MySqlParameter("@fk_loteamento_pendencias", m_pendencias.fk_loteamento_pendencias));
            comando.ExecuteNonQuery();
        }
        public void AlterarPendenciaParaResolvido(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update pendencias set usuariocad = @usuariocad,status = @status,datadevolucao = @datadevolucao where idpendencias = @idpendencias; ";
            comando.Parameters.Add(new MySqlParameter("@idpendencias", m_pendencias.idpendencias));
            comando.Parameters.Add(new MySqlParameter("@status", m_pendencias.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_pendencias.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@datadevolucao", m_pendencias.datadevolucao));
            comando.ExecuteNonQuery();
        }
        public void AlterarPendenciaParaCorretor(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update pendencias set usuariocad = @usuariocad,status = @status,dataentregacorretor = @dataentregacorretor where idpendencias = @idpendencias; ";
            comando.Parameters.Add(new MySqlParameter("@idpendencias", m_pendencias.idpendencias));
            comando.Parameters.Add(new MySqlParameter("@status", m_pendencias.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_pendencias.usuariocad));
            comando.Parameters.Add(new MySqlParameter("@dataentregacorretor", m_pendencias.dataentregacorretor));
            comando.ExecuteNonQuery();
        }
        public void AlterarPendenciaParaARevolver(m_Pendencias m_pendencias)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update pendencias set usuariocad = @usuariocad,status = @status where idpendencias = @idpendencias; ";
            comando.Parameters.Add(new MySqlParameter("@idpendencias", m_pendencias.idpendencias));
            comando.Parameters.Add(new MySqlParameter("@status", m_pendencias.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_pendencias.usuariocad));
            comando.ExecuteNonQuery();
        }
    }
}
