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
    public partial class v_Loteamento : DevExpress.XtraBars.TabForm
    {
        m_Loteamento m_loteamento;
        c_Loteamento c_loteamento;
        string _usuariocad;
        int _permissao;
        bool _alterarCad = false;
        public v_Loteamento()
        {
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            InitializeComponent();
            
        }
        public v_Loteamento(string UsuarioCad,int Permissao)
        {
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            InitializeComponent();
            
            _usuariocad = UsuarioCad;
            _permissao = Permissao;
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtObra.Text = string.Empty;
            txtDataCad.Text = string.Empty;
        }
        private void Permissao()
        {
            switch (_permissao)
            {
                case 1:
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnNovo.Enabled = false;
                    break;
                case 2:
                    btnExcluir.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnNovo.Enabled = false;
                    break;
                case 3:
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnNovo.Enabled = false;
                    break;
                case 4:
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnNovo.Enabled = true;
                    break;
                default:
                    break;
            }

        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novo":
                    _alterarCad = false;
                    LimparCampos();
                    gbxNovo.Enabled = true;
                    txtDataCad.Text = DateTime.Now.ToShortDateString();
                    tabFormControl1.SelectedPage = tabFormPageNovo;
                    txtNome.Focus();


                    break;
                case "cancelarnovo":
                    LimparCampos();
                    gbxNovo.Enabled = false;

                    tabFormControl1.SelectedPage = tabFormPageEmp;
                    break;
                case "excluir":
                    //<SEU_GRID>.GetRowCellValue(SEU_GRID.GetSelectedRows()[index], SEU_GRID.Columns[0]);
                    m_loteamento.idloteamento = (int)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]);
                    c_loteamento.ExcluirLoteamento(m_loteamento);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.loteamentoTableAdapter.Fill(this.dbsgsDataSet.loteamento);
                    break;
                case "alterar":
                    _alterarCad = true;
                    gbxNovo.Enabled = true;
                    m_loteamento.idloteamento = (int)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]);
                    txtNome.Text = (string)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[1]);
                    txtDataCad.Text = Convert.ToString(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[2])).Replace("00:00:00","");
                    txtEmpresa.Text = (string)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[5]);
                    txtObra.Text = (string)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[4]);
                    if ((int)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[3]) == 1)
                    {
                        rbtAtivo.Checked = true;
                    }
                    else if ((int)gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[3]) == 0)
                    {
                        rbtInativo.Checked = true;
                    }
                    Permissao();
                    tabFormControl1.SelectedPage = tabFormPageNovo;
                    break;
                case "salvar":
                    m_loteamento.nome = txtNome.Text;
                    m_loteamento.obra = txtObra.Text;
                    m_loteamento.empresa = txtEmpresa.Text;
                    m_loteamento.datacad = Convert.ToDateTime(txtDataCad.Text);
                    m_loteamento.usuariocad = _usuariocad;
                    //status = 1 e ativo e status = 0 e inativo;
                    if (rbtAtivo.Checked == true)
                    {
                        m_loteamento.status = 1;
                    }
                    else if (rbtInativo.Checked == true)
                    {
                        m_loteamento.status = 0;
                    }

                    if (_alterarCad == true)
                    {
                        c_loteamento.AlterarLoteamento(m_loteamento);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (_alterarCad == false)
                    {
                        c_loteamento.NovoLoteamento(m_loteamento);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LimparCampos();
                    gbxNovo.Enabled = false;
                    this.loteamentoTableAdapter.Fill(this.dbsgsDataSet.loteamento);
                    tabFormControl1.SelectedPage = tabFormPageEmp;

                    break;
                default:
                    break;
            }
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void v_Loteamento_Load(object sender, EventArgs e)
        {
            
            gbxNovo.Enabled = false;
            CancelButton = btnVoltar;
            tabFormControl1.SelectedPage = tabFormPageEmp;
            Permissao();
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.loteamento'. Você pode movê-la ou removê-la conforme necessário.
            this.loteamentoTableAdapter.Fill(this.dbsgsDataSet.loteamento);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir o Empreendimento selecionado?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (gridView1.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja alterar o Empreendimento selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o novo cadastro de Empreendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcao("cancelarnovo");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtEmpresa.Text != string.Empty && txtObra.Text != string.Empty)
            {
                if (_alterarCad == true)
                {
                    if (MessageBox.Show("Deseja salvar as alterações do cadastro do Empreendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("salvar");
                    }
                }
                else if (_alterarCad == false)
                {
                    if (MessageBox.Show("Deseja salvar cadastro do novo Empreendimento?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
