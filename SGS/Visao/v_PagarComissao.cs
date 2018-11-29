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
    public partial class v_PagarComissao : DevExpress.XtraEditors.XtraForm
    {
        c_Comissoes c_comissoes;
        m_Comissoes m_comissoes;
        int _CodigoComissao;
        string _CorrretorPF, _ValorComissaoCorretor,_ValorComissaoImob, _ParcelaComissao, _Emp, _Venda, _Obra, _UsuarioCad;
        public v_PagarComissao()
        {
            InitializeComponent();
            c_comissoes = new c_Comissoes();
            m_comissoes = new m_Comissoes();
        }
        public v_PagarComissao(int CodigoComissao,string Corretor_PF,string ValorComissaoCorretor,string ValorComissaoImob,string ParcelaComissao,string Emp,string Venda,string Obra,string UsuarioCad)
        {
            InitializeComponent();
            c_comissoes = new c_Comissoes();
            m_comissoes = new m_Comissoes();
            _CodigoComissao = CodigoComissao;
            _CorrretorPF = Corretor_PF;
            _ValorComissaoCorretor = ValorComissaoCorretor;
            _ValorComissaoImob = ValorComissaoImob;
            _ParcelaComissao = ParcelaComissao;
            _Emp = Emp;
            _Venda = Venda;
            _Obra = Obra;
            _UsuarioCad = UsuarioCad;
            
            lblCorretor.Text = _CorrretorPF;
            lblValorComissoParcela.Text = "Corretor: R$" + _ValorComissaoCorretor +" Imob: R$"+_ValorComissaoImob+ " Parcela:" + _ParcelaComissao;
            this.Text = Text + " Emp:" + _Emp + " Venda:" + _Venda + " Obra:" + _Obra;
        }

        private void v_PagarComissao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            m_comissoes.idcomissoes = _CodigoComissao;
            m_comissoes.datapagamentocomissao = dtpDataPagamento.Value;

            c_comissoes.AlterarDataPagmentoComissao(m_comissoes);
            MessageBox.Show("Data de pagamento da comissão informada com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarGridControleGeralComissoes();
            this.Close();
        }
        private void AtualizarGridControleGeralComissoes()
        {
            v_ControleGeralComissoes v = Application.OpenForms["v_ControleGeralComissoes"] as v_ControleGeralComissoes;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }
        private void btnReferenciarNF_Click(object sender, EventArgs e)
        {

        }
    }
}
