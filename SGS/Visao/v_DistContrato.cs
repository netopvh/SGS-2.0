using DevExpress.XtraGrid.Views.BandedGrid;
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
    public partial class v_DistContrato : DevExpress.XtraBars.TabForm
    {
        int _permissao;
        string _usuarioCad;
        c_Distribuicaocontratos c_distribuicaoContratos;
        m_Distribuicaocontratos m_distribuicaoContratos;
        public v_DistContrato()
        {
            InitializeComponent();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
        }
        public v_DistContrato(int Permissao,string UsuarioCad)
        {
            InitializeComponent();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            _permissao = Permissao;
            _usuarioCad = UsuarioCad;
        }

        private void v_DistContrato_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarGrid();
            BestFitBand(gridBand1);
        }
        private void BestFitBand(GridBand band)
        {
            BandedGridView view = this.advBandedGridView1;
            view.BeginUpdate();
            string currentCaption = band.Columns[0].Caption;
            band.Columns[0].Caption = band.Columns[0].OwnerBand.Caption;
            foreach (BandedGridColumn column in band.Columns)
            {
                column.BestFit();
            }
            band.Columns[0].Caption = currentCaption;
            view.EndUpdate();
        }
        public void CarregarGrid()
        {
            DataTable dt = new DataTable();
            dt = c_distribuicaoContratos.CarregarDistribuicoes();
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
               
                case "alterar":
                    v_NovaDistribuicaoContrato v_AlterarDistribuicao = new v_NovaDistribuicaoContrato(_usuarioCad,true,
                        (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString(),
                        (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]),
                        (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]));
                    v_AlterarDistribuicao.ShowDialog();
                    break;
                case "excluir":
                    m_distribuicaoContratos.iddistribuicaocontratos = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_distribuicaoContratos.ExcluirDistribuicao(m_distribuicaoContratos);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    break;
                case "status":
                    var CodigoDistContrato = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    v_StatusContrato v_statusContrato = new v_StatusContrato(_usuarioCad,CodigoDistContrato);
                    v_statusContrato.ShowDialog();
                    break;
                
                default:
                    break;
            }
        }
        private void Permissao()
        {
            switch (_permissao)
            {
                case 1:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    break;
                case 2:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = false;
                    
                    break;
                case 3:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = true;
                    
                    break;
                case 4:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = true;
                    
                    break;
                default:
                    break;
            }

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja excluir a distribuição selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("excluir");
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja alterar os dados da distribuição selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("alterar");
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            v_NovaDistribuicaoContrato v_novaDist = new v_NovaDistribuicaoContrato(_usuarioCad);
            v_novaDist.ShowDialog();
        }

        private void btnImprimirProtocolo_Click(object sender, EventArgs e)
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

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1 && (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == 0)
                {
                    funcao("status");
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == 1)
                {
                    string DataDevolucao = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9]).ToString();
                    MessageBox.Show("Contrato Cancelado no dia :" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == 2)
                {
                    string DataDevolucao = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]).ToString();
                    MessageBox.Show("Contrato devolvido para o stand no dia:" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == 3)
                {
                    string DataDevolucao = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString();
                    MessageBox.Show("Contrato Extraviado informado a perca no dia :" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == 4)
                {
                    string DataVenda = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[12]).ToString();
                    MessageBox.Show("Contrato passado venda, data da venda: " + DataVenda.Replace("00:00:00", "") + "...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void gridControl1_EmbeddedNavigator_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void advBandedGridView1_CustomFilterDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {

        }

        private void advBandedGridView1_CustomColumnDisplayText_1(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            /*
             Distribuido = 0,
             Cancelado = 1,
             Devolvido = 2,
             Extraviado = 3,
             Vendido = 4
            */

            if (e.Column.FieldName == "status")
            {
                if ((int)e.Value == 0) e.DisplayText = "0 - Distribuido";
                if ((int)e.Value == 1) e.DisplayText = "1 - Cancelado";
                if ((int)e.Value == 2) e.DisplayText = "2 - Devolvido";
                if ((int)e.Value == 3) e.DisplayText = "3 - Extraviado";
                if ((int)e.Value == 4) e.DisplayText = "4 - Vendido";
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
