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
    public partial class v_RecuperarSenha : DevExpress.XtraEditors.XtraForm
    {
        c_Usuario c_usuario;
        m_Usuario m_usuario;
        c_EmailConfig c_emailConfig;
        m_EmailConfig m_emailConfig;
        Random rnd = new Random();
        int _SenhaTemporaria;
        //senha = rnd.Next(1,7) vai cria senha entre 1 a 6
        public v_RecuperarSenha()
        {
            InitializeComponent();
            this.c_usuario = new c_Usuario();
            this.m_usuario = new m_Usuario();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DesativarTela()
        {
            txtEmail.Enabled = false;
            txtUsuario.Enabled = false;
            btnRecuperar.Enabled = false;
        }
        private void AtivaTela()
        {
            txtEmail.Enabled = true;
            txtUsuario.Enabled = true;
            btnRecuperar.Enabled = true;
        }

        private async void btnRecuperar_Click(object sender, EventArgs e)
        {

            try
            {
                if (c_usuario.AutenticarUsuarioEmail(txtUsuario.Text, txtEmail.Text))
                {
                    splashScreenManagerR.ShowWaitForm();
                    DesativarTela();
                    
                    m_usuario.login = txtUsuario.Text;
                    m_usuario.emailpessoal = txtEmail.Text;
                    _SenhaTemporaria = rnd.Next(1000, 9999);
                    m_usuario.senha = Convert.ToString(_SenhaTemporaria);
                    c_usuario.AlterarSenhaUsuario(m_usuario);


                    using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                    {

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

                            if (!string.IsNullOrWhiteSpace(txtEmail.Text))//Email para enviar
                            {
                                mail.To.Add(new System.Net.Mail.MailAddress(txtEmail.Text));//Email para enviar
                            }
                            else
                            {
                                AtivaTela();
                                splashScreenManagerR.CloseWaitForm();

                                MessageBox.Show("Não foi encontrado E-mail para envio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            /*if (cbxEnviarCopiarEmailAviso.Checked == true)
                                mail.CC.Add(new System.Net.Mail.MailAddress(m_emailConfig.smtpemail));
                            /*if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                                mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                            mail.IsBodyHtml = true;
                            mail.Subject = "SGS - Nova Senha de Acesso no Login: " + txtUsuario.Text + "";//Assunto do email

                            var EmailHtml =
                                @"<h2 style=""text-align: center;""><span style=""color:#ff0000;""><strong><span style=""color:#339966;"">Recuperar Acesso no SGS</span> <img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-smile.gif""alt=""smile""/><br/></strong></span></h2>" +
                                @"<hr/>" +
                                @"<p>Ol&aacute;, sua nova senha &eacute;:"+_SenhaTemporaria+"</p>" +
                                @"<p style=""text-align:left;""><span style=""color:#000000;""><strong>OBS:</strong> Pe&ccedil;a para o administrador do sistema troca a senha para voc&ecirc;.<br/></span></p>" +
                                @"<hr/>" +
                                @"<p><span style=""color:#0000ff;""><span style=""color: #000000;"">&copy;2018 -</span><strong><span style=""color:#0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
                                @"<p style=""text-align:left;"">&nbsp;</p>";
                            mail.Body = EmailHtml;
                            await smtp.SendMailAsync(mail);
                            MessageBox.Show("Um e-mail foi enviado para " + txtEmail.Text + " com uma nova senha!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            splashScreenManagerR.CloseWaitForm();
                            this.Close();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Não foi encontrado Usuário/E-mail favor verifique!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.Message, "SGS - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }

        private void v_RecuperarSenha_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            AcceptButton = btnRecuperar;

        }
    }
}
