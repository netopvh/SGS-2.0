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
    public partial class v_EstruturasComissoes : DevExpress.XtraBars.TabForm
    {
        string _UsuarioCad;
        c_EstruturaComissao c_estruturaComissao;
        m_EstruturaComissao m_estruturaComissao;
        public v_EstruturasComissoes()
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
        }
        public v_EstruturasComissoes(string UsuarioCad)
        {
            InitializeComponent();
            this.c_estruturaComissao = new c_EstruturaComissao();
            this.m_estruturaComissao = new m_EstruturaComissao();
            _UsuarioCad = UsuarioCad;

        }

        private void v_EstruturasComissoes_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarGrid();
        }
        private void Funcao(string funcao)
        {
            switch (funcao)
            {
                case "novo":
                    v_NovaEstruturaComissao v_NovaEstrutura = new v_NovaEstruturaComissao(_UsuarioCad);
                    v_NovaEstrutura.ShowDialog();
                    break;
                case "alterar":
                    v_NovaEstruturaComissao v_AlterarEstrutura = new v_NovaEstruturaComissao(
                        (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]),
                        (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]),
                        (decimal)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]),
                        (decimal)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]),
                        (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]),
                        _UsuarioCad,true);
                    v_AlterarEstrutura.ShowDialog();
                    break;
                case "excluir":
                    m_estruturaComissao.idestruturacomissao = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_estruturaComissao.ExcluirEstruturaComissao(m_estruturaComissao);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    break;
                    
                default:
                    break;
            }
        }
        public void CarregarGrid()
        {
            gridControl1.DataSource = c_estruturaComissao.CarregarEstruturasComissoes();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir a Estrutura selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Funcao("excluir");
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja alterar a Estrutura selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Funcao("alterar");
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Funcao("novo");
        }
    }
}
