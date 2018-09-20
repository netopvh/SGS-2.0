using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
namespace SGS.Visao
{
    public partial class v_AtualizarSistema : DevExpress.XtraEditors.XtraForm
    {
        
        c_Ftpconfig c_ftpconfig;
        
        Thread thread;
        //ftp://suporte@192.168.3.2/install/versao.txt jeito certo
        //ftp://192.168.3.2/C:/SGS_UP/install/versao.txt jeito errado
        //ftp://suporte@192.168.3.2/install/setup.exe - SETUP
        //private readonly string remoteVersionFile = @"ftp://suporte@192.168.3.2/install/versao.txt";
        //private readonly string remoteSetupFile = @"ftp://suporte@192.168.3.2/install/setup.exe";
        //private static readonly string localSetupFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Temp\setup.exe";
        //private readonly string localSetupFile = @"C:/SGS/Temp/setup.exe";
        private string localSetupFile;
        private string remoteVersionFile;
        private string remoteSetupFile;
        private Version localVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; // Retorna a versão do Assembly (Programa) em execução
        private Version remoteVersion;
        private string usuarioftp;
        private string senhaftp;
        
        System.Net.WebClient wb = new System.Net.WebClient();//Classe usada para baixar o arquivo de info
        
        long bytes_total;
        public v_AtualizarSistema()
        {
            
            InitializeComponent();
            
            this.c_ftpconfig = new c_Ftpconfig();
            
        }
        

        private void v_AtualizarSistema_Load(object sender, EventArgs e)
        {
            CarregarValores();
            CancelButton = btnSair;
            
            
        }
        private void CarregarValores()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = c_ftpconfig.CarregarFtpConfig("select localsetuparquivo,remotosetup,remotoversao,usuarioftp,senhaftp from ftpconfig where idftpconfig = 1;");
                localSetupFile = dt.Rows[0][@"localsetuparquivo"].ToString();
                remoteSetupFile = dt.Rows[0][@"remotosetup"].ToString();
                remoteVersionFile = dt.Rows[0][@"remotoversao"].ToString();
                usuarioftp = dt.Rows[0]["usuarioftp"].ToString();
                senhaftp = dt.Rows[0]["senhaftp"].ToString();
            }
            catch (System.IndexOutOfRangeException exOut)
            {
                MessageBox.Show("Não existe configuração de FTP, por favor configure o FTP antes de verificar se á atualizações!\nERROR: " + exOut.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
        private bool CheckUpdate()
        {
            try
            {
                NetworkCredential credentials = new NetworkCredential(usuarioftp, senhaftp);
                lblResultado.Text = "Verificando...";
                wb.Credentials = credentials;
                byte[] buffer = wb.DownloadData(remoteVersionFile); //Baixa o arquivo de info para a memória
                System.IO.MemoryStream mem = new System.IO.MemoryStream(buffer); //Cria um Stream para o buffer
                System.IO.StreamReader memReader = new System.IO.StreamReader(mem); //Cria um leitor para o Stream
                remoteVersion = new Version(memReader.ReadToEnd()); // Lê a versão do arquivo para uma variável do tipo Versio;
                lblResultado.Text = "Versão Disponível:" + remoteVersion + " | Versão Atual:" + localVersion;
                return remoteVersion > localVersion; //Retorna true se a versão na internet for maior que a versão do aplicativo em execução;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
        }

        private void DownloadAndInstallUpdates()
        {
            if (CheckUpdate())
            {
                thread = new Thread(() => {


                    if (!Directory.Exists(localSetupFile))
                {
                    Directory.CreateDirectory(localSetupFile.Replace("/setup.exe",""));//Se não existir o local onde salvar o arquivo, então ele sera criado.
                        NetworkCredential credentials = new NetworkCredential(usuarioftp, senhaftp);
                        //Como o webclient não trais o total do arquivo que vai ser baixado e preciso usar o webrequest.
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(remoteSetupFile);
                        request.Method = WebRequestMethods.Ftp.GetFileSize;
                        request.Credentials = credentials;
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                        Stream responseStream = response.GetResponseStream();
                        bytes_total = response.ContentLength; //Variavel que guardar o total de bytes do arquivo.
                        response.Close();



                        wb.Credentials = credentials;
                    //Evento Download Completo em expressão lambda. o código será executado quando o download finalizar
                    wb.DownloadFileCompleted += new AsyncCompletedEventHandler(wb_DownloadFileCompleted);
                    wb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wb_DownloadProgressChanged);
                    wb.DownloadFileAsync(new Uri(remoteSetupFile), localSetupFile); //Baixa o setup em uma thread paralela para não congelar a execução
                    while (wb.IsBusy) { }
                    if (System.Windows.Forms.MessageBox.Show("Há um update pronto para instalar. Deseja instalar agora?",
                        "Update disponível",
                        System.Windows.Forms.MessageBoxButtons.YesNo,
                        System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes && System.IO.File.Exists(localSetupFile) == true)
                    {
                        System.Diagnostics.Process.Start(localSetupFile);
                        Application.Exit();
                    }
                    else if (System.IO.File.Exists(localSetupFile) == false)
                    {
                        MessageBox.Show("Arquivo de instalação não encontrado!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                });
                thread.Start();
            }
            else
            {
                MessageBox.Show("Não há atualizações disponiveis no momento!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        private void wb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate {


                    double bytesIn = double.Parse(e.BytesReceived.ToString());
                    //double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                    double percentage = bytesIn / bytes_total * 100;
                    lblResultado.Text = "Baixando:" + e.BytesReceived + " de " + bytes_total + " bytes.";

                    //progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
                    //progressBar1.Value = (int)e.BytesReceived / 100;
                    progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
                });
            }
            catch (System.InvalidOperationException)
            {
                
            }
            
        }
        private void wb_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate {
                    lblResultado.Text = "Completo!";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                thread.Abort();
            }

            

        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarValores();
                DownloadAndInstallUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "Progresso:";
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                thread.Abort();
                this.Close();
            }
            catch (Exception)
            {

            }
            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
