using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtualizarSistema
{
    public partial class v_AtualizarSistema : Form
    {
        private static readonly string remoteVersionFile = "192.168.3.2//Z:\versao.txt";
        private static readonly string remoteSetupFile = "http://www.meusite/meuprograma/setup.exe";
        private static readonly string localSetupFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Temp\MeuSetup.exe";
        public v_AtualizarSistema()
        {
            InitializeComponent();
        }

        private void v_AtualizarSistema_Load(object sender, EventArgs e)
        {

        }

            private static bool CheckUpdate()
            {
                System.Net.WebClient wb = new System.Net.WebClient(); //Classe usada para baixar o arquivo de info
                byte[] buffer = wb.DownloadData(remoteVersionFile); //Baixa o arquivo de info para a memória
                System.IO.MemoryStream mem = new System.IO.MemoryStream(buffer); //Cria um Stream para o buffer
                System.IO.StreamReader memReader = new System.IO.StreamReader(mem); //Cria um leitor para o Stream
                Version remoteVersion = new Version(memReader.ReadToEnd()); // Lê a versão do arquivo para uma variável do tipo Versio;
                memReader.Close();
                mem.Close();

                Version localVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; // Retorna a versão do Assembly (Programa) em execução
                return remoteVersion > localVersion; //Retorna true se a versão na internet for maior que a versão do aplicativo em execução;
            }

            private static void DownloadAndInstallUpdates()
            {
                if (CheckUpdate())
                {
                    System.Net.WebClient wb = new System.Net.WebClient();
                    wb.DownloadFileCompleted += //Evento Download Completo em expressão lambda. o código será executado quando o download finalizar
                        new System.ComponentModel.AsyncCompletedEventHandler((object sender, System.ComponentModel.AsyncCompletedEventArgs e) => {
                            if (System.Windows.Forms.MessageBox.Show("Há um update pronto para instalar. Deseja instalar agora?",
                                "Update disponível",
                                System.Windows.Forms.MessageBoxButtons.YesNo,
                                System.Windows.Forms.MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(localSetupFile);
                                System.Windows.Forms.Application.Exit();
                            }

                        });
                    if (System.IO.File.Exists(localSetupFile))
                        System.IO.File.Delete(localSetupFile);

                    wb.DownloadFileAsync(new Uri(remoteSetupFile), localSetupFile); //Baixa o setup em uma thread paralela para não congelar a execução
                }
            }

            //Esse método lhe ajudará a criar o arquivo info.txt.
            //Cada vez que você criar uma atualização para seu aplicativo você deverá alterar a versão nas Propriedades
            //Então execute este método para criar o arquivo Info.txt
            private static void CreateUpdateInfo()
            {
                System.Windows.Forms.OpenFileDialog appDialog = new System.Windows.Forms.OpenFileDialog();
                appDialog.Filter = "Aplicações (*.exe)|*.exe";
                appDialog.CheckFileExists = true;
                if (appDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                string appFile = appDialog.FileName;

                System.Windows.Forms.SaveFileDialog infoDialog = new System.Windows.Forms.SaveFileDialog();
                infoDialog.Filter = "TXT (*.txt)|*.txt";
                if (infoDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                string infoFile = infoDialog.FileName;

                System.Reflection.Assembly assembly = System.Reflection.Assembly.LoadFrom(appFile);
                Version assemblyVersion = assembly.GetName().Version;

                System.IO.StreamWriter sw = new System.IO.StreamWriter(infoFile, false);
                sw.Write(assemblyVersion.ToString());
                sw.Close();
            }
        
    
    }
}
