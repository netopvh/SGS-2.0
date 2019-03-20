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
namespace SGS.Visao
{
    public partial class v_NovaComissao : DevExpress.XtraEditors.XtraForm
    {
        string _UsuarioCad;
        bool _AlteraCad = false;
        m_Comissoes m_comissoes;
        c_Comissoes c_Comissoes;
        c_Loteamento c_loteamento;
        m_Loteamento m_loteamento;
        c_Corretor c_corretor;
        public v_NovaComissao(string UsuarioCad)
        {
            InitializeComponent();
            this.m_comissoes = new m_Comissoes();
            this.c_Comissoes = new c_Comissoes();
            this.c_corretor = new c_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            _UsuarioCad = UsuarioCad;
        }
        public v_NovaComissao(int CodigoComissao,string UsuarioCad,string Corretor_PF,DateTime DataVenda, DateTime DataCadVenda,string Quadra,string Lote,
            string NomeCLiente,string StatusVenda,string TipoParcela,decimal ValorVenda,decimal ValorParcela,string Venda,string Empresa,string Obra,
            int ParcelaComissao,int TotalParcelaComissao, DateTime VencimentoParcela)// ALterar Cad
        {
            InitializeComponent();
            this.m_comissoes = new m_Comissoes();
            this.c_Comissoes = new c_Comissoes();
            this.c_corretor = new c_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            _UsuarioCad = UsuarioCad;
        }
        private void CarregarCbxCorretores()
        {
            cbxCorretor.Properties.DataSource = c_corretor.CarregarCorretores();
            cbxCorretor.Properties.DisplayMember = "nome";
            cbxCorretor.Properties.ValueMember = "idcorretor";
            if (_AlteraCad == false)
            {
                cbxCorretor.ItemIndex = -1;
            }
        }
        private void CarregarCbxLoteamentos()
        {
            cbxLoteamento.Properties.DataSource = c_loteamento.CarregarLoteamentos();
            cbxLoteamento.Properties.DisplayMember = "nome";
            cbxLoteamento.Properties.ValueMember = "idloteamento";
            if (_AlteraCad == false)
            {
                cbxLoteamento.ItemIndex = -1;
            }
        }

        private void v_NovaComissao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarCbxCorretores();
            CarregarCbxLoteamentos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtualizarGrid()
        {
            v_ControleGeralComissoes v = Application.OpenForms["v_ControleGeralComissoes"] as v_ControleGeralComissoes;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gbxDadosDaVenda.Enabled = false;
            gbxEmpreendimento.Enabled = false;
            gbxParcelas.Enabled = false;
            splashScreenManagerN.ShowWaitForm();

            if (txtCliente.Text != string.Empty && txtLote.Text != string.Empty && txtQuadra.Text != string.Empty && txtValorParcela.Text != string.Empty &&
                txtValorVenda.Text != string.Empty && txtVenda.Text != string.Empty && cbxCorretor.Text != string.Empty && cbxLoteamento.Text != string.Empty &&
                cbxParcelaTipo.Text != string.Empty && cbxStatusVenda.Text != string.Empty && nudQtdParcelas.Value > 0)
            {
            m_comissoes.usuariocad = _UsuarioCad;
            m_comissoes.corretor_pf = cbxCorretor.Text;
            m_comissoes.DataVenda = dtpDataVenda.Value;
            m_comissoes.datacadvenda = dtpDataCadastro.Value;
            m_comissoes.quadra = txtQuadra.Text;
            m_comissoes.lote = txtLote.Text;
            m_comissoes.NomeCliente = txtCliente.Text;
            m_comissoes.statusvenda = cbxStatusVenda.Text;
            m_comissoes.tipoparcela = cbxParcelaTipo.Text;
            m_comissoes.valorvenda = Convert.ToDecimal(txtValorVenda.Text.Replace("R$",""));
            m_comissoes.valorparcela = Convert.ToDecimal(txtValorParcela.Text.Replace("R$", ""));
            m_comissoes.venda = txtVenda.Text;
            
            m_loteamento.idloteamento = Convert.ToInt32(cbxLoteamento.EditValue);
            m_comissoes.obra = c_loteamento.CarregarObra(m_loteamento);
            m_loteamento.empresa = c_loteamento.CarregarEmpresa(m_loteamento);
            m_comissoes.empresa = c_loteamento.CarregarEmpresa(m_loteamento);
            
                
                if (_AlteraCad == false)
                {
                    m_comissoes.datacadcomissao = DateTime.Now;
                    if (nudQtdParcelas.Value > 1)
                    {
                        for (int i = 1; i <= nudQtdParcelas.Value; i++)
                        {
                            m_comissoes.parcelacomissao = i;
                            m_comissoes.totalparcelacomissao = Convert.ToInt32(nudQtdParcelas.Value);
                            if (i == 1)
                            {
                                m_comissoes.vencimentoparcela = dtpDataVencimento.Value;
                            }
                            else
                            {
                                dtpDataVencimento.Value = dtpDataVencimento.Value.AddMonths(1);
                                m_comissoes.vencimentoparcela = dtpDataVencimento.Value;
                            }
                            c_Comissoes.NovasComissoes(m_comissoes);
                        }
                        splashScreenManagerN.CloseWaitForm();
                        MessageBox.Show("Comissões adicionadas com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                    else
                    {
                        m_comissoes.parcelacomissao = 1;
                        m_comissoes.totalparcelacomissao = 1;
                        m_comissoes.vencimentoparcela = dtpDataVencimento.Value;
                        c_Comissoes.NovasComissoes(m_comissoes);
                        splashScreenManagerN.CloseWaitForm();
                        MessageBox.Show("Comissão adicionada com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                }
                else if (_AlteraCad == true)
                {

                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                splashScreenManagerN.CloseWaitForm();
                gbxDadosDaVenda.Enabled = true;
                gbxEmpreendimento.Enabled = true;
                gbxParcelas.Enabled = true;

            }
            
            
        }
        
    }
}
