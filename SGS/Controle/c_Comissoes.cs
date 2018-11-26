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
    public class c_Comissoes
    {
        public DataTable CarregarComissoes()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from comissoes;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void NovasComissoes(m_Comissoes m_comissoes)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into comissoes(nomecliente,empresa,venda,obra,quadra,lote,datavenda,corretor_pf,datacadvenda,valorvenda,statusvenda,tipoparcela,parcelacomissao,totalparcelacomissao,vencimentoparcela,valorparcela,usuariocad)" +
            "values(@nomecliente,@empresa,@venda,@obra,@quadra,@lote,@datavenda,@corretor_pf,@datacadvenda,@valorvenda,@statusvenda,@tipoparcela,@parcelacomissao,@totalparcelacomissao,@vencimentoparcela,@valorparcela,@usuariocad); ";
            
            comando.Parameters.Add(new MySqlParameter("@nomecliente", m_comissoes.NomeCliente));
            comando.Parameters.Add(new MySqlParameter("@empresa", m_comissoes.empresa));
            comando.Parameters.Add(new MySqlParameter("@venda", m_comissoes.venda));
            comando.Parameters.Add(new MySqlParameter("@obra", m_comissoes.obra));
            comando.Parameters.Add(new MySqlParameter("@quadra", m_comissoes.quadra));
            comando.Parameters.Add(new MySqlParameter("@lote", m_comissoes.lote));
            comando.Parameters.Add(new MySqlParameter("@datavenda", m_comissoes.DataVenda));
            comando.Parameters.Add(new MySqlParameter("@corretor_pf", m_comissoes.corretor_pf));
            comando.Parameters.Add(new MySqlParameter("@datacadvenda", m_comissoes.datacadvenda));
            comando.Parameters.Add(new MySqlParameter("@valorvenda", m_comissoes.valorvenda));
            comando.Parameters.Add(new MySqlParameter("@statusvenda", m_comissoes.statusvenda));
            comando.Parameters.Add(new MySqlParameter("@tipoparcela", m_comissoes.tipoparcela));
            comando.Parameters.Add(new MySqlParameter("@parcelacomissao", m_comissoes.parcelacomissao));
            comando.Parameters.Add(new MySqlParameter("@totalparcelacomissao", m_comissoes.totalparcelacomissao));
            comando.Parameters.Add(new MySqlParameter("@vencimentoparcela", m_comissoes.vencimentoparcela));
            comando.Parameters.Add(new MySqlParameter("@valorparcela", m_comissoes.valorparcela));
            comando.Parameters.Add(new MySqlParameter("@usuariocad", m_comissoes.usuariocad));
            comando.ExecuteNonQuery();
        }
        public void ExcluirComissao(m_Comissoes m_comissoes)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "delete from comissoes where idcomissoes = @idcomissoes;";
            comando.Parameters.Add(new MySqlParameter("@idcomissoes", m_comissoes.idcomissoes));
            comando.ExecuteNonQuery();
        }
        public void AlterarPorcentagensComissoesImobCorretor(m_Comissoes m_comissoes)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update comissoes set porcentagemimob = @porcentagemimob,porcentagemcorretor = @porcentagemcorretor, comissaoimob = @comissaoimob, comissaocorretor = @comissaocorretor  where idcomissoes = @idcomissoes;";
            comando.Parameters.Add(new MySqlParameter("@idcomissoes", m_comissoes.idcomissoes));
            comando.Parameters.Add(new MySqlParameter("@porcentagemimob", m_comissoes.porcentagemimob));
            comando.Parameters.Add(new MySqlParameter("@porcentagemcorretor", m_comissoes.porcentagemcorretor));
            comando.Parameters.Add(new MySqlParameter("@comissaoimob", m_comissoes.comissaoimob));
            comando.Parameters.Add(new MySqlParameter("@comissaocorretor", m_comissoes.comissaocorretor));
            comando.ExecuteNonQuery();
        }
        public void AlterarComissaoVinculoEmpresaCorretor(m_Comissoes m_comissoes)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update comissoes set fk_empresacorretor_comissoes = @fk_empresacorretor_comissoes where idcomissoes = @idcomissoes;";
            comando.Parameters.Add(new MySqlParameter("@idcomissoes", m_comissoes.idcomissoes));
            comando.Parameters.Add(new MySqlParameter("@fk_empresacorretor_comissoes", m_comissoes.fk_empresacorretor_comissoes));
            comando.ExecuteNonQuery();
        }
        public void AlterarComissaoVinculoNotaFiscalCorretor(m_Comissoes m_comissoes)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update comissoes set fk_notafiscalcomissao_comissoes = @fk_notafiscalcomissao_comissoes where idcomissoes = @idcomissoes;";
            comando.Parameters.Add(new MySqlParameter("@idcomissoes", m_comissoes.idcomissoes));
            comando.Parameters.Add(new MySqlParameter("@fk_notafiscalcomissao_comissoes", m_comissoes.fk_notafiscalcomissao_comissoes));
            comando.ExecuteNonQuery();
        }

    }
}
