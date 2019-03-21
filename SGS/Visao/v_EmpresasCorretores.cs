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
    public partial class v_EmpresasCorretores : DevExpress.XtraBars.TabForm
    {
        m_EmpresaCorretor m_empresaCorretor;
        c_EmpresaCorretor c_empresaCorretor;
        string _UsuarioCad;
        public v_EmpresasCorretores(string UsuarioCad)
        {
            InitializeComponent();
            this.m_empresaCorretor = new m_EmpresaCorretor();
            this.c_empresaCorretor = new c_EmpresaCorretor();
            _UsuarioCad = UsuarioCad;
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                
                case "excluir":
                        m_empresaCorretor.idempresacorretor = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                        c_empresaCorretor.ExcluirEmpresaCorretor(m_empresaCorretor);
                        MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                    
                    break;
                case "alterar":
                    m_empresaCorretor.idempresacorretor = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]));
                    m_empresaCorretor.nomeempresa = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString();
                    m_empresaCorretor.cnpj = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString();
                    m_empresaCorretor.status = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]));
                    m_empresaCorretor.crecijuridico = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString();
                    
                    v_NovaEmpresaCorretor FormAltearEmpresaCorretor = new v_NovaEmpresaCorretor(_UsuarioCad, m_empresaCorretor, true);
                    FormAltearEmpresaCorretor.ShowDialog();
                    break;
                
                default:
                    break;
            }
        }
        public void AtualizarGrid()
        {
            gridControl1.DataSource = c_empresaCorretor.CarregarEmpresaCorretores();
        }
        private void v_EmpresasCorretores_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            CancelButton = btnVoltar;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            v_NovaEmpresaCorretor FormNovaEmpresa = new v_NovaEmpresaCorretor(_UsuarioCad);
            FormNovaEmpresa.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja alterar a empresa selecionada ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    funcao("alterar");
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir a empresa selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("excluir");
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void advBandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if (Convert.ToInt32(e.Value) == 0) e.DisplayText = "0 - Inativo";
                if (Convert.ToInt32(e.Value) == 1) e.DisplayText = "1 - Ativo";
            }
        }
    }
}
