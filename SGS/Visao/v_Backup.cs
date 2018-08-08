using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using MySql.Data.MySqlClient;
using SGS.Controle;
using System.IO;

namespace SGS.Visao
{
    public partial class v_Backup : Form
    {
        string localPadrao = (ConfigurationManager.AppSettings["Local"]);
        
        public v_Backup()
        {
            InitializeComponent();
            txtLocalPadrao.Text = localPadrao;
            lblProgresso.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EfetuarBackup(string local,string nomeArquivo)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            MySqlBackup mb = new MySqlBackup(comando);
            mb.ExportToFile(local + "\\" + nomeArquivo + ".sql");
            conexao.Close();
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            bool fazerBk = false;
            if (rbtLocalEscolhido.Checked || rbtLocalPadrao.Checked)
            {
                if (rbtLocalEscolhido.Checked == true)
                {
                    lblLocal.Text = "Local Escolhido:";
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtLocalPadrao.Text = folderBrowserDialog1.SelectedPath;
                        localPadrao = txtLocalPadrao.Text;
                        fazerBk = true;
                    }
                    else
                    {
                        MessageBox.Show("Você não escolheu um caminho...", "SGS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        fazerBk = false;
                    }
                }
                if (rbtLocalPadrao.Checked)
                {
                    lblLocal.Text = "Local Padrão:";
                    localPadrao = (ConfigurationManager.AppSettings["Local"]);
                    txtLocalPadrao.Text = localPadrao;
                    if (!Directory.Exists(localPadrao))//Verifica se o Localpadrão realmente existe.
                    {
                        Directory.CreateDirectory(localPadrao);//Se não existir o local padrão então ele sera criado.
                    }
                    fazerBk = true;
                }
                if (!backgroundWorker1.IsBusy && fazerBk == true)
                {
                    gbxLocal.Enabled = false;
                    btnBackup.Enabled = false;
                    btnVoltar.Enabled = false;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Você deve escolhe uma das duas opções de onde vai ser salvo o backup!...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void v_Backup_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            AcceptButton = btnBackup;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)//onde chama a tarefa demorada.
        {
            var data = DateTime.Now.ToShortDateString().Replace("/", "");
            var hora = DateTime.Now.ToLongTimeString().Replace(":","");
            
            EfetuarBackup(@localPadrao,"SGS"+data+hora);

            for (int i = 0; i < 100; i++)
            {
                
                //incrementa o progresso do backgroundWorker 
                //a cada passagem do loop.
                this.backgroundWorker1.ReportProgress(i);

                //Verifica se houve uma requisição para cancelar a operação.
                if (backgroundWorker1.CancellationPending)
                {
                    //se sim, define a propriedade Cancel para true
                    //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                    e.Cancel = true;
                    
                    //zera o percentual de progresso do backgroundWorker1.
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
                else
                {
                    //Tempo
                    System.Threading.Thread.Sleep(20);
                    backgroundWorker1.ReportProgress(i * 1);
                }
            
        }
        //Finalmente, caso tudo esteja ok, finaliza
        //o progresso em 100%.
        backgroundWorker1.ReportProgress(100);
        }
       

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)//Motra Incremento do processo ou decremento na barra.
        {
            //Incrementa o valor da progressbar com o valor
            //atual do progresso da tarefa.
            pgbBackup.Value = e.ProgressPercentage;

            //informa o percentual na forma de texto.
            lblProgresso.Visible = true;
            lblProgresso.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //O que fazer após concluir a tarefa.
            if (e.Cancelled)
            {
                //caso a operação seja cancelada, informa ao usuario.
                lblProgresso.Text = "Operação Cancelada pelo Usuário!";

                //habilita o Botao cancelar
                btnCancelar.Enabled = true;
                //limpa a label
                lblLocal.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                lblProgresso.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                lblProgresso.Text = "Tarefa Concluida com sucesso!";
                btnBackup.Enabled = true;
                gbxLocal.Enabled = true;
                btnVoltar.Enabled = true;
                if (cbxFechaSistema.Checked == true)
                {
                    lblProgresso.Text = "Sistema sendo fechado...";
                    Application.Exit();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)//Se o backgroundWork1 estiver ocupado
            {
                //Notifica a thread que o cancelamento foi solicitado.
                //Cancela a tarefa DoWork
                backgroundWorker1.CancelAsync();
                lblProgresso.Text = "Cancelando...";
            }

        }
    }
}
