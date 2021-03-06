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

namespace SGS.Visao
{
    public partial class v_Usuario : DevExpress.XtraBars.TabForm
    {
        m_Usuario m_usuario;
        c_Usuario c_usuario;
        c_Permissao c_permissao;
        int _Permissao;
        bool _alterarCad;
        public v_Usuario()
        {
            InitializeComponent();
            this.m_usuario = new m_Usuario();
            this.c_usuario = new c_Usuario();
            this.c_permissao = new c_Permissao();
        }
        public v_Usuario(int permissao)
        {
            InitializeComponent();
            this.m_usuario = new m_Usuario();
            this.c_usuario = new c_Usuario();
            this.c_permissao = new c_Permissao();
            _Permissao = permissao;
        }
        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
            lookUpEditPermissao.ItemIndex = -1;
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
                    txtNome.Text = gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[1]).ToString();
                    txtLogin.Text = gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[2]).ToString();
                    txtSenha.Text = gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[3]).ToString();
                    txtConfirmaSenha.Text = gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[3]).ToString();
                    if ((int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[4]) == 1)
                    {
                        rbtAtivo.Checked = true;
                    }
                    else if ((int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[4]) == 0)
                    {
                        rbtInativo.Checked = true;
                    }
                    txtEmailPessoal.Text = gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[6]).ToString();
                    gbxNovoUsuario.Enabled = true;

                    tabFormControl1.SelectedPage = tabFormPageNovoUsuario;
                    break;
                    
                case "excluir":
                    m_usuario.idusuario = (int)gdvUsuarios.GetRowCellValue(gdvUsuarios.GetSelectedRows()[0], gdvUsuarios.Columns[0]);
                    c_usuario.ExcluirUsuario(m_usuario);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarUsuarios();
                    break;
                case "salvar":
                    m_usuario.nome = txtNome.Text;
                    m_usuario.login = txtLogin.Text;
                    m_usuario.senha = txtSenha.Text;
                    m_usuario.emailpessoal = txtEmailPessoal.Text;
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

                    /*insert into permissao(nome,nivel) values ('ADMINISTRADOR',5);
                    insert into permissao(nome,nivel) values ('CONSULTAR',1);
                    insert into permissao(nome,nivel) values ('CADASTRO',2);
                    insert into permissao(nome,nivel) values ('OPERACIONAL',3);
                    insert into permissao(nome,nivel) values ('FINANCEIRO',4);
                    */
                    m_usuario.fk_permissao_usuario = (int)lookUpEditPermissao.EditValue;
                    //m_usuario.fk_permissao_usuario = Convert.ToInt32(cbxPermissao.Text);
                    if (_alterarCad == false)
                    {
                        c_usuario.NovoUsuario(m_usuario);
                        MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarUsuarios();
                    }
                    else if (_alterarCad == true)
                    {
                        c_usuario.AlterarUsuario(m_usuario);
                        MessageBox.Show("Alterado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarUsuarios();
                    }
                    gbxNovoUsuario.Enabled = false;
                    LimparCampos();
                    lblSenhasConfirmacao.Visible = false;
                    tabFormControl1.SelectedPage = tabFormPageUsuarios;
                    

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
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    break;
                case 3:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = true;
                    break;

                case 4:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = false;
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
                if (txtNome.Text != string.Empty && txtLogin.Text != string.Empty && lookUpEditPermissao.Text != string.Empty && txtEmailPessoal.Text != string.Empty)
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
            CarregarComboboxPermissao();
            CarregarUsuarios();
            gdvUsuarios.BestFitColumns(true);
        }
        private void CarregarUsuarios()
        {
            DataTable dtUsuairos = new DataTable();
            dtUsuairos = c_usuario.CarregarUsuariosPermissao();
            gridControl1.DataSource = dtUsuairos;
            gdvUsuarios.RefreshData();
        }
        private void CarregarComboboxPermissao()
        {
            DataTable dtPermissao = new DataTable();
            lookUpEditPermissao.Properties.DataSource = c_permissao.CarregarPermissao();
            lookUpEditPermissao.Properties.DisplayMember = "nome";
            lookUpEditPermissao.Properties.ValueMember = "idpermissao";
            lookUpEditPermissao.ItemIndex = -1;
            lookUpEditPermissao.Refresh();
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

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
