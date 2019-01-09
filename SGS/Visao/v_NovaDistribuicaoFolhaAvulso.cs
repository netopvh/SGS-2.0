using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
using SGS.Modelo;
namespace SGS.Visao
{
    public partial class v_NovaDistribuicaoFolhaAvulso : DevExpress.XtraEditors.XtraForm
    {
        c_EmailConfig c_emailConfig;
        m_EmailConfig m_emailConfig;
        m_DistribuicaoFolhasAvulsas m_DistFolhasAvulsas;
        c_DistribuicaoFolhasAvulsas c_DistFolhasAvulsas;
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        c_Loteamento c_Empreendimento;
        string _UsuarioCad;
        bool _AlterarCad;
        public v_NovaDistribuicaoFolhaAvulso()
        {
            InitializeComponent();
            this.c_DistFolhasAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_DistFolhasAvulsas = new m_DistribuicaoFolhasAvulsas();
            this.c_corretor = new c_Corretor();
            this.c_Empreendimento = new c_Loteamento();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            this.m_corretor = new m_Corretor();
        }
        public v_NovaDistribuicaoFolhaAvulso(string UsuarioCad)//Nova dist
        {
            InitializeComponent();
            this.c_DistFolhasAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_DistFolhasAvulsas = new m_DistribuicaoFolhasAvulsas();
            this.c_corretor = new c_Corretor();
            this.c_Empreendimento = new c_Loteamento();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            this.m_corretor = new m_Corretor();
            _UsuarioCad = UsuarioCad;

        }
        public v_NovaDistribuicaoFolhaAvulso(int CodigoDist,int Corretor,int Empreendimento,DateTime DataDist,string Folha,decimal ValorFolha,string FormaPagamento,string UsuarioCad,bool AlterarCad)//Alterar Dist
        {
            InitializeComponent();
            this.c_DistFolhasAvulsas = new c_DistribuicaoFolhasAvulsas();
            this.m_DistFolhasAvulsas = new m_DistribuicaoFolhasAvulsas();
            this.c_corretor = new c_Corretor();
            this.c_Empreendimento = new c_Loteamento();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            this.m_corretor = new m_Corretor();
            m_DistFolhasAvulsas.iddistribuicaofolhasavulsas = CodigoDist;
            cbxCorretor.EditValue = Corretor;
            cbxEmpreendimento.EditValue = Empreendimento;
            dtpDataDistribuicao.Value = DataDist;
            cbxFolha.EditValue = Folha;
            txtValorFolha.Text = Convert.ToString(ValorFolha);
            if (FormaPagamento == "Á Vista")
            {
                rbtPGAvista.Checked = true;
            }
            else if (FormaPagamento == "Á Prazo")
            {
                rbtPGAprazo.Checked = true;
            }
            _UsuarioCad = UsuarioCad;
            _AlterarCad = AlterarCad;
            cbxNotificarCorretorEmail.Checked = false;
            this.Text = "Alterar Distribuição de Folha Avulso";
            btnSalvar.Text = "Alterar";

        }

        private void v_NovaDistribuicaoFolhaAvulso_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            CarregarCorretores();
            CarrgearEmpreendimentos();
            
        }
        private void CarregarCorretores()
        {
            cbxCorretor.Properties.DataSource = c_corretor.CarregarCorretor();
            cbxCorretor.Properties.DisplayMember = "nome";
            cbxCorretor.Properties.ValueMember = "idcorretor";
            if (_AlterarCad == false)
            {
                cbxCorretor.ItemIndex = -1;
            }
            else
            {

            }
        }
        private void CarrgearEmpreendimentos()
        {
            cbxEmpreendimento.Properties.DataSource = c_Empreendimento.CarregarLoteamentoObra("2");
            cbxEmpreendimento.Properties.DisplayMember = "nome";
            cbxEmpreendimento.Properties.ValueMember = "idloteamento";
            if (_AlterarCad == false)
            {
                cbxEmpreendimento.ItemIndex = -1;

            }
            else
            {

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtualizarGrid()
        {
            v_DistFolhaAvulso v = Application.OpenForms["v_DistFolhaAvulso"] as v_DistFolhaAvulso;
            if (v != null)
            {
                v.CarregarGrid();
            }
        }
        private void funcao(string funcao)
        {
            switch (funcao)
            {
                case "salvar":
                    m_DistFolhasAvulsas.datadistribuicao = dtpDataDistribuicao.Value;
                    m_DistFolhasAvulsas.folhapagina = Convert.ToString(cbxFolha.EditValue);
                    m_DistFolhasAvulsas.valorfolha = Convert.ToDecimal(txtValorFolha.Text.Replace("R$",""));
                    m_DistFolhasAvulsas.fk_corretor_distribuicaofolhasavulsas = Convert.ToInt32(cbxCorretor.EditValue);
                    m_DistFolhasAvulsas.fk_loteamento_distribuicaofolhasavulsas = Convert.ToInt32(cbxEmpreendimento.EditValue);
                    m_DistFolhasAvulsas.usuariocad = _UsuarioCad;
                    if (rbtPGAprazo.Checked == true)
                    {
                        m_DistFolhasAvulsas.formapagamento = "Á Prazo";
                    }
                    else if (rbtPGAvista.Checked == true)
                    {
                        m_DistFolhasAvulsas.formapagamento = "Á Vista";
                    }
                    if (_AlterarCad == false)
                    {

                        c_DistFolhasAvulsas.NovaDistribuicao(m_DistFolhasAvulsas);
                        MessageBox.Show("Distribuido com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                        /*
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
                        iRetorno = MP2064.IniciaPorta(Porta);
                        // \n - quebra de linha e \r retorno de impressão (comandos da impressora)
                        iRetorno = MP2064.FormataTX("\r\n\r\n" + Impressao + "\r\n\r\n", 2, 0, 0, 0, 1);//ao ser clicado, imprime 
                        iRetorno = MP2064.AcionaGuilhotina(1);//chama a função da DLL(Corte Total)
                        MessageBox.Show("Sequencia de Contrato(s) de N° " + txtSqcInicial.Value.ToString() + " até " + txtSqcFinal.Value.ToString() + " distribuido(s) com Sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarGrid();
                        this.Close();
                        */
                    }
                    else if (_AlterarCad == true)
                    {
                        c_DistFolhasAvulsas.AlterarDistribuicao(m_DistFolhasAvulsas);
                        MessageBox.Show("Atualizado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGrid();
                        this.Close();
                    }
                    break;
                default:
                    break;
            }
        }
        private void DesativarForm()
        {
            gbxDistribuir.Enabled = false;
            btnSalvar.Enabled = false;
            btnVoltar.Enabled = false;
            cbxNotificarCorretorEmail.Enabled = false;
        }
        private void AtivarForm()
        {
            gbxDistribuir.Enabled = true;
            btnSalvar.Enabled = true;
            btnVoltar.Enabled = true;
            cbxNotificarCorretorEmail.Enabled = true;
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbxCorretor.Text != string.Empty && cbxEmpreendimento.Text != string.Empty && cbxFolha.Text != string.Empty || rbtPGAprazo.Checked == true || rbtPGAvista.Checked == true)
                {
                    if (MessageBox.Show("Deseja Salvar a distribuição?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        if (cbxNotificarCorretorEmail.Checked == true)
                        {
                            splashScreenManagerP.ShowWaitForm();
                            DesativarForm();
                            try
                            {
                                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                                {
                                    m_corretor.idcorretor = Convert.ToInt32(cbxCorretor.EditValue);
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
                                            //AtivarForm();

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
                                        mail.Subject = "Distribuição " + cbxFolha.Text + " Avulso do " + cbxEmpreendimento.Text;//Assunto do email

                                        var EmailHtml =
                                            @"<h2 style=""text-align: center;""><span style=""color: #ff0000;""><strong><span style=""color: #0000ff;"">Distribui&ccedil;&atilde;o de Folha Avulso</span> <img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-smile.gif"" alt=""smile"" /><br /></strong></span></h2>" +
                                            @"<hr/>" +
                                            @"<p><strong>&Oacute;la este &eacute; um e-mail autom&aacute;tico:</strong></p>" +
                                            @"<p style=""text-align:left;"">Foi distribuido para o Corretor:<span style=""color:#008000;""><strong>" + cbxCorretor.Text + "</strong></span>" +
                                            @", a folha avulso:<span style=""color:#008000;""><strong>" + cbxFolha.Text + "</strong></span>" +
                                            @" do empreendimento:<span style=""color:#008000;""><strong>" + cbxEmpreendimento.Text + "</strong>.</span></p>" +
                                            @"<p style=""text-align:left;""><span style=""color:#000000;""><strong>OBS:</strong><span style=""color:#ff0000;"">Se voc&ecirc; n&atilde;o solicitou ou n&atilde;o auturizou a distribui&ccedil;&atilde;o dessa folha no seu nome, por favor entre em contato com escritorio administrativo e informe sobre este e-mail, ou caso voc&ecirc; n&atilde;o seja esse corretor apenas avise que chegou e-mail pro corretor errado, obrigado.</span><br/></span></p>" +
                                            @"<hr/>" +
                                            @"<p><span style=""color: #0000ff;""><span style=""color: #000000;"">&copy;2018 -</span> <strong><span style=""color: #0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
                                            @"<p style=""text-align: left;"">&nbsp;</p>";
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
                    MessageBox.Show("Verifique se todos os campos estão preenchidos!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
