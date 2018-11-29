using SGS.Controle;
using SGS.Modelo;
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
    public partial class v_EmailConfig : DevExpress.XtraEditors.XtraForm
    {
        c_EmailConfig c_emailConfig;
        m_EmailConfig m_emailConfig;
        public v_EmailConfig()
        {
            InitializeComponent();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
        }
        

        private void v_EmailConfig_Load(object sender, EventArgs e)
        {
            CancelButton = btnVoltar;
            VerificarConfigEmailAtiva();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            m_emailConfig.smtphost = txtHostSMTP.Text;
            m_emailConfig.smtpemail = txtEmail.Text;
            m_emailConfig.smtpsenhaemail = txtSenhaEmail.Text;
            m_emailConfig.smtpporta = Convert.ToInt32(txtPortaSMTP.Text);
            if (cbxCredencialPadrao.Checked == true)
            {
                m_emailConfig.smtpcredencialpadrao = true;
            }
            else if(cbxSSL.Checked == false)
            {
                m_emailConfig.smtpcredencialpadrao = false;
            }
            if (cbxSSL.Checked == true)
            {
                m_emailConfig.smtpssl = true;
            }
            else if (cbxSSL.Checked == false)
            {
                m_emailConfig.smtpssl = false;
            }
            
            if (VerificarConfigEmailAtiva() == false && MessageBox.Show("Deseja salvar a configuração de Email?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                c_emailConfig.PrimeiraConfigEmail(m_emailConfig);

                MessageBox.Show("Configuração de Email Salvo com sucesso!", "SGS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                

            }
            else if (VerificarConfigEmailAtiva() == true && MessageBox.Show("Deseja salvar as alterações de configuração de Email?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c_emailConfig.AlterarConfigEmail(m_emailConfig);
                MessageBox.Show("Alterações na Configuração de Email Salvo com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool VerificarConfigEmailAtiva()
        {

            m_emailConfig.smtpemail = c_emailConfig.GetSMTpEmail();
            bool Resultado;
            if (m_emailConfig.smtpemail != string.Empty)
            {
                
                Resultado = true;
                txtEmail.Text = c_emailConfig.GetSMTpEmail();
                txtHostSMTP.Text = c_emailConfig.GetSMTPHost();
                txtPortaSMTP.Text = c_emailConfig.GetSMTPPorta();
                txtSenhaEmail.Text = c_emailConfig.GetSMTPSenhaEmail();
                if (c_emailConfig.GetSMTPCredencialPadrao() == true)
                {
                    cbxCredencialPadrao.Checked = true;
                }
                else if (c_emailConfig.GetSMTPCredencialPadrao() == false)
                {
                    cbxCredencialPadrao.Checked = false;
                }
                if(c_emailConfig.GetSMTPSSL() == true)
                {
                    cbxSSL.Checked = true;
                }
                else if (c_emailConfig.GetSMTPSSL() == false)
                {
                    cbxSSL.Checked = false;
                }
                // Modelo
                m_emailConfig.smtphost = txtHostSMTP.Text;
                m_emailConfig.smtpemail = txtEmail.Text;
                m_emailConfig.smtpsenhaemail = txtSenhaEmail.Text;
                m_emailConfig.smtpporta = Convert.ToInt32(txtPortaSMTP.Text);
                if (cbxCredencialPadrao.Checked == true)
                {
                    m_emailConfig.smtpcredencialpadrao = true;
                }
                else if (cbxSSL.Checked == false)
                {
                    m_emailConfig.smtpcredencialpadrao = false;
                }
                if (cbxSSL.Checked == true)
                {
                    m_emailConfig.smtpssl = true;
                }
                else if (cbxSSL.Checked == false)
                {
                    m_emailConfig.smtpssl = false;
                }
            }
            else
            {
                Resultado = false;
                MessageBox.Show("Atenção você irá configurar pela primeira vez a conta de email do sistema!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            return Resultado;
        }

        private async void btnEmailTeste_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Aguarde uma messagem de teste foi enviado para o Email:" + txtEmail.Text, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            try
            {
                using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                {
                    smtp.Host = m_emailConfig.smtphost;//"smtp.gmail.com"
                    smtp.Port = m_emailConfig.smtpporta;//587
                    smtp.EnableSsl = m_emailConfig.smtpssl;//true
                    smtp.UseDefaultCredentials = m_emailConfig.smtpcredencialpadrao;//false
                    smtp.Credentials = new System.Net.NetworkCredential(m_emailConfig.smtpemail, m_emailConfig.smtpsenhaemail);

                    using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                    {
                        mail.From = new System.Net.Mail.MailAddress(txtEmail.Text);//Conta de email que vai usar

                        if (!string.IsNullOrWhiteSpace(txtEmail.Text))//Email para enviar
                        {
                            mail.To.Add(new System.Net.Mail.MailAddress(txtEmail.Text));//Email para enviar
                        }
                        else
                        {
                            MessageBox.Show("Campo Email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        /*if (!string.IsNullOrWhiteSpace(textBoxCC.Text))
                            mail.CC.Add(new System.Net.Mail.MailAddress(textBoxCC.Text));
                        if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                            mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                        mail.Subject = "Email teste configuração SGS";//Assunto do email
                        mail.Body = "Você configurou com sucesso o email:" + txtEmail.Text;//Corpo do Email
                        await smtp.SendMailAsync(mail);
                        MessageBox.Show("Enviado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Não foi possivel enviar o email teste para o email:" + txtEmail.Text+"\n"+ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
