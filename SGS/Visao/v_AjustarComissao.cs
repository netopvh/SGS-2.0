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
    public partial class v_AjustarComissao : DevExpress.XtraEditors.XtraForm
    {
        int _CodigoComissao,_QtdParcelaSinal;
        string _Corretor, _Empresa, _Venda, _Obra, _UsuarioCad;
        decimal _ValorLote, _ValorParcela,_ValorSinal,_PorcImob,_PorcCorretor,_ValorImob,_ValorCorretor;
        c_EstruturaComissao c_estruturaComissao;
        m_EstruturaComissao m_estruturaComissao;
        c_Comissoes c_comissoes;
        m_Comissoes m_comissoes;
        
        public v_AjustarComissao()
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
            this.c_comissoes = new c_Comissoes();
            this.m_comissoes = new m_Comissoes();
        }
        public v_AjustarComissao(int CodigoComissao,string Corretor,string Empresa,string Venda,string Obra,decimal ValorLote,decimal ValorParcela,int QtdParcelaSinal,string UsuarioCad)
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
            this.c_comissoes = new c_Comissoes();
            this.m_comissoes = new m_Comissoes();
            _CodigoComissao = CodigoComissao;
            _Corretor = Corretor;
            _Empresa = Empresa;
            _Venda = Venda;
            _Obra = Obra;
            _ValorLote = ValorLote;
            _ValorParcela = ValorParcela;
            _QtdParcelaSinal = QtdParcelaSinal;
            _UsuarioCad = UsuarioCad;
            lblQtdParcSinal.Text = Convert.ToString(_QtdParcelaSinal);
            lblValorLote.Text = Convert.ToString(_ValorLote.ToString("C"));
            lblValorParcela.Text = Convert.ToString(_ValorParcela.ToString("C"));
            this.Text = Text + ":Corretor:" + Corretor.Substring(0, 9) + " - Emp:" + Empresa + " Venda:" + Venda + " Obra:" + Obra;
            
        }
        private void cbxEstruturaComissao_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CarregarPorcentagensEstruturas();
            CarregarCalculos();
        }

        private void txtPorcSinal_Properties_EditValueChanged(object sender, EventArgs e)
        {
            CarregarPorcentagensEstruturas();
            CarregarCalculos();
        }

        private void v_AjustarComissao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarEstruturas();
        }
        
        private void CarregarCalculos()
        {
            try
            {
                decimal PorcSinal = Convert.ToDecimal(txtPorcSinal.Text);
                _ValorSinal = _ValorLote * PorcSinal / 100;
                lblValorSinal.Text = Convert.ToString(_ValorSinal.ToString("C"));
                decimal ValorParcelaSinal = _ValorSinal / _QtdParcelaSinal;
                lblValorParcelaSinal.Text = Convert.ToString(ValorParcelaSinal.ToString("C"));
                if (ValorParcelaSinal == _ValorParcela)
                {
                    lblValorParcela.ForeColor = Color.Green;
                }
                else
                {
                    lblValorParcela.ForeColor = Color.Red;
                }
                _ValorImob = _ValorParcela * _PorcImob / 100;
                lblValorImob.Text = Convert.ToString(_ValorImob.ToString("C"));
                _ValorCorretor = _ValorParcela * _PorcCorretor / 100;
                lblValorCorretor.Text = Convert.ToString(_ValorCorretor.ToString("C"));
                decimal SomaImobCorretor = _ValorImob + _ValorCorretor;
                lblSomaImobCorretor.Text = Convert.ToString(SomaImobCorretor.ToString("C"));
                if (SomaImobCorretor == _ValorParcela)
                {
                    lblSomaImobCorretor.ForeColor = Color.Green;
                }
                else
                {
                    lblSomaImobCorretor.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void CarregarEstruturas()
        {
            cbxEstruturaComissao.Properties.DataSource = c_estruturaComissao.CarregarEstruturasComissoes();
            cbxEstruturaComissao.Properties.DisplayMember = "descricao";
            cbxEstruturaComissao.Properties.ValueMember = "idestruturacomissao";
            cbxEstruturaComissao.ItemIndex = -1;
        }
        private void CarregarPorcentagensEstruturas()
        {
            try
            {
                m_estruturaComissao.idestruturacomissao = (int)cbxEstruturaComissao.EditValue;
                _PorcImob = c_estruturaComissao.CarregarPorcentagenImob(m_estruturaComissao);
                _PorcCorretor = c_estruturaComissao.CarregarPorcentagenCorretor(m_estruturaComissao);
                lblPorcImob.Text = Convert.ToString(_PorcImob);
                lblPorcCorretor.Text = Convert.ToString(_PorcCorretor);
                if (_PorcImob + _PorcCorretor == 100)
                {
                    lblPorcImob.ForeColor = Color.Green;
                    lblPorcCorretor.ForeColor = Color.Green;
                }
                else
                {
                    lblPorcImob.ForeColor = Color.Red;
                    lblPorcCorretor.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {

            }
        }
        private void cbxEstruturaComissao_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as alterações?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m_comissoes.idcomissoes = _CodigoComissao;
                m_comissoes.porcentagemimob = _PorcImob;
                m_comissoes.porcentagemcorretor = _PorcCorretor;
                m_comissoes.comissaoimob = _ValorImob;
                m_comissoes.comissaocorretor = _ValorCorretor;

                c_comissoes.AlterarPorcentagensComissoesImobCorretor(m_comissoes);
                MessageBox.Show("Alterações salvas com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
                this.Close();

            }
            else
            {

            }
        }
        private void AtualizarGrid()
        {
            v_ControleGeralComissoes v = Application.OpenForms["v_ControleGeralComissoes"] as v_ControleGeralComissoes;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }
    }
}
