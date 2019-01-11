using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGS.Modelo;

namespace SGS.Controle
{
    public class c_CorretorPlantao
    {

        public DataTable CarregarCorretoresPlantaoID(m_CorretorPlantao m_corretorPlantao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from corretorplantao where fk_plantao_corretorplantao = @fk_plantao_corretorplantao;";
            comando.Parameters.Add(new MySqlParameter("@fk_plantao_corretorplantao", m_corretorPlantao.fk_plantao_corretorplantao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        public DataTable CarregarCorretorPlantao()
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select idcorretorplantao,nomecorretor from corretorplantao;";
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            conexao.Clone();
            return dataTable;

        }
        
        public int SomarTotalPosicoesCorretoresPlantao(m_CorretorPlantao m_corretorPlantao)
        {
            int resultado = 0;

            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandText =
            "select count(posicao) from corretorplantao where fk_plantao_corretorplantao = @fk_plantao_corretorplantao;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@fk_plantao_corretorplantao", m_corretorPlantao.fk_plantao_corretorplantao));
            MySqlDataReader reader = c_ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            conexao.Clone();
            return resultado;

        }
        
        public void NovoCorretorPlantao(m_CorretorPlantao m_corretorPlantao)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into corretorplantao(posicao,nomecorretor,fk_plantao_corretorplantao) values(@posicao,@nomecorretor,@fk_plantao_corretorplantao);";
            comando.Parameters.Add(new MySqlParameter("@nomecorretor", m_corretorPlantao.nomecorretor));
            comando.Parameters.Add(new MySqlParameter("@posicao", m_corretorPlantao.posicao));
            comando.Parameters.Add(new MySqlParameter("@fk_plantao_corretorplantao", m_corretorPlantao.fk_plantao_corretorplantao));
            
            comando.ExecuteNonQuery();
            conexao.Clone();

        }
        /*
        public void ExcluirCorretorPlantao(m_Corretor m_corretor)
        {
            try
            {
                MySqlConnection conexao = c_ConexaoMySql.GetConexao();
                MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText =
                    "delete from corretor where idcorretor = @idcorretor;";
                comando.Parameters.Add(new MySqlParameter("@idcorretor", m_corretor.idcorretor));
                comando.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException mex)
            {
                MessageBox.Show("Error:" + mex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        */
        /*
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
        */
    }
}
