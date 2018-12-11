using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
using SGS.Modelo;
using SGS.Enum;
namespace SGS.Visao
{
    public partial class v_StatusFolhaAvulso : DevExpress.XtraEditors.XtraForm
    {
        string _UsuarioCad;
        c_DistribuicaoFolhasAvulsas c_DistFolhaAvulsas;
        m_DistribuicaoFolhasAvulsas m_DistFlhasAvulsas;
        public v_StatusFolhaAvulso()
        {
            InitializeComponent();
            this.c_DistFolhaAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_DistFlhasAvulsas = new m_DistribuicaoFolhasAvulsas();
        }
        public v_StatusFolhaAvulso(int CodigoDistribuicaoFolha,string UsuarioCad)
        {
            InitializeComponent();
            this.c_DistFolhaAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_DistFlhasAvulsas = new m_DistribuicaoFolhasAvulsas();
            _UsuarioCad = UsuarioCad;
            m_DistFlhasAvulsas.iddistribuicaofolhasavulsas = CodigoDistribuicaoFolha;
        }

        private void v_StatusFolhaAvulso_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtualizarGrid()
        {
            v_DistFolhaAvulso v = Application.OpenForms["v_DistFolhaAvulso"] as v_DistFolhaAvulso;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            
            if (MessageBox.Show("Deseja mudar o status da distribuião?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                m_DistFlhasAvulsas.usuariocad = _UsuarioCad;
                if (rbtCancelado.Checked == true)
                {
                    m_DistFlhasAvulsas.status = (int)e_StatusDistribuicaoFolhaAvulso.Cancelado;
                    m_DistFlhasAvulsas.datacancelado = dtpDataCad.Value;
                    c_DistFolhaAvulsas.AlterarDistribuicaoParaCancelado(m_DistFlhasAvulsas);
                    MessageBox.Show("Status mudado com sucesso para Cancelado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
                else if (rbtDevolvido.Checked == true)
                {
                    m_DistFlhasAvulsas.status = (int)e_StatusDistribuicaoFolhaAvulso.Devolvido;
                    m_DistFlhasAvulsas.datadevolucao = dtpDataCad.Value;
                    c_DistFolhaAvulsas.AlterarDistribuicaoParaDevolvido(m_DistFlhasAvulsas);
                    MessageBox.Show("Status mudado com sucesso para Devolvido!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
                
            }
        }
    }
}
