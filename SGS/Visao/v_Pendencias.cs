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
using SGS.Enum;
using DevExpress.XtraEditors.Controls;
using System.Configuration;
using DevExpress.XtraEditors.Repository;

namespace SGS.Visao
{
    public partial class v_Pendencias : DevExpress.XtraBars.TabForm
    {

        c_Pendencias c_pendencias;
        m_Pendencias m_pendencias;
        c_EmailConfig c_emailConfig;
        m_EmailConfig m_emailConfig;
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        int iRetorno = 0; //Variável para retorno das chamadas
        string _usuariocad;
        int _permissao;
        public v_Pendencias()
        {
            
            InitializeComponent();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
        }
        public v_Pendencias(string Usuario,int Permissao)
        {
            
            InitializeComponent();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            _usuariocad = Usuario;
            _permissao = Permissao;
            
        }
        
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "novapendencia":
                    v_NovaPendencia v_novaPendencia = new v_NovaPendencia(_usuariocad,false);
                    v_novaPendencia.ShowDialog();
                    break;
                
                case "excluir":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    c_pendencias.ExcluirPendencias(m_pendencias);
                    MessageBox.Show("Excluido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPendencias();

                    break;
                case "alterar":
                    v_NovaPendencia v_AlterarPendencia = new v_NovaPendencia(
                        (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]),
                        (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[1]),
                        (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[3]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[7]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[9]),
                        (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]),
                        Convert.ToDateTime(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString()),
                        Convert.ToDateTime(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[13]).ToString()),
                        Convert.ToDateTime(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[14]).ToString()),
                        _usuariocad,true);
                    v_AlterarPendencia.ShowDialog();
                    /*_alterarCad = true;
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    LookUpEditLoteamento.EditValue = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[1]);
                    LookUpEditCorretor.EditValue = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[3]);
                    txtQuadra.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]);
                    txtLote.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]);
                    txtCliente.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[7]);
                    txtVenda.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]);
                    txtNumeroContrato.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[9]);
                    txtPendencia.Text = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]);
                    dtpDataVenda.Value = Convert.ToDateTime(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString());
                    dtpDataCad.Value = Convert.ToDateTime(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[13]).ToString());
                    dteDataCadPendencia.EditValue = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[14]).ToString();
                    _usuariocad = (string)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[15]);
                    tabFormControl1.SelectedPage = tabFormPageNovaPendencia;
                    gbxNovaPendencia.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnSalvar.Enabled = true;
                    */
                    break;
                case "devolvido":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    m_pendencias.status = (int)e_StatusPendencia.Resolvido;
                    m_pendencias.datadevolucao = DateTime.Now;
                    m_pendencias.usuariocad = _usuariocad;
                    c_pendencias.AlterarPendenciaParaResolvido(m_pendencias);
                    MessageBox.Show("Devolvido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPendencias();
                    break;
                case "entregar":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    m_pendencias.status = (int)e_StatusPendencia.Corretor;
                    m_pendencias.dataentregacorretor = DateTime.Now;
                    m_pendencias.usuariocad = _usuariocad;
                    c_pendencias.AlterarPendenciaParaCorretor(m_pendencias);
                    MessageBox.Show("Entregue com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPendencias();
                    break;
                case "aresolver":
                    m_pendencias.idpendencias = (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]);
                    m_pendencias.status = (int) e_StatusPendencia.A_Resolver;
                    
                    m_pendencias.usuariocad = _usuariocad;
                    c_pendencias.AlterarPendenciaParaARevolver(m_pendencias);
                    MessageBox.Show("Você voltou a pendência para o Status A Revolver com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarPendencias();
                    break;
                default:
                    break;
            }
        }
        private void Permissao()
        {
            switch (_permissao)
            {
                case 1:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnDevolver.Enabled = false;
                    btnEntregarPendencia.Enabled = false;
                    
                    break;
                case 2:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnDevolver.Enabled = true;
                    btnEntregarPendencia.Enabled = true;
                    break;
                case 3:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDevolver.Enabled = true;
                    btnEntregarPendencia.Enabled = true;
                    break;
                case 4:
                    btnExcluir.Enabled = false;
                    btnNovo.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnDevolver.Enabled = true;
                    btnEntregarPendencia.Enabled = true;
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
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja excluir a pendência selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("excluir");
                    }
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1)
                {
                    if (MessageBox.Show("Deseja alterar os dados da Pendência selecionada?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("alterar");
                    }
                }
                else
                {
                    MessageBox.Show("Você precisa selecionar um registro no grid!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            funcao("novapendencia");
        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void v_Pendencias_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            tabFormControl1.SelectedPage = tabFormPagePendencias;
            Permissao();
            CarregarPendencias();
            //gdvPendencias.BestFitColumns(true);
            
        }
        public void CarregarPendencias()
        {
            DataTable dtPendencias = new DataTable();
            dtPendencias = c_pendencias.CarregarPendenciaCorretorLoteamento();
            gridControl1.DataSource = dtPendencias;
            gdvPendencias.RefreshData();
        }
        
        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funcao("cancelarnovo");
        }
        private void loteamentoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 1)
                {
                    if (MessageBox.Show("Deseja da baixar nesse contrato pendênte como devolvido?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("devolvido");
                    }
                }
                else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 2)
                {
                    string DataDevolucao = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[16]).ToString();
                    MessageBox.Show("Contrato pendênte já devolvido para o stand no dia:" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 0)
                {

                    MessageBox.Show("Contrato deve ser entregue primeiro para o Corretor resolver a pendência no botão (Corretor)!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void dteDataVenda_EditValueChanging(object sender, ChangingEventArgs e)
        {
           
        }

        private void dteDataVenda_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar grid em Excel";
            saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Arquivo = saveFileDialog1.FileName;
                gdvPendencias.ExportToXlsx(Arquivo);
                MessageBox.Show("Exportado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você não escolheu um caminho para salvar o arquivo...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (gdvPendencias.SelectedRowsCount == 1)
            {
                string status = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]).ToString();
                string NumeroPendencia = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[0]).ToString();
                string Corretor = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[4]).ToString();
                string Loteamento = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[2]).ToString();
                string Qd = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]).ToString();
                string Lt = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]).ToString();
                string Venda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]).ToString();
                string NumeroContrato = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[9]).ToString();
                string DataVenda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString().Replace("00:00:00","");
                string DataCadVenda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[13]).ToString().Replace("00:00:00", "");
                string DataCadPendencia = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[14]).ToString();
                string UsuarioCad = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[15]).ToString();
                string Pendencia = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]).ToString();
                string Assinatura = "";
                switch (status)
                {
                    case "0": status = "0 - A Resolver";
                        Assinatura = "Pendência Cadastrada no sistema!";
                        break;
                    case "1": status = "1 - Corretor";
                        Assinatura = "Ao assinar esse protocolo o contrato pendênte que lhe foi entregue e de sua responsabilidade resolver a pendência e devolver a pendência resolvida para o Escritório Administrativo.";
                        break;
                    case "2": status = "2 - Resolvido";
                        Assinatura = "Ao assinar esse protocolo confirmo que recebi o contrato pendênte que foi entregue ao corretor!";
                        break;
                    default:
                        break;
                }
                
                string Impressao =
                    
                "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "STATUS: (" + status+")\n"+
                    "Data Cadastro da Pendência: " + DataCadPendencia+"\n"+
                    "Pendência Número: " + NumeroPendencia+"\n" +
                    "Corretor: " + Corretor + "\n" +
                    "Loteamento: " + Loteamento + "\n"+
                    "Qd: " + Qd + " - Lt: "+ Lt +"\n"+
                    "Venda: "+ Venda + " - Número Contrato: "+ NumeroContrato + "\n" +
                    "Data Venda: "+ DataVenda +"Data Cad.: "+DataCadVenda+"\n"+
                    "Pendência: "+Pendencia+"\n"+
                    "\n" +
                    "Usuário Cad: " + UsuarioCad +"\n"+
                    "Emissão: " +DateTime.Now+"Hrs."+"\n"+
                    "************************************************"+
                    "\n"+
                    "Assinatura:"+"\n\n\n"+
                    "________________________________________________"+"\n"+
                    Assinatura;
                string Porta = (ConfigurationManager.AppSettings["Porta"]);
                if (Porta.ToString() == "ETHERNET")
                {
                    string Ip = (ConfigurationManager.AppSettings["Ip"]);
                    iRetorno = MP2064.IniciaPorta(Ip);
                }
                else
                {
                    iRetorno = MP2064.IniciaPorta(Porta);
                }
                
                // \n - quebra de linha e \r retorno de impressão (comandos da impressora)
                iRetorno = MP2064.FormataTX("\r\n\r\n"+ Impressao + "\r\n\r\n",2,0,0,0,1);//ao ser clicado, imprime 
                iRetorno = MP2064.AcionaGuilhotina(1);//chama a função da DLL(Corte Total)
            }
            
        }

        private void gdvPendencias_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "status")
                {
                    if ((int)e.Value == 0) e.DisplayText = "0 - A Resolver";
                    if ((int)e.Value == 1) e.DisplayText = "1 - Corretor";
                    if ((int)e.Value == 2) e.DisplayText = "2 - Resolvido";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEntregarPendencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 0)
                {
                    if (MessageBox.Show("Deseja entregar esse contrato para o Corretor resolver a pendência?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        funcao("entregar");
                    }
                }

                else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 1)
                {
                    string DataEntregue = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[17]).ToString();
                    MessageBox.Show("Contrato pendênte entregue para o corretor resolver a pendência no dia:" + DataEntregue + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 2)
                {
                    string DataDevolucao = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[16]).ToString();
                    MessageBox.Show("Contrato pendênte já devolvido para o stand no dia:" + DataDevolucao + "Hr...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                }
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Não à index selecionado", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void btnARevolver_Click(object sender, EventArgs e)
        {
            if (gdvPendencias.SelectedRowsCount == 1 &&(int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) != 0)
            {
                if (MessageBox.Show("Deseja volta o status da pendência para A Resolver?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funcao("aresolver");
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarPendencias();
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bbiPendencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Visao.Relatorios.v_PendenciasRelatorio RelatorioPendencias = new Relatorios.v_PendenciasRelatorio();
            RelatorioPendencias.ShowDialog();
        }

        private void bbiImprimirGrid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

        private async void bbiEmailAvisoPendencia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdCorretor = Convert.ToInt32(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[3]));
            string Loteamento = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[2]).ToString();
            string Corretor = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[4]).ToString();
            string Qd = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]).ToString();
            string Lt = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]).ToString();
            string Pendencia = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]).ToString();
            string Cliente = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[7]).ToString();
            string DataVenda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString().Replace("00:00:00", "");
            string Venda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]).ToString();
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 0)
                {
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        m_corretor.idcorretor = Convert.ToInt32(IdCorretor);
                        m_corretor.email = c_corretor.GetEmailCorretor(m_corretor);
                        m_emailConfig.smtpemail = c_emailConfig.GetSMTpEmail();
                        m_emailConfig.smtphost = c_emailConfig.GetSMTPHost();
                        m_emailConfig.smtpporta = Convert.ToInt32(c_emailConfig.GetSMTPPorta());
                        m_emailConfig.smtpsenhaemail = c_emailConfig.GetSMTPSenhaEmail();
                        m_emailConfig.smtpssl = c_emailConfig.GetSMTPSSL();
                        m_emailConfig.smtpcredencialpadrao = c_emailConfig.GetSMTPCredencialPadrao();

                        smtp.Host = m_emailConfig.smtphost;//"smtp.gmail.com"
                        smtp.Port = m_emailConfig.smtpporta;//587
                        smtp.EnableSsl = m_emailConfig.smtpssl;//true
                        smtp.UseDefaultCredentials = m_emailConfig.smtpcredencialpadrao;//false
                        smtp.Credentials = new System.Net.NetworkCredential(m_emailConfig.smtpemail, m_emailConfig.smtpsenhaemail);

                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(m_emailConfig.smtpemail);//Conta de email que vai usar

                            if (!string.IsNullOrWhiteSpace(m_corretor.email))//Email para enviar
                            {
                                mail.To.Add(new System.Net.Mail.MailAddress(m_corretor.email));//Email para enviar
                            }
                            else
                            {
                                //splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Não foi encontrado E-mail para envio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            /*if (cbxEnviarCopiarEmailAviso.Checked == true)
                                mail.CC.Add(new System.Net.Mail.MailAddress(m_emailConfig.smtpemail));
                            if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                                mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                            mail.IsBodyHtml = true;
                            mail.Subject = "Aviso Contrato Pendênte Prime/Valle!  Venda:(" + Venda + ")";//Assunto do email

                            var EmailHtml =
        @"<h2 style=""text - align: center; ""><span style=""color: #ff0000;""><strong>Aviso de Contrato com Pend&ecirc;ncia <img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-frown.gif"" alt=""frown"" /><br /></strong></span></h2>" +
        @"<hr />" +
        @"<p style=""text - align: center; ""><span style=""text - decoration: underline; ""><span style=""color: #000000;""><strong>Dados da Venda:</strong></span></span></p>" +
        @"<ul>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Empreendimento: </strong><span style=""color: #008000;"">" + Loteamento + "</span><br /></span></li>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Quadra:</strong> <span style=""color: #008000;"">" + Qd + "</span> <strong>Lote:</strong>" +
        @"<span style=""color: #008000;"">" + Lt + "</span></span></li>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Corretor:</strong> <span style=""color: #008000;"">" + Corretor + "</span></span></li>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Cliente:</strong> <span style=""color: #008000;"">" + Cliente + "</span></span></li>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Data Venda:</strong> <span style=""color: #008000;"">" + DataVenda + "</span></span></li>" +
        @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Pend&ecirc;ncia:</strong> <span style=""color: #008000;"">" + Pendencia + "</span></span></li>" +
        @"</ul>" +
        @"<p style=""text - align: left; "">&nbsp;</p>" +
        @"<p style=""text - align: left; ""><span style=""color: #000000;""><strong>OBS:</strong> Procure o escr&iacute;torio o mais r&aacute;pido poss&iacute;vel para resolver sua pend&ecirc;ncia e evitar que o pagamento da sua comiss&atilde;o seja <strong><span style=""color: #ff0000;"">bloqueada!</span></strong></span></p>" +
        @"<hr />" +
        @"<p><span style=""color: #0000ff;""><span style=""color: #000000;"">&copy;2018 -</span> <strong><span style=""color: #0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
        @"<p style=""text - align: left; "">&nbsp;</p>";
                            mail.Body = EmailHtml;
                            await smtp.SendMailAsync(mail);
                            MessageBox.Show("E-mail Enviado com sucesso para:" + m_corretor.email + " sobre a pendência do corretor(a):" + Corretor, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Tipo de aviso somente para contratos com Pendência com status = A - Resolver", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private async void bbiEmailPendenciaResolvida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int IdCorretor = Convert.ToInt32(gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[3]));
            string Loteamento = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[2]).ToString();
            string Corretor = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[4]).ToString();
            string Qd = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[5]).ToString();
            string Lt = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[6]).ToString();
            string Pendencia = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[10]).ToString();
            string Cliente = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[7]).ToString();
            string DataVenda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[12]).ToString().Replace("00:00:00", "");
            string Venda = gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[8]).ToString();
            try
            {
                if (gdvPendencias.SelectedRowsCount == 1 && (int)gdvPendencias.GetRowCellValue(gdvPendencias.GetSelectedRows()[0], gdvPendencias.Columns[11]) == 2)
                {
                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {
                        m_corretor.idcorretor = Convert.ToInt32(IdCorretor);
                        m_corretor.email = c_corretor.GetEmailCorretor(m_corretor);
                        m_emailConfig.smtpemail = c_emailConfig.GetSMTpEmail();
                        m_emailConfig.smtphost = c_emailConfig.GetSMTPHost();
                        m_emailConfig.smtpporta = Convert.ToInt32(c_emailConfig.GetSMTPPorta());
                        m_emailConfig.smtpsenhaemail = c_emailConfig.GetSMTPSenhaEmail();
                        m_emailConfig.smtpssl = c_emailConfig.GetSMTPSSL();
                        m_emailConfig.smtpcredencialpadrao = c_emailConfig.GetSMTPCredencialPadrao();

                        smtp.Host = m_emailConfig.smtphost;//"smtp.gmail.com"
                        smtp.Port = m_emailConfig.smtpporta;//587
                        smtp.EnableSsl = m_emailConfig.smtpssl;//true
                        smtp.UseDefaultCredentials = m_emailConfig.smtpcredencialpadrao;//false
                        smtp.Credentials = new System.Net.NetworkCredential(m_emailConfig.smtpemail, m_emailConfig.smtpsenhaemail);

                        using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                        {
                            mail.From = new System.Net.Mail.MailAddress(m_emailConfig.smtpemail);//Conta de email que vai usar

                            if (!string.IsNullOrWhiteSpace(m_corretor.email))//Email para enviar
                            {
                                mail.To.Add(new System.Net.Mail.MailAddress(m_corretor.email));//Email para enviar
                            }
                            else
                            {
                                //splashScreenManager1.CloseWaitForm();
                                MessageBox.Show("Não foi encontrado E-mail para envio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            /*if (cbxEnviarCopiarEmailAviso.Checked == true)
                                mail.CC.Add(new System.Net.Mail.MailAddress(m_emailConfig.smtpemail));
                            if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                                mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                            mail.IsBodyHtml = true;
                            mail.Subject = "Aviso Pendênte Resolvida Prime/Valle!  Venda:(" + Venda + ")";//Assunto do email

                            var EmailHtml =
                                @"<h2 style=""text-align: center;""><span style=""color: #ff0000;""><strong><span style=""color: #339966;"">Pend&ecirc;ncia Resolvida</span> <img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-smile.gif"" alt=""smile"" /><br /></strong></span></h2>" +
@"<hr />" +
@"<p style=""text-align: center;""><span style=""text-decoration: underline;""><span style=""color: #000000;""><strong>Dados da Venda</strong></span></span></p>" +
@"<ul>" +
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Empreendimento: </strong><span style=""color: #008000;"">"+Loteamento+"</span><br /></span></li>" +
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Quadra:</strong> <span style=""color: #008000;"">"+Qd+"</span> <strong>Lote:</strong>"+
@"<span style=""color: #008000;"">"+Lt+"</span></span></li>" +
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Corretor:</strong> <span style=""color: #008000;"">"+Corretor+"</span></span></li>"+
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Cliente:</strong> <span style=""color: #008000;"">"+Cliente+"</span></span></li>"+
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Data Venda:</strong> <span style=""color: #008000;"">"+DataVenda+"</span></span></li>"+
@"<li style=""text-align: left;""><span style=""color: #000000;""><strong>Pend&ecirc;ncia:</strong> <span style=""color: #008000;"">"+Pendencia+"</span></span></li>"+
@"</ul>" +
@"<p style=""text-align: left;"">&nbsp;</p>" +
@"<p style=""text-align: left;""><span style=""color: #000000;""><strong>OBS:</strong> Este E-mail confirma que sua&nbsp; Pend&ecirc;ncia foi <span style=""color: #ff0000;"">RESOLVIDA</span> Obrigado(a).</span></p>"+
@"<hr />" +
@"<p><span style=""color: #0000ff;""><span style=""color: #000000;"">&copy;2018 -</span> <strong><span style=""color: #0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
@"<p style=""text-align: left;"">&nbsp;</p>";
                                
                            mail.Body = EmailHtml;
                            await smtp.SendMailAsync(mail);
                            MessageBox.Show("E -mail Enviado com sucesso para:" + m_corretor.email + " avisando que a pendência do corretor(a):" + Corretor+" foi RESOLVIDA!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Tipo de aviso somente para contratos com Pendência com status = Resolvido", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
