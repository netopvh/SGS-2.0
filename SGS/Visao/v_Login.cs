﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
using SGS.Modelo;
namespace SGS.Visao
{
    public partial class v_Login : DevExpress.XtraBars.TabForm
    {
        c_Usuario c_usuario;
        c_Empresalicenca c_empresalicenca;
        c_GerarMD5 c_md5;
        c_EncryptorDecrypt c_encryptordecrypt;
        v_EmpresaLicenca v_empresalicenca;
        private string _senhapadrao,_datainicial,_datafinal;
        private string _key1 = "";
        private string _key2 = "";
        private string _licenca = "";

        public v_Login()
        {
            InitializeComponent();
            c_usuario = new c_Usuario();
            c_empresalicenca = new c_Empresalicenca();
            c_md5 = new c_GerarMD5();
            v_empresalicenca = new v_EmpresaLicenca();
            c_encryptordecrypt = new c_EncryptorDecrypt();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                if (c_usuario.AutenticarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    v_Principal v_principal = new v_Principal(txtUsuario.Text);
                    v_principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!","SGS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void v_Login_Load(object sender, EventArgs e)
        {
            _senhapadrao = "masterkey@";
            _licenca = _licenca = c_empresalicenca.AutenticarLicencaMD5();
            _key1 = c_empresalicenca.AutenticarKey1();
            _key2 = c_empresalicenca.AutenticarKey2();
            _datainicial = c_encryptordecrypt.DecryptString(_key1, _senhapadrao);
            _datafinal = c_encryptordecrypt.DecryptString(_key2, _senhapadrao);
            AcceptButton = btnLogin;
            CancelButton = btnSair;
            VerificarLicenca();
            LogoEmpresa();
            
        }
       
        private void LogoEmpresa()
        {
            try
            {
                Stream stream = new MemoryStream(c_empresalicenca.CarrregarLogoMarca());
                var image = Image.FromStream(stream);
                pictureEdit1.Image = image;
            }
            catch (ArgumentNullException)
            {

                //throw;
            }
        }
        
        private void VerificarLicenca()
        {
            
            if(_licenca == string.Empty || _licenca == null || _key1 == string.Empty || _key2 == string.Empty)
            {
                this.Hide();
                v_empresalicenca.ShowDialog();
            }
            else if (DataLicenca())
            {
                if (c_md5.ComparaMD5(_senhapadrao, _licenca))
                {
                    lblLicenca.Text = "Licença para: " + c_empresalicenca.CarregarNomeEmpresa() + " de " + _datainicial + " até " + _datafinal + ".";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Key inválida, entre em contato com suporte!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Tempo de licença expirado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                v_EmpresaLicenca v_atualizarLicenca = new v_EmpresaLicenca(true);
                v_atualizarLicenca.ShowDialog();
            }
            
        }
        private bool DataLicenca()
        {
            bool Resultado = false;
            DateTime data1, data2;
            if (DateTime.TryParse(_datainicial,out data1).Equals(true) && DateTime.TryParse(_datafinal,out data2).Equals(true))
            {
                if (data1 < data2)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }
            }
            else
            {
                MessageBox.Show("Data(s) da licença em um formato inválido!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            return Resultado;
        }
        
        private void cbxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostrarSenha.Checked == true)
            {
                txtSenha.Properties.UseSystemPasswordChar = false;
            }
            else if (cbxMostrarSenha.Checked == false)
            {
                txtSenha.Properties.UseSystemPasswordChar = true;
            }
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }
    }
}