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
    public partial class v_ControleGeralComissoes : DevExpress.XtraEditors.XtraForm
    {
        string _usuarioCad;
        c_Loteamento c_empreendimento;
        c_Comissoes c_comissoes;
        c_Corretor c_corretor;
        m_Comissoes m_comissoes;
        public v_ControleGeralComissoes()
        {
            InitializeComponent();
            this.c_empreendimento = new c_Loteamento();
            this.c_comissoes = new c_Comissoes();
            this.c_corretor = new c_Corretor();
            this.m_comissoes = new m_Comissoes();
        }
        public v_ControleGeralComissoes(string Usuario)
        {
            InitializeComponent();
            _usuarioCad = Usuario;
            this.c_empreendimento = new c_Loteamento();
            this.c_comissoes = new c_Comissoes();
            this.c_corretor = new c_Corretor();
            this.m_comissoes = new m_Comissoes();
        }

        private void v_ControleGeralComissoes_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarCorretores();
            CarregarEmpreendimentos();
            CarregarGrid();
            advBandedGridView1.BestFitColumns(true);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarEmpreendimentos()
        {
            cbxEmpreendimento.Properties.DataSource = c_empreendimento.CarregarLoteamento();
            cbxEmpreendimento.Properties.DisplayMember = "nome";
            cbxEmpreendimento.Properties.ValueMember = "idloteamento";

        }
        private void CarregarCorretores()
        {
            cbxCorretor.Properties.DataSource = c_corretor.CarregarCorretor();
            cbxCorretor.Properties.DisplayMember = "nome";
            cbxCorretor.Properties.ValueMember = "idcorretor";
        }
        public void CarregarGrid()
        {
            gridControlComissoes.DataSource = c_comissoes.CarregarComissoes();
        }

        private void cbxTipoPeriodo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar grid em Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Arquivo = saveFileDialog1.FileName;
                advBandedGridView1.ExportToXlsx(Arquivo);
                MessageBox.Show("Exportado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você não escolheu um caminho para salvar o arquivo...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void advBandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if ((int)e.Value == 0) e.DisplayText = "0 - Não Liberada";
                if ((int)e.Value == 1) e.DisplayText = "1 - Liberada";
                if ((int)e.Value == 2) e.DisplayText = "2 - Paga";
                if ((int)e.Value == 3) e.DisplayText = "3 - Bloqueada";
                if ((int)e.Value == 4) e.DisplayText = "4 - Cancelada";
            }
        }
        private void Funcao(string funcao)
        {
            switch (funcao)
            {
                case "novo":
                    v_NovaComissao v_novaComissao = new v_NovaComissao();
                    v_novaComissao.ShowDialog();
                    break;
                case "alterar":
                    break;
                case "excluir":
                    m_comissoes.idcomissoes =  Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]));
                    c_comissoes.ExcluirComissao(m_comissoes);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    break;
                case "ajustar":
                    v_AjustarComissao v_ajustar = new v_AjustarComissao(
                    Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0])),
                    advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString(),
                    advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString(),
                    advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString(),
                    advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString(),
                    (decimal)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]),
                    (decimal)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[17]),
                    (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[14])
                    , _usuarioCad);
                    v_ajustar.ShowDialog();
                    break;
                case "pagar":
                    v_PagarComissao v_pagar = new v_PagarComissao(
                        Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0])),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[21]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[19]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[13]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString(),
                        _usuarioCad);
                    v_pagar.ShowDialog();
                    break;
                default:
                    break;
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Funcao("novo");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja alterar os dados da Comissão selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Funcao("alterar");
                    }
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja excluir a Comissão selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Funcao("excluir");
                    }
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            if(advBandedGridView1.SelectedRowsCount == 1)
            {

            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                Funcao("pagar");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                Funcao("ajustar");
            }
        }
    }
}
