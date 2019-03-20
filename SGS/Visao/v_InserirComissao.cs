

using DevExpress.CodeParser;
using DevExpress.DataAccess.Excel;
using DevExpress.Export.Xl;
using DevExpress.XtraGrid.Views.BandedGrid;
using SGS.Controle;
using SGS.Enum;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraSpreadsheet;
using OfficeOpenXml;

namespace SGS.Visao
{
    public partial class v_InserirComissao : DevExpress.XtraEditors.XtraForm
    {
        string _UsuarioCad;
        m_Comissoes m_comissoes;
        c_Comissoes c_comissoes;

        public v_InserirComissao()
        {
            InitializeComponent();
        }
        public v_InserirComissao(string UsuarioCad)
        {
            InitializeComponent();
            m_comissoes = new m_Comissoes();
            c_comissoes = new c_Comissoes();
            _UsuarioCad = UsuarioCad;
        }
        
        private void v_InserirComissao_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (advBandedGridView1.RowCount > 1)
            {
                advBandedGridView1.FocusedRowHandle = 0;
                advBandedGridView1.SelectRow(0);
                advBandedGridView1.ActiveFilter.Clear();
                gridControl1.Enabled = false;
                for (int i = 0; i < advBandedGridView1.RowCount; i++)
                
                {

                    m_comissoes.empresa = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]).ToString();
                    m_comissoes.venda = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString();
                    m_comissoes.obra = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString();
                    m_comissoes.corretor_pf = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString();
                    m_comissoes.NomeCliente = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString();
                    m_comissoes.quadra = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]).ToString();
                    m_comissoes.lote = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]).ToString();
                    m_comissoes.statusvenda = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]).ToString();
                    m_comissoes.DataVenda = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]);
                    m_comissoes.datacadvenda = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9]);
                    m_comissoes.valorvenda = Convert.ToDecimal(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]));
                    m_comissoes.tipoparcela = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[11]).ToString();
                    m_comissoes.parcelacomissao = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[12]));
                    m_comissoes.totalparcelacomissao = Convert.ToInt32(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[13]));
                    m_comissoes.vencimentoparcela = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[14]);
                    m_comissoes.valorparcela = Convert.ToDecimal(advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[15]));
                    m_comissoes.usuariocad = _UsuarioCad;
                    m_comissoes.datacadcomissao = DateTime.Now;
                    m_comissoes.statuscomissao = (int)e_StatusComissao.Nao_Liberada;
                    c_comissoes.NovasComissoes(m_comissoes);
                    advBandedGridView1.MoveNext();
                }
                MessageBox.Show("Comissão(s) inserida(s) com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
            
            

        }
        
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel(xlsx)|*.xlsx", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    //Metodo 1
                    DevExpress.DataAccess.Excel.ExcelDataSource myExcelSource = new DevExpress.DataAccess.Excel.ExcelDataSource();
                    myExcelSource.FileName = ofd.FileName;
                    ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("DADOS");
                    myExcelSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
                    myExcelSource.SourceOptions.SkipEmptyRows = false;
                    myExcelSource.SourceOptions.UseFirstRowAsHeader = true;
                    myExcelSource.Fill();
                    gridControl1.DataSource = myExcelSource;
                    advBandedGridView1.BestFitColumns(true);


                    //Metodo 2

                    /*String name = "DADOS";
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                    textBox1.Text +
                                    ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    gridControl1.DataSource = data;*/
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanilhaExemplo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel(xlsx)|*.xlsx", ValidateNames = true })
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        excel.Workbook.Worksheets.Add("DADOS");
                        

                        var headerRow = new List<string[]>()
                          {
                            new string[] { "empresa", "venda", "obra", "corretor","cliente","qd","lt","statusveda","datavenda","datacad","vlrvenda","parcelatipo","parcela","qtdparc","vencimento","valorparcela" }
                          };

                        // Determine the header range (e.g. A1:D1)
                        string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

                        // Target a worksheet
                        var worksheet = excel.Workbook.Worksheets["DADOS"];

                        // Popular header row data
                        worksheet.Cells[headerRange].LoadFromArrays(headerRow);

                        FileInfo excelFile = new FileInfo(sfd.FileName);
                        excel.SaveAs(excelFile);
                        MessageBox.Show("Planilha de exemplo para inserir comissões via excel no Sistema criado com Sucesso!\nOBS:Não altere o cabeçalho das colunas pois já estar no nome padrão que o sistema entendi...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

        }
    }
}
