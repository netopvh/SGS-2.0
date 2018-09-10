using SGS.Modelo;
using SGS.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SGS.Visao
{
    public partial class v_EmpresaLicenca : DevExpress.XtraEditors.XtraForm
    {
        m_EmpresaLicenca m_empresalicenca;
        c_Empresalicenca c_empresalicenca;
        bool _AlterarKeyVencida;
        bool _AtualizarEmpresaLicenca;
        public v_EmpresaLicenca()
        {
            InitializeComponent();
            m_empresalicenca = new m_EmpresaLicenca();
            c_empresalicenca = new c_Empresalicenca();
        }
        public v_EmpresaLicenca(bool KeyVencida)
        {
            InitializeComponent();
            m_empresalicenca = new m_EmpresaLicenca();
            c_empresalicenca = new c_Empresalicenca();
            _AlterarKeyVencida = KeyVencida;
            if (_AlterarKeyVencida == false)
            {
                MessageBox.Show("Identificamos que o sistema ainda não tem licença para uso, entre com os dados da licença!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (_AlterarKeyVencida == true)
            {
                MessageBox.Show("Sua licença expirou, favor entre com uma licença valida!", "SGS - Sistema bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnLogo.Enabled = false;
                ptbLogo.Enabled = false;
                txtEmpresa.Enabled = false;
                this.Text = "Atualizar Licença para uso do sistema.";
            }
        }
        public v_EmpresaLicenca(bool KeyVencida,bool AtualizarEmpresaLicenca)
        {
            InitializeComponent();
            m_empresalicenca = new m_EmpresaLicenca();
            c_empresalicenca = new c_Empresalicenca();
            _AlterarKeyVencida = KeyVencida;
            _AtualizarEmpresaLicenca = AtualizarEmpresaLicenca;

            txtEmpresa.Text = c_empresalicenca.CarregarNomeEmpresa();
            txtKeyMD5.Text = c_empresalicenca.AutenticarLicencaMD5();
            txtKey1.Text = c_empresalicenca.AutenticarKey1();
            txtKey2.Text = c_empresalicenca.AutenticarKey2();
            LogoEmpresa();
            if (_AlterarKeyVencida == false && _AtualizarEmpresaLicenca == true)
            {
                this.Text = "Empresa/Licença";
                btnRegistrar.Text = "Alterar";

            }

        }
        private void LogoEmpresa()
        {
            try
            {
                Stream stream = new MemoryStream(c_empresalicenca.CarrregarLogoMarca());
                var image = Image.FromStream(stream);
                ptbLogo.Image = image;
            }
            catch (ArgumentNullException)
            {

                //throw;
            }
        }

        private void v_EmpresaLicenca_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_AtualizarEmpresaLicenca == true)
            {

            }
            else
            {
                Application.Exit();
            }
            
        }

        private void v_EmpresaLicenca_Load(object sender, EventArgs e)
        {
            CancelButton = btnSair;
                        
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (txtKeyMD5.Text != string.Empty && txtKey1.Text != string.Empty && txtKey2.Text != string.Empty)
            {
                if (_AlterarKeyVencida == false && _AtualizarEmpresaLicenca == false)
                {
                    if (txtEmpresa.Text != string.Empty && ptbLogo.Image != null)
                    {
                        m_empresalicenca.keyMD5 = txtKeyMD5.Text;
                        m_empresalicenca.key1 = txtKey1.Text;
                        m_empresalicenca.key2 = txtKey2.Text;
                        m_empresalicenca.nomeEmpresa = txtEmpresa.Text;
                        m_empresalicenca.logomarca = ConverterLogoParaByteArray(ptbLogo);

                        c_empresalicenca.PrimeiraEmpresaLicenca(m_empresalicenca);
                        MessageBox.Show("Keys Registradas com sucesso, o sistema sera fechado, por favor entre novamente no SGS!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Você deve inserir nome da empresa e a logo marca!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (_AlterarKeyVencida == false && _AtualizarEmpresaLicenca == true)
                {
                    if (MessageBox.Show("Confirma a Alteração?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        //Atualizar Empresa logo e Keys pelo sistema.
                        m_empresalicenca.keyMD5 = txtKeyMD5.Text;
                        m_empresalicenca.key1 = txtKey1.Text;
                        m_empresalicenca.key2 = txtKey2.Text;
                        m_empresalicenca.nomeEmpresa = txtEmpresa.Text;
                        m_empresalicenca.logomarca = ConverterLogoParaByteArray(ptbLogo);

                        c_empresalicenca.AlterarEmpresaLicenca(m_empresalicenca);
                        MessageBox.Show("Dados alterados com sucesso, o sistema sera fechado, por favor entre novamente no SGS!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    
                }
                else if (_AlterarKeyVencida == true)
                {
                    m_empresalicenca.keyMD5 = txtKeyMD5.Text;
                    m_empresalicenca.key1 = txtKey1.Text;
                    m_empresalicenca.key2 = txtKey2.Text;

                    c_empresalicenca.AtualizarKeysVencidadas(m_empresalicenca);
                    MessageBox.Show("Novas Keys Registradas com sucesso, o sistema sera fechado, por favor entre novamente no SGS!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                
                
            }
            else
            {
                MessageBox.Show("Você deve inserir as Keys!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            openFileDialogLogo.Multiselect = false;
            //openFileDialogLogo.InitialDirectory = "";
            openFileDialogLogo.Filter = "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|" + "All files (*.*)|*.*";
            openFileDialogLogo.CheckFileExists = true;
            openFileDialogLogo.CheckPathExists = true;
            openFileDialogLogo.FilterIndex = 2;
            
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                ptbLogo.Image = new Bitmap(openFileDialogLogo.FileName);
            }

        }
        public byte[] ConverterLogoParaByteArray(PictureBox picturebox)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] bArray = new byte[stream.Length];
                stream.Read(bArray, 0, System.Convert.ToInt32(stream.Length));
                return bArray;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (_AtualizarEmpresaLicenca == true)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
