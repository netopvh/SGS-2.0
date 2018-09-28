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
    public partial class v_VisitasStand : DevExpress.XtraEditors.XtraForm
    {
        int _Permissao;
        string _UsuarioCad;
        
        m_Atendimento m_atendimento;
        c_Atendimento c_atendimento;
        public v_VisitasStand()
        {
            InitializeComponent();
            this.m_atendimento = new m_Atendimento();
            this.c_atendimento = new c_Atendimento();
        }
        public v_VisitasStand(int Permissao,string UsuarioCad)
        {
            InitializeComponent();
            this.m_atendimento = new m_Atendimento();
            this.c_atendimento = new c_Atendimento();
            _Permissao = Permissao;
            _UsuarioCad = UsuarioCad;
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novo":
                    v_NovoAtendimento v_novoAtendimento = new v_NovoAtendimento(_UsuarioCad);
                    v_novoAtendimento.Name = "Novo Atendimento";
                    v_novoAtendimento.ShowDialog();
                    
                    break;
                case "alterar":
                    
                    m_atendimento.idatendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    m_atendimento.nomeCliente = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString();
                    m_atendimento.telefone = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString();
                    m_atendimento.cidadeUF = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]).ToString();
                    m_atendimento.corretorAtual = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString();
                    m_atendimento.atendimentoAnterior = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString();
                    m_atendimento.empreendimento = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9]).ToString();
                    m_atendimento.identificador = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString();
                    m_atendimento.localizou = advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]).ToString();
                    m_atendimento.dataAtendimento = (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]);
                    m_atendimento.usuariocad = _UsuarioCad;

                    v_NovoAtendimento v_AlterarAtendimento = new v_NovoAtendimento(
                        this.m_atendimento.idatendimento,m_atendimento.nomeCliente,m_atendimento.telefone,m_atendimento.cidadeUF,
                        m_atendimento.corretorAtual,m_atendimento.atendimentoAnterior,m_atendimento.empreendimento,m_atendimento.identificador,
                        m_atendimento.localizou,m_atendimento.dataAtendimento,m_atendimento.usuariocad,true);


                    /*
                     int CodigoAtendimento,string NomeCliente,string Telefone,string CidadeEstado,string CorretorAtual,
        string CorretorAtdAnterior,string Empreendimento,string Identificador,string Localizou,DateTime DataCadastroAtend,string UsuarioCad,bool Alterar
        */
        /*
                    v_NovoAtendimento v_AlterarAtendimento = new v_NovoAtendimento
                        ((int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[1]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[2]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[7]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[8]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[3]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[9]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[4]).ToString(),
                        advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[5]).ToString(),
                        (DateTime)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[10]),
                        _UsuarioCad,true);
                        */

                    v_AlterarAtendimento.Name = "Alterar Atendimento";
                    v_AlterarAtendimento.ShowDialog();
                    
                    break;
                case "excluir":
                    m_atendimento.idatendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_atendimento.ExcluirAtendimento(m_atendimento);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarAtendimentos();
                    break;
                
                default:
                    break;
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
                    btnComprou.Enabled = false;
                    break;
                case 2:
                    btnComprou.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = false;
                    break;
                case 3:
                    btnComprou.Enabled = true;
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

        private void v_VisitasStand_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            //advBandedGridView1.BestFitColumns(true);
            CarregarAtendimentos();
            BestFitBand(gridBand1);
            Permissao();
        }
        public void CarregarAtendimentos()
        {
            DataTable dtAtendimentos = new DataTable();
            dtAtendimentos = c_atendimento.CarregarAtendimentos();
            gridControl1.DataSource = dtAtendimentos;
            advBandedGridView1.RefreshData();
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (advBandedGridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir o Atendimento selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("excluir");
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
                if (MessageBox.Show("Deseja Alterar o Atendimento selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("alterar");
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            funcao("novo");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
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
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnComprou_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que o cliente comprou o lote?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                m_atendimento.idatendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                c_atendimento.AlterarAtendimentoParaComprou(m_atendimento);
                MessageBox.Show("Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void v_VisitasStand_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnComprou_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (advBandedGridView1.SelectedRowsCount == 1)
                {
                    if ((string)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[6]) == "NÃO")
                    {
                        int CodigoAtendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);

                        v_InformarData v_InformarDataCompra = new v_InformarData(CodigoAtendimento, _UsuarioCad);
                        v_InformarDataCompra.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Já informado que o cliente comprou o lote!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void v_VisitasStand_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarAtendimentos();
        }
    }
}
