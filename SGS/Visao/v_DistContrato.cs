using DevExpress.XtraGrid.Views.BandedGrid;
using SGS.Controle;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        int iRetorno = 0; //Variável para retorno das chamadas
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
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString(),
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
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                var status = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]);
                var DataDistribuicao = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]);
                var NumeroContrato = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]);
                var Corretor = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]);
                var Loteamento = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]);
                var UsuarioCad = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[11]);
                
                
                

                var Impressao = "";
                switch (status)
                {
                    case 0:
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (0 - DISTRIBUIDO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Número Contrato: " + NumeroContrato + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n"+
                    "Confirmo recebimento do contrato com todos as páginas";
                        break;
                    case 1:
                        var DataCancelamento = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9]);
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (1 - CANCELADO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Data Cancelamento: " + DataCancelamento + "\n" +
                    "Número Contrato: " + NumeroContrato + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que estou cancelando esse contrato.";
                        break;
                    case 2:
                        var DataDevolucao = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]);
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (2 - DEVOLVIDO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Data Devolução: " + DataDevolucao + "\n" +
                    "Número Contrato: " + NumeroContrato + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que estou recebendo o contrato de volta.";
                        break;
                    case 3:
                        var DataExtravio = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]);
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (3 - EXTRAVIADO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Data Extravio: " + DataExtravio + "\n" +
                    "Número Contrato: " + NumeroContrato + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que o contrato foi perdido ou roubado.";
                        break;
                    case 4:
                        MessageBox.Show("Contrato usado venda passada!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                string Porta = (ConfigurationManager.AppSettings["Porta"]);
                if (Porta.ToString() == "ETHERNET")
                {
                    string Ip = (ConfigurationManager.AppSettings["Ip"]);
                    iRetorno = MP2064.IniciaPorta(Ip);
                }
                else
                {
                    iRetorno = MP2064.IniciaPorta(Porta);
                }

                // \n - quebra de linha e \r retorno de impressão (comandos da impressora)
                iRetorno = MP2064.FormataTX("\r\n\r\n" + Impressao + "\r\n\r\n", 2, 0, 0, 0, 1);//ao ser clicado, imprime 
                iRetorno = MP2064.AcionaGuilhotina(1);//chama a função da DLL(Corte Total)


            }
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

        private void bbiImprimirGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            advBandedGridView1.ShowRibbonPrintPreview();
        }
    }
}
