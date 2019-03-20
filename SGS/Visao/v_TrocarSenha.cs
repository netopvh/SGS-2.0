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
    public partial class v_TrocarSenha : DevExpress.XtraEditors.XtraForm
    {
        m_Usuario m_usuario;
        c_Usuario c_usuario;
        public v_TrocarSenha()
        {
            InitializeComponent();
            m_usuario = new m_Usuario();
            c_usuario = new c_Usuario();
        }

        private void v_TrocarSenha_Load(object sender, EventArgs e)
        {
            AcceptButton = btnTrocarSenha;
            txtUsuario.Focus();
        }

        private void btnTrocarSenha_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtSenhaAtual.Text != string.Empty && txtNovaSenha.Text != string.Empty && txtConfirmarSenha.Text != string.Empty)
            {
                if (c_usuario.AutenticarUsuario(txtUsuario.Text,txtSenhaAtual.Text))
                {
                    if (txtNovaSenha.Text.Length >= 6)
                    {
                        if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                        {
                            m_usuario.login = txtUsuario.Text;
                            m_usuario.senha = txtNovaSenha.Text;
                            c_usuario.AlterarSenhaUsuarioOld(m_usuario);
                            MessageBox.Show("Senha alterada com sucesso!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("As senhas não conferem!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sua senha deve conter no mínimo (6) caracteres!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Nome de usuário ou senha atual está incorreto!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("Preenchar todos os campos!", "FoxShop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void v_TrocarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void cbxMostrarSenhas_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostrarSenhas.Checked)
            {
                txtSenhaAtual.Properties.UseSystemPasswordChar = false;
                txtNovaSenha.Properties.UseSystemPasswordChar = false;
                txtConfirmarSenha.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaAtual.Properties.UseSystemPasswordChar = true;
                txtNovaSenha.Properties.UseSystemPasswordChar = true;
                txtConfirmarSenha.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}
