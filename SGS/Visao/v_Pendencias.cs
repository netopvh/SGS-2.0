﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Modelo;
using SGS.Controle;
using SGS.Enum;
using DevExpress.XtraEditors.Controls;

namespace SGS.Visao
{
    public partial class v_Pendencias : DevExpress.XtraBars.TabForm
    {

        c_Pendencias c_pendencias;
        m_Pendencias m_pendencias;
        c_Loteamento c_loteamento;
        m_Loteamento m_loteamento;
        c_Corretor c_corretor;
        m_Corretor m_corretor;

        string _usuariocad;
        int _permissao;
        bool _alterarCad;
        public v_Pendencias()
        {
            
            InitializeComponent();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
        }
        public v_Pendencias(string Usuario,int Permissao)
        {
            
            InitializeComponent();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            _usuariocad = Usuario;
            _permissao = Permissao;
            
        }
        private void LimparCampos()
        {
            txtCliente.Text = string.Empty;
            txtLote.Text = string.Empty;
            txtNumeroContrato.Text = string.Empty;
            txtPendencia.Text = string.Empty;
            txtQuadra.Text = string.Empty;
            txtVenda.Text = string.Empty;
            LookUpEditLoteamento.Text = string.Empty;
            LookUpEditCorretor.Text = string.Empty;
            LookUpEditCorretor.EditValue = -1;
            LookUpEditLoteamento.EditValue = -1;
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novapendencia":
                    _alterarCad = false;
                    LimparCampos();
                    tabFormControl1.SelectedPage = tabFormPageNovaPendencia;
                    gbxNovaPendencia.Enabled = true;
                    dteDataCadPendencia.EditValue = DateTime.Now;

                    break;
                case "cancelarnovo":
                    LimparCampos();
                    gbxNovaPendencia.Enabled = false;
                    tabFormControl1.SelectedPage = tabFormPagePendencias;

                    break;
                case "excluir":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    c_pendencias.ExcluirPendencias(m_pendencias);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.pendencias_cor_lote_TableAdapter.Fill(this.dbsgsDataSet.pendencias_corretor_loteamento);

                    break;
                case "alterar":
                    _alterarCad = true;
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    LookUpEditLoteamento.EditValue = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[1]);
                    LookUpEditCorretor.EditValue = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[3]);
                    txtQuadra.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]);
                    txtLote.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]);
                    txtCliente.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[7]);
                    txtVenda.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]);
                    txtNumeroContrato.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[9]);
                    txtPendencia.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]);
                    dteDataVenda.EditValue = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString().Replace("00:00:00","");
                    dteDataCadastroVenda.EditValue = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[13]).ToString().Replace("00:00:00", "");
                    dteDataCadPendencia.EditValue = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[14]).ToString().Replace("00:00:00", "");
                    _usuariocad = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[15]);
                    tabFormControl1.SelectedPage = tabFormPageNovaPendencia;
                    gbxNovaPendencia.Enabled = true;

                    break;
                case "devolvido":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    m_pendencias.status = (int)e_StatusPendencia.Resolvido;
                    m_pendencias.datadevolucao = DateTime.Now;
                    m_pendencias.usuariocad = _usuariocad;
                    c_pendencias.AlterarPendenciaParaResolvido(m_pendencias);
                    MessageBox.Show("Devolvido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.pendencias_cor_lote_TableAdapter.Fill(this.dbsgsDataSet.pendencias_corretor_loteamento);
                    break;
                case "entregar":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    m_pendencias.status = (int)e_StatusPendencia.Corretor;
                    m_pendencias.dataentregacorretor = DateTime.Now;
                    m_pendencias.usuariocad = _usuariocad;
                    c_pendencias.AlterarPendenciaParaCorretor(m_pendencias);
                    MessageBox.Show("Entregue com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.pendencias_cor_lote_TableAdapter.Fill(this.dbsgsDataSet.pendencias_corretor_loteamento);
                    break;
                case "salvar":
                    m_pendencias.nomecliente = txtCliente.Text;
                    m_pendencias.quadra = txtQuadra.Text;
                    m_pendencias.lote = txtLote.Text;
                    m_pendencias.numerocontrato = txtNumeroContrato.Text;
                    m_pendencias.pendencia = txtPendencia.Text;
                    m_pendencias.usuariocad = _usuariocad;
                    m_pendencias.datacadastro = Convert.ToDateTime(dteDataCadastroVenda.Text.ToString().Replace("00:00:00", ""));
                    m_pendencias.datavenda = Convert.ToDateTime(dteDataVenda.Text.ToString().Replace("00:00:00", ""));
                    m_pendencias.datacadpendencia = Convert.ToDateTime(dteDataCadPendencia.Text);
                    m_pendencias.venda = txtVenda.Text;
                    m_pendencias.fk_corretor_pendencias = (int)LookUpEditCorretor.EditValue;
                    m_pendencias.fk_loteamento_pendencias = (int)LookUpEditLoteamento.EditValue;
                    //Status pendencia 0 = corretor, 1 = resolvido.
                    m_pendencias.status = (int)e_StatusPendencia.A_Resolver;


                    if (_alterarCad == true)
                    {
                        c_pendencias.AlterarPendencias(m_pendencias);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (_alterarCad == false)
                    {
                        c_pendencias.NovoPendencias(m_pendencias);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LimparCampos();
                    gbxNovaPendencia.Enabled = false;
                    this.pendencias_cor_lote_TableAdapter.Fill(this.dbsgsDataSet.pendencias_corretor_loteamento);
                    tabFormControl1.SelectedPage = tabFormPagePendencias;
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
                    break;
                case 2:
                    btnExcluir.Enabled = true;
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
            if (gdvPendencias.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir a pendência selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (gdvPendencias.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja alterar os dados da Pendência selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            funcao("novapendencia");
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void v_Pendencias_Load(object sender, EventArgs e)
        {
            txtQuadra.Properties.MaxLength = 3;
            txtLote.Properties.MaxLength = 3;
            txtVenda.Properties.MaxLength = 10;
            txtNumeroContrato.Properties.MaxLength = 10;
            txtPendencia.MaxLength = 150;
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.pendencias_corretor_loteamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pendencias_cor_lote_TableAdapter.Fill(this.dbsgsDataSet.pendencias_corretor_loteamento);

            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.corretor'. Você pode movê-la ou removê-la conforme necessário.
            this.corretorTableAdapter.Fill(this.dbsgsDataSet.corretor);
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.loteamento'. Você pode movê-la ou removê-la conforme necessário.
            this.loteamentoTableAdapter.Fill(this.dbsgsDataSet.loteamento);
            _alterarCad = false;
            CancelButton = btnVoltar;
            LimparCampos();
            gbxNovaPendencia.Enabled = false;
            tabFormControl1.SelectedPage = tabFormPagePendencias;
            Permissao();
        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funcao("cancelarnovo");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != string.Empty && txtPendencia.Text != string.Empty && txtQuadra.Text != string.Empty && txtLote.Text != string.Empty)
            {
                if (_alterarCad == true)
                {
                    if (MessageBox.Show("Deseja salvar as alterações do cadastro da Pendência?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("salvar");
                    }
                }
                else if (_alterarCad == false)
                {
                    if (MessageBox.Show("Deseja salvar o cadastro da nova Pendência?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("salvar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos!...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loteamentoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 1)
            {
                if (MessageBox.Show("Deseja da baixar nesse contrato pendênte como devolvido?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("devolvido");
                }
            }
            else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 2)
            {
                string DataDevolucao = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[16]).ToString();
                MessageBox.Show("Contrato pendênte já devolvido para o stand no dia:"+DataDevolucao+"Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 0)
            {
                
                MessageBox.Show("Contrato deve ser entregue primeiro para o Corretor resolver a pendência no botão (Corretor)!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dteDataVenda_EditValueChanging(object sender, ChangingEventArgs e)
        {
           
        }

        private void dteDataVenda_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar grid em Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Arquivo = saveFileDialog1.FileName;
                gdvPendencias.ExportToXlsx(Arquivo);
                MessageBox.Show("Exportado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você não escolheu um caminho para salvar o arquivo...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void gdvPendencias_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "status")
            {
                if ((int)e.Value == 0) e.DisplayText = "0 - A Resolver";
                if ((int)e.Value == 1) e.DisplayText = "1 - Corretor";
                if ((int)e.Value == 2) e.DisplayText = "2 - Resolvido";
            }
        }

        private void btnEntregarPendencia_Click(object sender, EventArgs e)
        {
            if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 0)
            {
                if (MessageBox.Show("Deseja entregar esse contrato para o Corretor resolver a pendência?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("entregar");
                }
            }
            
            else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 1)
            {
                string DataEntregue = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[17]).ToString();
                MessageBox.Show("Contrato pendênte entregue para o corretor resolver a pendência no dia:" + DataEntregue + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 2)
            {
                string DataDevolucao = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[16]).ToString();
                MessageBox.Show("Contrato pendênte já devolvido para o stand no dia:" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
