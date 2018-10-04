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
    public partial class v_NovaDistribuicaoContrato : DevExpress.XtraEditors.XtraForm
    {

        
        string _usuarioCad;
        bool _Alterar = false;
        m_Distribuicaocontratos m_distribuicaoContratos;
        c_Distribuicaocontratos c_distribuicaoContratos;
        m_Loteamento m_loteamento;
        c_Loteamento c_loteamento;
        m_Corretor m_corretor;
        c_Corretor c_corretor;
        
        public v_NovaDistribuicaoContrato()
        {
            InitializeComponent();
        }
        public v_NovaDistribuicaoContrato(string UsuarioCad)
        {
            InitializeComponent();
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            _usuarioCad = UsuarioCad;
        }
        private void v_NovaDistribuicaoContrato_Load(object sender, EventArgs e)
        {
            CarregarCorretores();
            CarregarEmpreendimentos();
        }
        public v_NovaDistribuicaoContrato(string UsuarioCad,bool Alterar,int CodigoDistribuicao,string Empreendimento,string Corretor,int NumeroContrato,DateTime DataDistribuicao)//Atualizar//Editar Distribuição
        {
            
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            InitializeComponent();
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar distribuição de Contrato";
            m_distribuicaoContratos.iddistribuicaocontratos = CodigoDistribuicao;
            _usuarioCad = UsuarioCad;
            lookUpEditCorretor.EditValue = Corretor;
            lookUpEditEmpreendimento.EditValue = Empreendimento;
            txtSqcInicial.Value = NumeroContrato;
            dtpDataDistribuicao.Value = DataDistribuicao;
            txtSqcFinal.Value = txtSqcInicial.Value;
            _Alterar = Alterar;
            txtSqcFinal.Enabled = false;
            
        }

        
        private void CarregarCorretores()
        {

            DataTable dtc = new DataTable();
            dtc = c_corretor.CarregarCorretor();
            lookUpEditCorretor.Properties.DataSource = dtc;
            lookUpEditCorretor.Properties.DisplayMember = "nome";
            lookUpEditCorretor.Properties.ValueMember = "idcorretor";
            if (_Alterar == false)
            {
                lookUpEditCorretor.ItemIndex = -1;
            }
            else
            {

            }
        }
        private void CarregarEmpreendimentos()
        {
            DataTable dte = new DataTable();
            dte = c_loteamento.CarregarLoteamento();
            lookUpEditEmpreendimento.Properties.DataSource = dte;
            lookUpEditEmpreendimento.Properties.DisplayMember = "nome";
            lookUpEditEmpreendimento.Properties.ValueMember = "idloteamento";
            if (_Alterar == false)
            {
                lookUpEditEmpreendimento.ItemIndex = -1;
            }
            else
            {

            }

        }
        private void TotalContratos()
        {
            int inicial, final, total;
            inicial = (int)txtSqcInicial.Value;
            final = (int)txtSqcFinal.Value;
            total = final - inicial + 1;
            lblTotalContratos.Text = total.ToString();
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
               
                case "salvar":
                    for (int i = (int)txtSqcInicial.Value; i <= (int)txtSqcFinal.Value; i++)
                    {
                        /*
                        Distribuido = 0,
                        Cancelado = 1,
                        Devolvido = 2,
                        Extraviado = 3
                        */
                        m_distribuicaoContratos.numerocontrato = i;
                        m_distribuicaoContratos.usuariocad = _usuarioCad;
                        m_distribuicaoContratos.status = (int)e_StatusDistribuicao.Distribuido;
                        m_distribuicaoContratos.datadistribuicao = dtpDataDistribuicao.Value;
                        m_distribuicaoContratos.fk_corretor_distribuicaocontratos = (int)lookUpEditCorretor.EditValue;
                        m_distribuicaoContratos.fk_loteamento_distribuicaocontratos = (int)lookUpEditEmpreendimento.EditValue;
                        if (_Alterar == false)
                        {
                            c_distribuicaoContratos.NovaDistribuicao(m_distribuicaoContratos);
                            
                        }
                        else if (_Alterar == true)
                        {
                            c_distribuicaoContratos.AlterarDistribuicao(m_distribuicaoContratos);
                            
                        }
                        
                    }
                    if (_Alterar == false)
                    {
                        MessageBox.Show("Sequencia de Contrato(s) de N° " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " distribuido(s) com Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                    else if (_Alterar == true)
                    {
                        MessageBox.Show("Contrato de N° " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " Atualizado com Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                    
                    break;
                
                default:
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSqcInicial.Value > 0 && txtSqcFinal.Value > 0 && txtSqcInicial.Value <= txtSqcFinal.Value)
            {
                if (lookUpEditCorretor.Text != string.Empty && lookUpEditEmpreendimento.Text != string.Empty)
                {
                    if (_Alterar == false)
                    {
                        if (MessageBox.Show("Confirma que deseja distribuir o(s) contrato(s)?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            funcao("salvar");
                        }
                    }
                    else if (_Alterar == true)
                    {
                        if (MessageBox.Show("Confirma que deseja Alterar a distribuição desse contrato?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            funcao("salvar");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Informe uma sequencia válida!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtSqcInicial_ValueChanged(object sender, EventArgs e)
        {
            if (_Alterar == true)
            {
                
                txtSqcFinal.Value = txtSqcInicial.Value;
                txtSqcFinal.Refresh();
            }
            TotalContratos();
            
        }

        private void txtSqcFinal_ValueChanged(object sender, EventArgs e)
        {
            
            TotalContratos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSqcInicial_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSqcInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
