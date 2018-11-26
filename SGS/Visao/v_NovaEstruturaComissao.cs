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
    public partial class v_NovaEstruturaComissao : DevExpress.XtraEditors.XtraForm
    {
        string _UsuarioCad;
        bool _Alterar = false;
        c_EstruturaComissao c_estruturaComissao;
        m_EstruturaComissao m_estruturaComissao;
        public v_NovaEstruturaComissao()
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
        }
        public v_NovaEstruturaComissao(string UsuarioCad)//Nova
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
            _UsuarioCad = UsuarioCad;
        }
        public v_NovaEstruturaComissao(int Codigo, string Descricao,decimal PorcentagemImob,decimal PorcentagemCorretor,int Status,string UsuarioCad,bool Alterar)//Alterar
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
            _Alterar = Alterar;
            _UsuarioCad = UsuarioCad;
            txtDescricao.Text = Descricao;
            txtPorcImob.Text = Convert.ToString(PorcentagemImob);
            txtPorcCorretor.Text = Convert.ToString(PorcentagemCorretor);
            if (Status == 0)
            {
                rbtInativo.Checked = true;
            }
            else if (Status == 1)
            {
                rbtAtivo.Checked = true;
            }
            
            this.Text = "Alterar Estrutura de Comissão";
            m_estruturaComissao.idestruturacomissao = Codigo;
        }

        private void v_NovaEstruturaComissao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            m_estruturaComissao.descricao = txtDescricao.Text;
            m_estruturaComissao.porcentagemcorretor = Convert.ToDecimal(txtPorcCorretor.Text.Replace("%",""));
            m_estruturaComissao.porcentagemimob = Convert.ToDecimal(txtPorcImob.Text.Replace("%", ""));
            if (rbtAtivo.Checked == true)
            {
                m_estruturaComissao.status = (int)e_Status.Ativo;
            }
            else if (rbtInativo.Checked == true)
            {
                m_estruturaComissao.status = (int)e_Status.Inativo;
            }
            m_estruturaComissao.usuariocad = _UsuarioCad;
            if (_Alterar == false)
            {
                if (MessageBox.Show("Deseja salvar a nova Estrutura de Comissão?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c_estruturaComissao.NovaEstruturaComissao(m_estruturaComissao);
                    MessageBox.Show("Cadastrado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
            }
            else if (_Alterar == true)
            {
                
                if (MessageBox.Show("Deseja salvar as Alterações da Estrutura de Comissão?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    c_estruturaComissao.AlterarEstruturaComissao(m_estruturaComissao);
                    MessageBox.Show("Atualizado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
            }
            
        }
        private void AtualizarGrid()
        {
            v_EstruturasComissoes v = Application.OpenForms["v_EstruturasComissoes"] as v_EstruturasComissoes;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TotalPorcentagem()
        {
            try
            {
                decimal PorcImob = 0;
                decimal PorcCorretor = 0;
                PorcImob = decimal.Parse(txtPorcImob.Text.Replace("%", ""));
                PorcCorretor = decimal.Parse(txtPorcCorretor.Text.Replace("%", ""));
                decimal Resultado = PorcImob + PorcCorretor;
                lblTotalPorcentagem.Text = Resultado.ToString() + "%";
            }
            catch (Exception)
            {
                
            }
            
        }
        private void txtPorcImob_EditValueChanged(object sender, EventArgs e)
        {
            TotalPorcentagem();
        }

        private void txtPorcCorretor_EditValueChanged(object sender, EventArgs e)
        {
            TotalPorcentagem();
        }
    }
}
