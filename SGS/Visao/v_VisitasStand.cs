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
        v_NovoAtendimento v_novoAtendimento;
        m_Atendimento m_atendimento;
        c_Atendimento c_atendimento;
        public v_VisitasStand()
        {
            InitializeComponent();
            this.m_atendimento = new m_Atendimento();
            this.v_novoAtendimento = new v_NovoAtendimento();
            this.c_atendimento = new c_Atendimento();
        }
        public v_VisitasStand(int Permissao,string UsuarioCad)
        {
            InitializeComponent();
            _Permissao = Permissao;
            _UsuarioCad = UsuarioCad;
            this.m_atendimento = new m_Atendimento();
            this.v_novoAtendimento = new v_NovoAtendimento(_UsuarioCad);
            this.c_atendimento = new c_Atendimento();
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novo":
                    v_novoAtendimento.Name = "Novo Atendimento";
                    v_novoAtendimento.ShowDialog();
                    
                    break;
                case "alterar":
                    v_novoAtendimento.Name = "Alterar Atendimento";
                    v_novoAtendimento.ShowDialog();
                    
                    break;
                case "excluir":
                    m_atendimento.idatendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                    c_atendimento.ExcluirAtendimento(m_atendimento);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.atendimentoTableAdapter.Fill(this.dbsgsDataSet.atendimento);
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

        private void v_VisitasStand_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.atendimento'. Você pode movê-la ou removê-la conforme necessário.
            this.atendimentoTableAdapter.Fill(this.dbsgsDataSet.atendimento);
            //advBandedGridView1.BestFitColumns(true);
            Permissao();
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

        private void btnComprou_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma que o cliente comprou o lote?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                m_atendimento.idatendimento = (int)advBandedGridView1.GetRowCellValue(advBandedGridView1.GetSelectedRows()[0], advBandedGridView1.Columns[0]);
                c_atendimento.AlterarAtendimentoParaComprou(m_atendimento);
                MessageBox.Show("Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.atendimentoTableAdapter.Fill(this.dbsgsDataSet.atendimento);
            }
        }
    }
}
