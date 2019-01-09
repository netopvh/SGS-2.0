using SGS.Controle;
using SGS.Enum;
using SGS.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao
{
    public partial class v_NovaDistribuicaoContrato : DevExpress.XtraEditors.XtraForm
    {

        int iRetorno = 0; //Variável para retorno das chamadas
        string _usuarioCad;
        bool _Alterar = false;
        m_Distribuicaocontratos m_distribuicaoContratos;
        c_Distribuicaocontratos c_distribuicaoContratos;
        m_Loteamento m_loteamento;
        c_Loteamento c_loteamento;
        m_Corretor m_corretor;
        c_Corretor c_corretor;
        m_EmailConfig m_emailConfig;
        c_EmailConfig c_emailConfig;
        public v_NovaDistribuicaoContrato()
        {
            InitializeComponent();
        }
        public v_NovaDistribuicaoContrato(string UsuarioCad)
        {
            InitializeComponent();
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            _usuarioCad = UsuarioCad;
        }
        private void v_NovaDistribuicaoContrato_Load(object sender, EventArgs e)
        {
            CarregarCorretores();
            CarregarEmpreendimentos();
        }
        public v_NovaDistribuicaoContrato(string UsuarioCad,bool Alterar,int CodigoDistribuicao,string Empreendimento,string Corretor,int NumeroContrato,DateTime DataDistribuicao)//Atualizar//Editar Distribuição
        {
            
            this.c_distribuicaoContratos = new c_Distribuicaocontratos();
            this.m_distribuicaoContratos = new m_Distribuicaocontratos();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            InitializeComponent();
            btnSalvar.Text = "Alterar";
            this.Text = "Alterar distribuição de Contrato";
            m_distribuicaoContratos.iddistribuicaocontratos = CodigoDistribuicao;
            _usuarioCad = UsuarioCad;
            lookUpEditCorretor.EditValue = Corretor;
            lookUpEditEmpreendimento.EditValue = Empreendimento;
            txtSqcInicial.Value = NumeroContrato;
            dtpDataDistribuicao.Value = DataDistribuicao;
            txtSqcFinal.Value = txtSqcInicial.Value;
            _Alterar = Alterar;
            txtSqcFinal.Enabled = false;
            cbxAvisarPorEmail.Checked = false;
            
        }
        private void AtivarForm()
        {
            gbxDados.Enabled = true;
            btnSalvar.Enabled = true;
            btnVoltar.Enabled = true;
        }
        private void DesativarForm()
        {
            gbxDados.Enabled = false;
            btnSalvar.Enabled = false;
            btnVoltar.Enabled = false;

        }
        
        private void CarregarCorretores()
        {

            DataTable dtc = new DataTable();
            dtc = c_corretor.CarregarCorretor();
            lookUpEditCorretor.Properties.DataSource = dtc;
            lookUpEditCorretor.Properties.DisplayMember = "nome";
            lookUpEditCorretor.Properties.ValueMember = "idcorretor";
            if (_Alterar == false)
            {
                lookUpEditCorretor.ItemIndex = -1;
            }
            else
            {

            }
        }
        private void CarregarEmpreendimentos()
        {
            DataTable dte = new DataTable();
            dte = c_loteamento.CarregarLoteamentoObra("1");
            lookUpEditEmpreendimento.Properties.DataSource = dte;
            lookUpEditEmpreendimento.Properties.DisplayMember = "nome";
            lookUpEditEmpreendimento.Properties.ValueMember = "idloteamento";
            if (_Alterar == false)
            {
                lookUpEditEmpreendimento.ItemIndex = -1;
            }
            else
            {

            }

        }
        private void TotalContratos()
        {
            int inicial, final, total;
            inicial = (int)txtSqcInicial.Value;
            final = (int)txtSqcFinal.Value;
            total = final - inicial + 1;
            lblTotalContratos.Text = total.ToString();
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
               
                case "salvar":
                    for (int i = (int)txtSqcInicial.Value; i <= (int)txtSqcFinal.Value; i++)
                    {
                        /*
                        Distribuido = 0,
                        Cancelado = 1,
                        Devolvido = 2,
                        Extraviado = 3
                        */
                        m_distribuicaoContratos.numerocontrato = i;
                        m_distribuicaoContratos.usuariocad = _usuarioCad;
                        m_distribuicaoContratos.status = (int)e_StatusDistribuicao.Distribuido;
                        m_distribuicaoContratos.datadistribuicao = dtpDataDistribuicao.Value;
                        m_distribuicaoContratos.fk_corretor_distribuicaocontratos = Convert.ToInt32(lookUpEditCorretor.EditValue);
                        m_distribuicaoContratos.fk_loteamento_distribuicaocontratos = Convert.ToInt32(lookUpEditEmpreendimento.EditValue);
                        if (_Alterar == false)
                        {
                            c_distribuicaoContratos.NovaDistribuicao(m_distribuicaoContratos);
                            
                        }
                        else if (_Alterar == true)
                        {
                            c_distribuicaoContratos.AlterarDistribuicao(m_distribuicaoContratos);
                            
                        }
                        
                    }
                    if (_Alterar == false)
                    {
                        var Impressao =
                    "****************** PROTOCOLO *******************\n" +
                    "\n" +
                    "Número(s) Contrato(s): " + txtSqcInicial.Value + " até " + txtSqcFinal.Value + "\n" +
                    "Corretor: " + lookUpEditCorretor.Text + "\n" +
                    "Loteamento: " + lookUpEditEmpreendimento.Text + "\n" +
                    "\n" +
                    "Usuário Cad: " + _usuarioCad + "\n" +
                    "Emissão: " + DateTime.Now + "Hrs." + "\n" +
                    "************************************************" +
                    "\n" +
                    "Assinatura Corretor:" + "\n\n\n" +
                    "________________________________________________" + "\n" +
                    "Confirmo recebimento da sequencia de contrato(s).";

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
                        iRetorno = MP2064.FormataTX("\r\n\r\n" + Impressao + "\r\n\r\n", 2, 0, 0, 0, 1);//ao ser clicado, imprime 
                        iRetorno = MP2064.AcionaGuilhotina(1);//chama a função da DLL(Corte Total)
                        MessageBox.Show("Sequencia de Contrato(s) de N° " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " distribuido(s) com Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        AtualizarGrid();
                        this.Close();
                    }
                    else if (_Alterar == true)
                    {
                        MessageBox.Show("Contrato de N° " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " Atualizado com Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }
        
        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    
                    if (txtSqcInicial.Value > 0 && txtSqcFinal.Value > 0 && txtSqcInicial.Value <= txtSqcFinal.Value)
                    {
                    if (lookUpEditCorretor.Text != string.Empty && lookUpEditEmpreendimento.Text != string.Empty)
                    {
                        if (MessageBox.Show("Confirma que deseja distribuir o(s) contrato(s)?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (cbxAvisarPorEmail.Checked == true)
                            {
                                splashScreenManagerP.ShowWaitForm();
                                DesativarForm();
                                try
                                {
                                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                                    {
                                        m_corretor.idcorretor = Convert.ToInt32(lookUpEditCorretor.EditValue);
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

                                                //MessageBox.Show("Não foi encontrado E-mail para envio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                //return;
                                                splashScreenManagerP.CloseWaitForm();
                                                funcao("salvar");
                                            }
                                            /*if (cbxEnviarCopiarEmailAviso.Checked == true)
                                                mail.CC.Add(new System.Net.Mail.MailAddress(m_emailConfig.smtpemail));
                                            if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                                                mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                                            mail.IsBodyHtml = true;
                                            mail.Subject = "Distribuição de Contrato(s) " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " do " + lookUpEditEmpreendimento.Text;//Assunto do email

                                            var EmailHtml =
                    @"<h2 style=""text-align:center;""><span style=""color: #ff0000;""><strong><span style=""color:#0000ff;"">Distribui&ccedil;&atilde;o de Contrato(s)</span><img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-smile.gif""alt=""smile""/><br/></strong></span></h2> " +
                    @"<hr/>" +
                    @"<p><strong>&Oacute;la este &eacute; um e-mail autom&aacute;tico:</strong></p>" +
                    @"<p style=""text-align: left;"">Foi distribuido para o Corretor:<span style=""color:#008000;""><strong>" + lookUpEditCorretor.Text + "</strong></span>" +
                    @", a sequ&ecirc;ncia de contrato(s) com numera&ccedil;&atilde;o incial de <span style=""color: #008000;""><strong>" + txtSqcInicial.Value.ToString() + "</strong></span> at&eacute;" +
                    @" a numera&ccedil;&atilde;o final <span style=""color: #008000;""><strong>" + txtSqcFinal.Value.ToString() + "</strong></span>" +
                    @" dando um total de <span style=""color:#008000;""><strong>" + lblTotalContratos.Text + "</strong></span>" +
                    @" contrato(s) distribuido(s), do empreendimento:<span style=""color:#008000;""><strong>" + lookUpEditEmpreendimento.Text + "</strong>.</span></p>" +
                    @"<p style=""text-align:left;""><span style=""color: #000000;""><strong>OBS:</strong><span style=""color:#ff0000;"">Se voc&ecirc; n&atilde;o solicitou ou n&atilde;o auturizou a distribui&ccedil;&atilde;o de contratos no seu nome, por favor entre em contato com escritorio administrativo e informe sobre este e-mail, ou caso voc&ecirc; n&atilde;o seja esse corretor apenas avise que chegou e-mail pro corretor errado, obrigado.</span><br/></span></p> " +
                    @"<hr/>" +
                    @"<p><span style=""color:#0000ff;""><span style=""color:#000000;"">&copy;2018 -</span><strong><span style=""color:#0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
                    @"<p style=""text-align:left;"">&nbsp;</p>";
                                            mail.Body = EmailHtml;
                                            await smtp.SendMailAsync(mail);
                                            //MessageBox.Show("Enviado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //AtivarForm();
                                            splashScreenManagerP.CloseWaitForm();
                                            funcao("salvar");
                                        }

                                    }

                                }
                                catch (System.InvalidOperationException)
                                {

                                }

                            }
                            else
                            {
                                funcao("salvar");
                            }
                        }
                    }
                        
                        else
                        {
                            MessageBox.Show("Preencha todos os campos!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Informe uma sequencia válida!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void AtualizarGrid()
        {
            v_DistContrato v = Application.OpenForms["v_DistContrato"] as v_DistContrato;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }

        private void txtSqcInicial_ValueChanged(object sender, EventArgs e)
        {
            if (_Alterar == true)
            {
                
                txtSqcFinal.Value = txtSqcInicial.Value;
                txtSqcFinal.Refresh();
            }
            TotalContratos();
            
        }

        private void txtSqcFinal_ValueChanged(object sender, EventArgs e)
        {
            
            TotalContratos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSqcInicial_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtSqcInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
