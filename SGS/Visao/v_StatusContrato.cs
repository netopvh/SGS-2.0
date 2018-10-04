using SGS.Controle;
using SGS.Enum;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao
{
    public partial class v_StatusContrato : DevExpress.XtraEditors.XtraForm
    {
        string _Usuario;
        int _CodigoDistribuicao;
        int _Status;
        m_Distribuicaocontratos m_distribuicaoContratos;
        c_Distribuicaocontratos c_distribuicaoContratos;
        public v_StatusContrato()
        {
            InitializeComponent();
        }
        public v_StatusContrato(string Usuario,int CodigoDistribuicao)
        {
            InitializeComponent();
            _Usuario = Usuario;
            _CodigoDistribuicao = CodigoDistribuicao;
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rbtCancelado.Checked != false || rbtDevolvido.Checked != false || rbtExtraviado.Checked != false || rbtVendido.Checked != false && _Status != null)
            {
                if (MessageBox.Show("Deseja salvar a alteração de status?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    m_distribuicaoContratos.iddistribuicaocontratos = _CodigoDistribuicao;
                    m_distribuicaoContratos.usuariocad = _Usuario;
                    m_distribuicaoContratos.status = _Status;

                    switch (_Status)
                    {
                        case 1:
                            m_distribuicaoContratos.datacancelado = dtpDataCad.Value;
                            c_distribuicaoContratos.AlterarDistribuicaoParaCancelado(m_distribuicaoContratos); //Cancelado
                            break;
                        case 2:
                            m_distribuicaoContratos.datadevolucao = dtpDataCad.Value;
                            c_distribuicaoContratos.AlterarDistribuicaoParaDevolvido(m_distribuicaoContratos);  //Devolvido
                            break;
                        case 3:
                            m_distribuicaoContratos.dataextravio = dtpDataCad.Value;
                            c_distribuicaoContratos.AlterarDistribuicaoParaExtraviado(m_distribuicaoContratos); //Extraviado
                            break;
                        case 4:
                            m_distribuicaoContratos.datavenda = dtpDataCad.Value;
                            c_distribuicaoContratos.AlterarDistribuicaoParaVendido(m_distribuicaoContratos);  //Vendido
                            break;
                        default:
                            break;
                    }
                    MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
            }
        }
        private void AtualizarGrid()
        {
            v_DistContrato v = Application.OpenForms["v_DistContrato"] as v_DistContrato;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }
        private void v_StatusContrato_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;

        }

        private void rbtVendido_CheckedChanged(object sender, EventArgs e)
        {
            _Status = (int)e_StatusDistribuicao.Vendido;
            //MessageBox.Show("Só coloque o contrato como vendido se o corretor tive passado a venda usando esse contrato!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbtCancelado_CheckedChanged(object sender, EventArgs e)
        {
            _Status = (int)e_StatusDistribuicao.Cancelado;
            //MessageBox.Show("Só coloque o contrato como cancelado se o corretor tive devolvendo o contrato por desistencia do cliente ou por contrato rasurado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbtDevolvido_CheckedChanged(object sender, EventArgs e)
        {
            _Status = (int)e_StatusDistribuicao.Devolvido;
            //MessageBox.Show("Só coloque o contrato como devolvido se o corretor tive devolvendo o contrato do jeito que ele pegou sem falta folhas e sem nenhuma rasura!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbtExtraviado_CheckedChanged(object sender, EventArgs e)
        {
            _Status = (int)e_StatusDistribuicao.Extraviado;
            //MessageBox.Show("Só coloque o contrato como extraviado se o corretor tive perdido o contrato ou se o mesmo foi roubado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
