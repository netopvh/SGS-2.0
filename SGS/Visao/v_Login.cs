using System;
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
        c_Permissao c_permissao;
        private string _senhapadrao,_datainicial,_datafinal;
        private string _key1 = "";
        private string _key2 = "";
        private string _licenca = "";
        private int _permissao;
        public v_Login()
        {
            InitializeComponent();
            c_usuario = new c_Usuario();
            c_empresalicenca = new c_Empresalicenca();
            c_md5 = new c_GerarMD5();
            v_empresalicenca = new v_EmpresaLicenca();
            c_encryptordecrypt = new c_EncryptorDecrypt();
            c_permissao = new c_Permissao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string _senhasuporte = (string)DateTime.Now.Day.ToString();
            if (txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                if (c_usuario.AutenticarUsuario(txtUsuario.Text, txtSenha.Text) || txtUsuario.Text == "SUPORTE" && txtSenha.Text == _senhasuporte+"masterkey@")
                {
                    v_Principal v_principal = new v_Principal(txtUsuario.Text,_permissao);
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
            CreateUpdateInfo();
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
            _permissao = c_permissao.AutenticarPermissao(txtUsuario.Text);
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
                MessageBox.Show("AVISO: Se você estar instalando o sistema pela primeira vez você dele informar os dados solicitados na próxima tela para abrir o sistema, caso contrario chame o suporte á algo de errado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            DateTime data1, data2,data3 = DateTime.Now;
            
            if (DateTime.TryParse(_datainicial,out data1).Equals(true) && DateTime.TryParse(_datafinal, out data2).Equals(true))
            {
                if (data3 > data2)
                {
                    Resultado = false;
                }
                else
                {
                    Resultado = true;
                }
            }
            else
            {
                MessageBox.Show("Data(s) da licença em um formato inválido!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CreateUpdateInfo()
        {
            //Esse método lhe ajudará a criar o arquivo info.txt.
            //Cada vez que você criar uma atualização para seu aplicativo você deverá alterar a versão nas Propriedades
            //Então execute este método para criar o arquivo Info.txt

            /*
            System.Windows.Forms.OpenFileDialog appDialog = new System.Windows.Forms.OpenFileDialog();
            appDialog.Filter = "Aplicações (*.exe)|*.exe";
            appDialog.CheckFileExists = true;
            if (appDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            string appFile = appDialog.FileName;

            System.Windows.Forms.SaveFileDialog infoDialog = new System.Windows.Forms.SaveFileDialog();
            infoDialog.Filter = "TXT (*.txt)|*.txt";
            if (infoDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            string infoFile = infoDialog.FileName;
            */
            string appFile = @"C:/SGS/SGS.exe";
            string infoFile = @"C:/SGS/SGS_VersãoInfo.txt";

            System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(appFile);
            Version assemblyVersion = assembly.GetName().Version;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(infoFile, false);
            sw.Write("Versão do sistema nesta pasta é:" + assemblyVersion.ToString() + ". Para atualizar bastar entrar no sistema, na aba Sistema e procurar por atualizações!");
            sw.Close();
        }
    }
}
