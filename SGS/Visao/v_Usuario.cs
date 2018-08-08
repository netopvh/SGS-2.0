using System;
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

namespace SGS.Visao
{
    public partial class v_Usuario : DevExpress.XtraBars.TabForm
    {
        m_Usuario m_usuario;
        c_Usuario c_usuario;
        int _Permissao;
        bool _alterarCad;
        public v_Usuario()
        {
            InitializeComponent();
            this.m_usuario = new m_Usuario();
            this.c_usuario = new c_Usuario();

        }
        public v_Usuario(int permissao)
        {
            InitializeComponent();
            this.m_usuario = new m_Usuario();
            this.c_usuario = new c_Usuario();
            _Permissao = permissao;
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            cbxPermissao.SelectedIndex = -1;
            m_usuario.nome = null;
            m_usuario.login = null;
            m_usuario.senha = null;
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novousuario":
                    gbxNovoUsuario.Enabled = true;
                    _alterarCad = false;
                    LimparCampos();
                    
                    tabFormControl1.SelectedPage = tabFormPageNovoUsuario;
                    txtNome.Focus();
                    break;
                case "cancelarnovo":
                    gbxNovoUsuario.Enabled = false;
                    lblSenhasConfirmacao.Visible = false;
                    LimparCampos();
                    tabFormControl1.SelectedPage = tabFormPageUsuarios;
                    break;
                case "alterar":
                    _alterarCad = true;
                    m_usuario.idusuario = (int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[0]);
                    txtNome.Text = (string)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[1]);
                    txtLogin.Text = (string)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[2]);
                    txtSenha.Text = (string)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[3]);
                    txtConfirmaSenha.Text = (string)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[3]);
                    if ((int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[4]) == 1)
                    {
                        rbtAtivo.Checked = true;
                    }
                    else if ((int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[4]) == 0)
                    {
                        rbtInativo.Checked = true;
                    }
                    gbxNovoUsuario.Enabled = true;

                    tabFormControl1.SelectedPage = tabFormPageNovoUsuario;
                    break;
                    
                case "excluir":
                    m_usuario.idusuario = (int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[0]);
                    c_usuario.ExcluirUsuario(m_usuario);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usuarioTableAdapter.Fill(this.dbsgsDataSet.usuario);
                    break;
                case "salvar":
                    m_usuario.nome = txtNome.Text;
                    m_usuario.login = txtLogin.Text;
                    m_usuario.senha = txtSenha.Text;

                    //Ativo = 1 Inativo = 0;
                    if (rbtAtivo.Checked == true)
                    {
                        m_usuario.status = 1;
                    }
                    else if (rbtInativo.Checked == true)
                    {
                        m_usuario.status = 0;
                    }
                    /*
                     *ID 1 = administrador lv5
                     *ID 2 = consultar lv 1
                     *ID 3 = cadastro lv 2
                     *ID 4 = operacional lv 3
                     *ID 5 = financeiro lv 4 
                     * */
                    switch (cbxPermissao.Text)
                    {
                        case "CONSULTA":
                            m_usuario.fk_permissao_usuario = 2;
                            break;
                        case "CADASTRO":
                            m_usuario.fk_permissao_usuario = 3;
                            break;
                        case "OPERACIONAL":
                            m_usuario.fk_permissao_usuario = 4;
                            break;
                        case "FINANCEIRO":
                            m_usuario.fk_permissao_usuario = 5;
                            break;
                        case "ADMINISTRADOR":
                            m_usuario.fk_permissao_usuario = 1;
                            break;
                        default:
                            break;
                    }
                    //m_usuario.fk_permissao_usuario = Convert.ToInt32(cbxPermissao.Text);
                    if (_alterarCad == false)
                    {
                        c_usuario.NovoUsuario(m_usuario);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (_alterarCad == true)
                    {
                        c_usuario.AlterarUsuario(m_usuario);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    gbxNovoUsuario.Enabled = false;
                    LimparCampos();
                    lblSenhasConfirmacao.Visible = false;
                    tabFormControl1.SelectedPage = tabFormPageUsuarios;
                    this.usuarioTableAdapter.Fill(this.dbsgsDataSet.usuario);
                    
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
            if (gdvUsuarios.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja excluir o Usuário selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (gdvUsuarios.SelectedRowsCount == 1)
            {
                if (MessageBox.Show("Deseja Alterar o Usuário selecionado ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            funcao("novousuario");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar o Novo Usuário ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funcao("cancelarnovo");
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text && txtSenha.Text != string.Empty)
            {
                if (txtNome.Text != string.Empty && txtLogin.Text != string.Empty && cbxPermissao.Text != string.Empty)
                {
                    if (_alterarCad == false)
                    {

                        if (MessageBox.Show("Deseja Salvar o Novo Usuário ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            funcao("salvar");
                        }
                    }
                    else if (_alterarCad == true)
                    {
                        if (MessageBox.Show("Deseja Salvar as alterações do Usuário ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            else
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos!...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

        private void v_Usuario_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            _alterarCad = false;
            gbxNovoUsuario.Enabled = false;
            tabFormControl1.SelectedPage = tabFormPageUsuarios;
            lblSenhasConfirmacao.Visible = false;
            Permissao();
            // TODO: esta linha de código carrega dados na tabela 'dbsgsDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.dbsgsDataSet.usuario);

        }

        
        private void CheckSenha()
        {
            if (txtSenha.Text != string.Empty && txtConfirmaSenha.Text != string.Empty)
            {
                if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                    lblSenhasConfirmacao.Text = "As senhas não conferem!";
                    lblSenhasConfirmacao.ForeColor = Color.Red;
                    lblSenhasConfirmacao.Visible = true;
                }
                else if (txtSenha.Text == txtConfirmaSenha.Text)
                {
                    lblSenhasConfirmacao.Text = "As senhas conferem!";
                    lblSenhasConfirmacao.ForeColor = Color.Green;
                    lblSenhasConfirmacao.Visible = true;
                }
            }

        }
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            CheckSenha();
        }

        private void txtConfirmaSenha_Leave(object sender, EventArgs e)
        {
            CheckSenha();
        }
    }
}
