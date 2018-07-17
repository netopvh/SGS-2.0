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
    public partial class v_Corretor : DevExpress.XtraBars.TabForm
    {
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        bool alterarCad;
        public v_Corretor()
        {
            InitializeComponent();

            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
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
                    alterarCad = false;
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
                    //<SEU_GRID>.GetRowCellValue(SEU_GRID.GetSelectedRows()[index], SEU_GRID.Columns[0]);
                    m_corretor.idcorretor = (int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0],gdvCorretores.Columns[0]);
                    c_corretor.ExcluirCorretor(m_corretor);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.corretorTableAdapter.Fill(this.dbsgsDataSet.corretor);
                    break;
                case "alterar":
                    alterarCad = true;
                    gbxNovoCorretor.Enabled = true;
                    m_corretor.idcorretor = (int)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[0]);
                    txtNome.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[1]);
                    txtCPF.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[2]);
                    txtTelefone.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[3]);
                    txtEmail.Text = (string)gdvCorretores.GetRowCellValue(gdvCorretores.GetSelectedRows()[0], gdvCorretores.Columns[4]);

                    tabFormControl.SelectedPage = tabFormPageNovoCorretor;
                    break;
                case "salvar":
                    m_corretor.nome = txtNome.Text;
                    m_corretor.cpf = txtCPF.Text.Replace("-", "");
                    m_corretor.email = txtEmail.Text;
                    m_corretor.telefone = txtTelefone.Text;

                    if (alterarCad == true)
                    {
                        c_corretor.AlterarCorretor(m_corretor);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (alterarCad == false)
                    {
                        c_corretor.NovoCorretor(m_corretor);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    LimparCampos();
                    gbxNovoCorretor.Enabled = false;
                    this.corretorTableAdapter.Fill(this.dbsgsDataSet.corretor);
                    
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
            if (alterarCad == true)
            {
                if (MessageBox.Show("Deseja salvar as alterações do cadastro do Corretor?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("salvar");
                }
            }
            else if (alterarCad == false)
            {
                if (MessageBox.Show("Deseja salvar cadastro do novo Corretor?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("salvar");
                }
            }
            
            
        }

        private void v_Corretor_Load(object sender, EventArgs e)
        {
            alterarCad = false;
            CancelButton = btnVoltar;
            gbxNovoCorretor.Enabled = false;
            tabFormControl.SelectedPage = tabFormPageCorretores;
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.corretor'. Você pode movê-la ou removê-la conforme necessário.
            this.corretorTableAdapter.Fill(this.dbsgsDataSet.corretor);

        }
    }
}
