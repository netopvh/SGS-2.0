using SGS.Controle;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Enum;
namespace SGS.Visao
{
    public partial class v_Corretor : DevExpress.XtraBars.TabForm
    {
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        bool _alterarCad;
        string _usuariocad;
        int _permissao;
        public v_Corretor()
        {
            InitializeComponent();

            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
        }
        public v_Corretor(string UsuarioCad,int Permissao)
        {
            InitializeComponent();

            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            _usuariocad = UsuarioCad;
            _permissao = Permissao;
           
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            m_corretor.nome = null;
            m_corretor.cpf = null;
            m_corretor.email = null;
            m_corretor.telefone = null;
            
            
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novocorretor":
                    _alterarCad = false;
                    LimparCampos();
                    gbxNovoCorretor.Enabled = true;
                    tabFormControl.SelectedPage = tabFormPageNovoCorretor;
                    txtNome.Focus();

                    break;
                case "cancelarnovo":
                    LimparCampos();
                    gbxNovoCorretor.Enabled = false;
                    
                    tabFormControl.SelectedPage = tabFormPageCorretores;
                    break;
                case "excluir":
                    try
                    {
                        //<SEU_GRID>.GetRowCellValue(SEU_GRID.GetSelectedRows()[index], SEU_GRID.Columns[0]);
                        m_corretor.idcorretor = (int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[0]);
                        c_corretor.ExcluirCorretor(m_corretor);
                        MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCorretores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:"+ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    
                    break;
                case "alterar":
                    _alterarCad = true;
                    gbxNovoCorretor.Enabled = true;
                    m_corretor.idcorretor = (int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[0]);
                    txtNome.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[1]);
                    txtCPF.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[2]);
                    txtTelefone.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[3]);
                    txtEmail.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[4]);
                    if ((int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[5]) == 1)
                    {
                        rbtAtivo.Checked = true;
                    }
                    else if ((int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[5]) == 0)
                    {
                        rbtInativo.Checked = true;
                    }
                    
                    tabFormControl.SelectedPage = tabFormPageNovoCorretor;
                    break;
                case "salvar":
                    m_corretor.nome = txtNome.Text;
                    m_corretor.cpf = txtCPF.Text.Replace("-", "");
                    m_corretor.email = txtEmail.Text;
                    m_corretor.telefone = txtTelefone.Text;
                    m_corretor.usuariocad = _usuariocad;
                    //status = 1 e ativo e status = 0 e inativo;
                    if (rbtAtivo.Checked == true)
                    {
                        m_corretor.status = (int)e_Status.Ativo;
                    }
                    else if (rbtInativo.Checked == true)
                    {
                        m_corretor.status = (int)e_Status.Inativo;
                    }

                    if (_alterarCad == true)
                    {
                        c_corretor.AlterarCorretor(m_corretor);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCorretores();
                    }
                    else if (_alterarCad == false)
                    {
                        c_corretor.NovoCorretor(m_corretor);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarCorretores();
                    }
                    
                    LimparCampos();
                    gbxNovoCorretor.Enabled = false;
                    
                    tabFormControl.SelectedPage = tabFormPageCorretores;

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
            if (gdvCorretores.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir o corretor selecionado?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
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
            if (gdvCorretores.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja alterar o corretor selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            funcao("novocorretor");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o novo cadastro de Corretor?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcao("cancelarnovo");
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtCPF.Text != string.Empty)
            {
                if (_alterarCad == true)
                {
                    if (MessageBox.Show("Deseja salvar as alterações do cadastro do Corretor?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("salvar");
                    }
                }
                else if (_alterarCad == false)
                {
                    if (MessageBox.Show("Deseja salvar cadastro do novo Corretor?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        
        private void v_Corretor_Load(object sender, EventArgs e)
        {
            _alterarCad = false;
            CancelButton = btnVoltar;
            gbxNovoCorretor.Enabled = false;
            tabFormControl.SelectedPage = tabFormPageCorretores;
            
            CarregarCorretores();
            gdvCorretores.BestFitColumns(true);
            
        }

        private void CarregarCorretores()
        {
            DataTable dtCorretores = new DataTable();
            dtCorretores = c_corretor.CarregarCorretores();
            gdvCorretores.GridControl.DataSource = dtCorretores;
            gdvCorretores.RefreshData();

        }

        private void tabFormControl_Click(object sender, EventArgs e)
        {

        }

        private void corretorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_EditValueChanged(object sender, EventArgs e)
        {
               
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text != string.Empty)
            {
                c_ValidarCPF.ValidarCPF(txtCPF);
            }
            
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty)
            {
                c_ValidarEmail.ValidarEmail(txtEmail);
            }
            
        }
    }
}
