using MySql.Data.MySqlClient;
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

namespace SGS.Visao
{
    public partial class v_RestaurarBackup : Form
    {
        string Arquivo;
        public v_RestaurarBackup()
        {
            InitializeComponent();
            lblProgresso.Visible = false;
        }

        private void v_RestaurarBackup_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            AcceptButton = btnRestaurar;
        }
        private void RestaurarBackup(string arquivo)
        {
            MySqlConnection conexao = c_ConexaoMySql.GetConexao();
            MySqlCommand comando = c_ConexaoMySql.GetComando(conexao);
            MySqlBackup mb = new MySqlBackup(comando);
            mb.ImportFromFile(arquivo);
            conexao.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "MYSQL|*.sql";
            openFileDialog1.Title = "Buscar arquivo de backup MYSQL";
            openFileDialog1.FileName = "";
            
            //openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = @"C:\SGS\Backup";
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Arquivo = openFileDialog1.FileName;
                txtLocalArquivo.Text = Arquivo;

            }
            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy && txtLocalArquivo.Text != "")
            {
                gbxLocalArquivo.Enabled = false;
                btnRestaurar.Enabled = false;
                btnVoltar.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
                
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RestaurarBackup(Arquivo);
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
    

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        //Incrementa o valor da progressbar com o valor
        //atual do progresso da tarefa.
        progressBar1.Value = e.ProgressPercentage;

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
                btnVoltar.Enabled = true;
                btnRestaurar.Enabled = true;
            //habilita o Botao cancelar
            btnCancelar.Enabled = true;
            //limpa a label
            txtLocalArquivo.Text = string.Empty;
        }
        else if (e.Error != null)
        {
            //informa ao usuario do acontecimento de algum erro.
            lblProgresso.Text = "Aconteceu um erro durante a execução do processo!";
        }
        else
        {
            //informa que a tarefa foi concluida com sucesso.
            lblProgresso.Text = "Concluido!";
                MessageBox.Show("Banco restaurado com sucesso!...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRestaurar.Enabled = true;
            gbxLocalArquivo.Enabled = true;
            btnVoltar.Enabled = true;
           
        }
    }
    }
}
