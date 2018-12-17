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
using DevExpress.XtraGrid.Views.BandedGrid;
using SGS.Controle;
using SGS.Modelo;
namespace SGS.Visao
{
    public partial class v_DistFolhaAvulso : DevExpress.XtraBars.TabForm
    {
        string _UsuarioCad;
        int _Permissao;
        int iRetorno = 0; //Variável para retorno das chamadas
        c_DistribuicaoFolhasAvulsas c_distFolhasAvulsas;
        m_DistribuicaoFolhasAvulsas m_distFolhasAvulsas;
        public v_DistFolhaAvulso()
        {
            InitializeComponent();
            this.c_distFolhasAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_distFolhasAvulsas = new m_DistribuicaoFolhasAvulsas();
        }
        public v_DistFolhaAvulso(int Permissao,string UsuarioCad)
        {
            InitializeComponent();
            _UsuarioCad = UsuarioCad;
            this.c_distFolhasAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_distFolhasAvulsas = new m_DistribuicaoFolhasAvulsas();
        }

        private void v_DistFolhaAvulso_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            Permissao();
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
            gridControl1.DataSource = c_distFolhasAvulsas.CarregarDistribuicoes();
            gridControl1.Refresh();
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "alterar":
                    v_NovaDistribuicaoFolhaAvulso v_AltearDist = new v_NovaDistribuicaoFolhaAvulso(
                        Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0])),
                        Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9])),
                        Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[11])),
                        Convert.ToDateTime(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3])),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString(),
                        Convert.ToDecimal(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7])),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString(),
                        true);
                    v_AltearDist.ShowDialog();
                    break;
                case "excluir":
                    m_distFolhasAvulsas.iddistribuicaofolhasavulsas = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_distFolhasAvulsas.ExcluirDistribuicao(m_distFolhasAvulsas);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    break;
                case "status":
                    var CodigoDistFolha = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    v_StatusFolhaAvulso v_statusFolha = new v_StatusFolhaAvulso(CodigoDistFolha,_UsuarioCad);
                    v_statusFolha.ShowDialog();
                    break;

                default:
                    break;
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            v_NovaDistribuicaoFolhaAvulso v_novaDist = new v_NovaDistribuicaoFolhaAvulso(_UsuarioCad);
            v_novaDist.ShowDialog();
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

        private void btnImprimirProtocolo_Click(object sender, EventArgs e)
        {
            
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                var status = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]);
                var DataDistribuicao = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]);
                var FolhaNumero = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]);
                var Corretor = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]);
                var Loteamento = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[12]);
                var UsuarioCad = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]);
                var ValorFolha = Convert.ToString(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]));
                var Pagamento = (string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]);


                var Impressao = "";
                switch (status)
                {
                    case 0:
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (0 - DISTRIBUIDO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Folha Número: " + FolhaNumero + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "Forma Pagamento:"+Pagamento+"\n"+
                    "Valor Folha R$:"+ValorFolha+"\n"+
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que recebi a folha.";
                        break;
                    case 1:
                        var DataCancelamento = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]);
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (1 - CANCELADO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Data Cancelamento: " + DataCancelamento + "\n" +
                    "Folha Número: " + FolhaNumero + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "Forma Pagamento:" + Pagamento + "\n" +
                    "Valor Folha R$:" + ValorFolha + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que estou cancelando a dist. dessa folha";
                        break;
                    case 2:
                        var DataDevolucao = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]);
                        Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (2 - DEVOLVIDO)\n" +
                    "Data Distribuição: " + DataDistribuicao + "\n" +
                    "Data Devolução: " + DataDevolucao + "\n" +
                    "Folha Número: " + FolhaNumero + "\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n" +
                    "Forma Pagamento:" + Pagamento + "\n" +
                    "Valor Folha R$:" + ValorFolha + "\n" +
                    "\n" +
                    "Usuário Cad: " + UsuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo que estou recebendo a folha de volta.";
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void bbiImprimirGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            advBandedGridView1.ShowRibbonPrintPreview();
        }

        private void advBandedGridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            /*
             Distribuido = 0,
             Cancelado = 1,
             Devolvido = 2,
            */

            if (e.Column.FieldName == "status")
            {
                if ((int)e.Value == 0) e.DisplayText = "0 - Distribuido";
                if ((int)e.Value == 1) e.DisplayText = "1 - Cancelado";
                if ((int)e.Value == 2) e.DisplayText = "2 - Devolvido";
            }
        }
        private void Permissao()
        {
            switch (_Permissao)
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

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1 && (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]) == 0)
                {
                    funcao("status");
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]) == 1)
                {
                    string DataCanleado = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString();
                    MessageBox.Show("Folha Cancelada no dia :" + DataCanleado + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]) == 2)
                {
                    string DataDevolucao = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]).ToString();
                    MessageBox.Show("Folha Devolvida para o stand no dia:" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
