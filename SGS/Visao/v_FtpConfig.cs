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
    public partial class v_FtpConfig : DevExpress.XtraEditors.XtraForm
    {

        c_Ftpconfig c_ftpConfig;
        m_Ftpconfig m_ftpConfig;
        
        public v_FtpConfig()
        {
            InitializeComponent();
            this.c_ftpConfig = new c_Ftpconfig();
            this.m_ftpConfig = new m_Ftpconfig();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Funcao(string funcao)
        {
            switch (funcao)
            {
                case "salvar":
                    m_ftpConfig.idftpconfig = 1;
                    m_ftpConfig.localsetuparquivo = txtDiretorioSalvarSetup.Text;
                    m_ftpConfig.remotosetup = txtDiretorioSetupUpdate.Text;
                    m_ftpConfig.remotoversao = txtDiretorioVersaoUpdate.Text;
                    m_ftpConfig.usuarioftp = txtUsuarioFTP.Text;
                    m_ftpConfig.senhaftp = txtSenhaFTP.Text;
                    if (VerificarFTPConfig())
                    {
                        if (MessageBox.Show("Deseja salvar as configurações de FTP?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            c_ftpConfig.NovoFtpConfig(m_ftpConfig);
                            MessageBox.Show("Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else 
                    {
                        if (MessageBox.Show("Deseja alterar as configurações de FTP?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                            c_ftpConfig.AlterarFtpConfig(m_ftpConfig);
                            MessageBox.Show("Atualizado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    
                    break;
                
                case "get":
                    if (VerificarFTPConfig() == true)
                    {
                        this.Text = "Configurações servidor FTP";
                        btnSalvar.Text = "Salvar";
                        txtUsuarioFTP.Text = string.Empty;
                        txtSenhaFTP.Text = string.Empty;
                        txtDiretorioVersaoUpdate.Text = string.Empty;
                        txtDiretorioSetupUpdate.Text = string.Empty;
                        txtDiretorioSalvarSetup.Text = string.Empty;
                    }
                    else if(VerificarFTPConfig() == false)
                    {
                        this.Text = "Alterar configurações servidor FTP";
                        btnSalvar.Text = "Alterar";
                        DataTable dt = new DataTable();
                        dt = c_ftpConfig.CarregarFtpConfig("select * from ftpconfig where idftpconfig = 1;");
                        txtUsuarioFTP.Text = dt.Rows[0]["usuarioftp"].ToString();
                        txtSenhaFTP.Text = dt.Rows[0]["senhaftp"].ToString();
                        txtDiretorioSalvarSetup.Text = dt.Rows[0]["localsetuparquivo"].ToString();
                        txtDiretorioSetupUpdate.Text = dt.Rows[0]["remotosetup"].ToString();
                        txtDiretorioVersaoUpdate.Text = dt.Rows[0]["remotoversao"].ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcao("salvar");
        }

        private void v_FtpConfig_Load(object sender, EventArgs e)
        {
            VerificarFTPConfig();
            Funcao("get");
            CancelButton = btnVoltar;
        }
        private bool VerificarFTPConfig()
        {
            bool FtpConfig;
            int resultado;
            DataTable dt = new DataTable();

            dt = c_ftpConfig.CarregarFtpConfig("select idftpconfig from ftpconfig where idftpconfig = 1;");
            resultado = (int)dt.Rows.Count;
            if (resultado < 1)
            {
                FtpConfig = true;
                
            }else
            {
                
                FtpConfig = false;
            }
            return FtpConfig;
        }

        private void btnCopiarExemplo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("ftp://suporte@192.168.3.2/install/versao.txt");
            Clipboard.GetText();
        }
    }
}
