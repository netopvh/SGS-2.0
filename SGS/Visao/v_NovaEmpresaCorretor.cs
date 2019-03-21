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
    public partial class v_NovaEmpresaCorretor : DevExpress.XtraEditors.XtraForm
    {
        m_EmpresaCorretor m_empresaCorretor;
        c_EmpresaCorretor c_empresaCorretor;
        string _UsuarioCad;
        bool _AlterarCad;
        public v_NovaEmpresaCorretor(string UsuarioCad)
        {
            InitializeComponent();
            this.c_empresaCorretor = new c_EmpresaCorretor();
            this.m_empresaCorretor = new m_EmpresaCorretor();
            _UsuarioCad = UsuarioCad;
        }
        public v_NovaEmpresaCorretor(string UsuarioCad,m_EmpresaCorretor EmpresaCorretor,bool AltearCad)
        {
            InitializeComponent();
            this.c_empresaCorretor = new c_EmpresaCorretor();
            this.m_empresaCorretor = new m_EmpresaCorretor();
            m_empresaCorretor.idempresacorretor = EmpresaCorretor.idempresacorretor;
            _UsuarioCad = UsuarioCad;
            txtNomeEmpresa.Text = EmpresaCorretor.nomeempresa;
            txtCNPJ.Text = EmpresaCorretor.cnpj;
            txtCreciJuridico.Text = EmpresaCorretor.crecijuridico;
            if (EmpresaCorretor.status == 0)
            {
                rbtInativo.Checked = true;
            }
            else if (EmpresaCorretor.status == 1)
            {
                rbtAtivo.Checked = true;
            }
            this.Text = "Alterar Empresa Corretor";
            _AlterarCad = AltearCad;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void v_NovaEmpresaCorretor_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
        }
        private void AtualizarGrid()
        {
            v_EmpresasCorretores v = Application.OpenForms["v_EmpresasCorretores"] as v_EmpresasCorretores;
            if (v != null)
            {
                v.AtualizarGrid();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (txtNomeEmpresa.Text != string.Empty && txtNomeEmpresa.Text.Length > 4)
                {
                    m_empresaCorretor.cnpj = txtCNPJ.Text;
                    m_empresaCorretor.nomeempresa = txtNomeEmpresa.Text;
                    m_empresaCorretor.crecijuridico = txtCreciJuridico.Text;
                    if (rbtInativo.Checked)
                    {
                        m_empresaCorretor.status = (int)e_Status.Inativo;
                    }
                    else if (rbtAtivo.Checked)
                    {
                        m_empresaCorretor.status = (int)e_Status.Ativo;
                    }
                    if (_AlterarCad == false)
                    {
                        m_empresaCorretor.datacadastro = DateTime.Now;
                        m_empresaCorretor.usuariocad = _UsuarioCad;
                        c_empresaCorretor.NovoEmpresaCorretor(m_empresaCorretor);
                        
                    }
                    else if (_AlterarCad == true)
                    {
                        c_empresaCorretor.AlterarEmpresaCorretor(m_empresaCorretor);
                    }
                    MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGrid();
                    this.Close();
                }
            }
            
        }

        private void txtCNPJ_EditValueChanged(object sender, EventArgs e)
        {
            
            this.txtCNPJ.Properties.Mask.BeepOnError = true;
            this.txtCNPJ.Properties.Mask.EditMask = "00.000.000/0000-00";
            
        }
    }
}
