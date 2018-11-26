using SGS.Controle;
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
    public partial class v_InformarData : DevExpress.XtraEditors.XtraForm
    {

        m_Atendimento m_atendimento;
        c_Atendimento c_atendimento;

        public v_InformarData()
        {
            InitializeComponent();
            this.c_atendimento = new c_Atendimento();
            this.m_atendimento = new m_Atendimento();
        }
        public v_InformarData(int CodigoAtendimento, string UsuarioCad)
        {
            InitializeComponent();
            this.c_atendimento = new c_Atendimento();
            this.m_atendimento = new m_Atendimento();
            m_atendimento.idatendimento = CodigoAtendimento;
            m_atendimento.usuariocad = UsuarioCad;
        }

        private void v_InformarData_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            AcceptButton = btnSalvar;
            dtpData.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dtpData.Value != null)
            {
                if (MessageBox.Show("Confirma que essa data informada e a data que o cliente comprou o lote?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    m_atendimento.dataCompra = dtpData.Value;
                    m_atendimento.comprou = "COMPROU";

                    c_atendimento.AlterarAtendimentoParaComprou(m_atendimento);
                    MessageBox.Show("Data da Compra informada com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridAtendimentos();
                    this.Close();

                }

            }
        }
        private void AtualizarGridAtendimentos()
        {
            v_VisitasStand v = Application.OpenForms["v_VisitasStand"] as v_VisitasStand;
            if (v != null)
            {
                v.CarregarAtendimentos();
            }
        }
    }
}
