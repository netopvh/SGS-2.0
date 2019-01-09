using DevExpress.XtraSplashScreen;
using SGS.Controle;
using SGS.Enum;
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
    public partial class v_NovaPendencia : DevExpress.XtraEditors.XtraForm
    {
        bool _alterarCad;
        
        c_Pendencias c_pendencias;
        m_Pendencias m_pendencias;
        c_Loteamento c_loteamento;
        m_Loteamento m_loteamento;
        c_Corretor c_corretor;
        m_Corretor m_corretor;
        c_EmailConfig c_emailConfig;
        m_EmailConfig m_emailConfig;
        public v_NovaPendencia()
        {
            InitializeComponent();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
        }
        public v_NovaPendencia(string UsuarioCad,bool AlterarCad)
        {
            InitializeComponent();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            dteDataCadPendencia.Text = DateTime.Now.ToShortDateString();
            m_pendencias.usuariocad = UsuarioCad;
            _alterarCad = AlterarCad;
        }
        public v_NovaPendencia(int CodigoPendencia,int CodigoLoteamento,int CodigoCorretor,string Quadra,string Lote,string Cliente,string Venda,string NumeroContrato,string Pendencia,DateTime DataVenda,DateTime DataCadVenda,DateTime DataCadPendencia,string UsuarioCad,bool AlterarCad)
        {
            InitializeComponent();
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendencias = new m_Pendencias();
            this.c_emailConfig = new c_EmailConfig();
            this.m_emailConfig = new m_EmailConfig();
            m_pendencias.idpendencias = CodigoPendencia;
            m_pendencias.usuariocad = UsuarioCad;
            LookUpEditLoteamento.EditValue = CodigoLoteamento;
            LookUpEditCorretor.EditValue = CodigoCorretor;
            txtQuadra.Text = Quadra;
            txtLote.Text = Lote;
            txtCliente.Text = Cliente;
            txtVenda.Text = Venda;
            txtNumeroContrato.Text = NumeroContrato;
            txtPendencia.Text = Pendencia;
            dtpDataVenda.Value = DataVenda;
            dtpDataCad.Value = DataCadVenda;
            dteDataCadPendencia.EditValue = DataCadPendencia;
            this.Text = "Alterar Pendência";
            _alterarCad = AlterarCad;
            cbxAvisarCorretorPendencia.Checked = false;
        }

        private void v_NovaPendencia_Load(object sender, EventArgs e)
        {
            CancelButton = btnCancelar;
            txtQuadra.Properties.MaxLength = 3;
            txtLote.Properties.MaxLength = 3;
            txtVenda.Properties.MaxLength = 10;
            txtNumeroContrato.Properties.MaxLength = 10;
            txtPendencia.Properties.MaxLength = 150;
            CarregarCorretores();
            CarregarLoteamentos();
            
        }
        private void CarregarCorretores()
        {
            DataTable dtCorretor = new DataTable();
            dtCorretor = c_corretor.CarregarCorretor();
            LookUpEditCorretor.Properties.DataSource = dtCorretor;
            LookUpEditCorretor.Properties.DisplayMember = "nome";
            LookUpEditCorretor.Properties.ValueMember = "idcorretor";
            if (_alterarCad == false)
            {
                
                LookUpEditCorretor.ItemIndex = -1;
            }
            else
            {
                
            }
            
        }
        private void CarregarLoteamentos()
        {
            DataTable dtLoteamento = new DataTable();
            
            dtLoteamento = c_loteamento.CarregarLoteamentoObra("3");
            LookUpEditLoteamento.Properties.DataSource = dtLoteamento;
            LookUpEditLoteamento.Properties.DisplayMember = "nome";
            LookUpEditLoteamento.Properties.ValueMember = "idloteamento";
            if (_alterarCad == false)
            {
                
                LookUpEditLoteamento.ItemIndex = -1;
            }
            else
            {
                
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtualizarGrid()
        {
            v_Pendencias v = Application.OpenForms["v_Pendencias"] as v_Pendencias;
            if (v != null)
            {
                v.CarregarPendencias();
            }
        }
        private void DesativaTela()
        {
            
            gbxNovaPendencia.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            
        }
        private void AtivaTela()
        {
            
            gbxNovaPendencia.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtCliente.Text != string.Empty && txtPendencia.Text != string.Empty && txtQuadra.Text != string.Empty && txtLote.Text != string.Empty && LookUpEditCorretor.Text != string.Empty && LookUpEditLoteamento.Text != string.Empty)
                {
                    if (MessageBox.Show("Deseja salvar ?", "SGS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        m_pendencias.nomecliente = txtCliente.Text;
                        m_pendencias.quadra = txtQuadra.Text;
                        m_pendencias.lote = txtLote.Text;
                        m_pendencias.numerocontrato = txtNumeroContrato.Text;
                        m_pendencias.pendencia = txtPendencia.Text;
                        m_pendencias.datacadastro = Convert.ToDateTime(dtpDataCad.Value.ToShortDateString());
                        m_pendencias.datavenda = Convert.ToDateTime(dtpDataVenda.Value.ToShortDateString());
                        m_pendencias.datacadpendencia = Convert.ToDateTime(dteDataCadPendencia.Text);
                        m_pendencias.venda = txtVenda.Text;
                        m_pendencias.fk_corretor_pendencias = (int)LookUpEditCorretor.EditValue;
                        m_pendencias.fk_loteamento_pendencias = (int)LookUpEditLoteamento.EditValue;
                        //Status pendencia 0 = corretor, 1 = resolvido.
                        
                        if (cbxAvisarCorretorPendencia.Checked == true)
                        {
                            splashScreenManagerP.ShowWaitForm();
                            DesativaTela();

                            using (System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient())
                            {
                                m_corretor.idcorretor = Convert.ToInt32(LookUpEditCorretor.EditValue);
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
                                        AtivaTela();
                                        splashScreenManagerP.CloseWaitForm();

                                        MessageBox.Show("Não foi encontrado E-mail para envio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    if (cbxEnviarCopiarEmailAviso.Checked == true)
                                        mail.CC.Add(new System.Net.Mail.MailAddress(m_emailConfig.smtpemail));
                                    /*if (!string.IsNullOrWhiteSpace(textBoxCCo.Text))
                                        mail.Bcc.Add(new System.Net.Mail.MailAddress(textBoxCCo.Text));*/
                                    mail.IsBodyHtml = true;
                                    mail.Subject = "Aviso Contrato Pendênte Prime/Valle!  Venda:(" + txtVenda.Text + ")";//Assunto do email

                                    var EmailHtml =
            @"<h2 style=""text - align: center; ""><span style=""color: #ff0000;""><strong>Aviso de Contrato com Pend&ecirc;ncia <img src=""https://html-online.com/editor/tinymce4_6_5/plugins/emoticons/img/smiley-frown.gif"" alt=""frown"" /><br /></strong></span></h2>" +
            @"<hr />" +
            @"<p style=""text - align: center; ""><span style=""text - decoration: underline; ""><span style=""color: #000000;""><strong>Dados da Venda:</strong></span></span></p>" +
            @"<ul>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Empreendimento: </strong><span style=""color: #008000;"">" + LookUpEditLoteamento.Text + "</span><br /></span></li>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Quadra:</strong> <span style=""color: #008000;"">" + txtQuadra.Text + "</span> <strong>Lote:</strong>" +
            @"<span style=""color: #008000;"">" + txtLote.Text + "</span></span></li>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Corretor:</strong> <span style=""color: #008000;"">" + LookUpEditCorretor.Text + "</span></span></li>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Cliente:</strong> <span style=""color: #008000;"">" + txtCliente.Text + "</span></span></li>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Data Venda:</strong> <span style=""color: #008000;"">" + dtpDataVenda.Text + "</span></span></li>" +
            @"<li style=""text - align: left; ""><span style=""color: #000000;""><strong>Pend&ecirc;ncia:</strong> <span style=""color: #008000;"">" + txtPendencia.Text + "</span></span></li>" +
            @"</ul>" +
            @"<p style=""text - align: left; "">&nbsp;</p>" +
            @"<p style=""text - align: left; ""><span style=""color: #000000;""><strong>OBS:</strong> Procure o escr&iacute;torio o mais r&aacute;pido poss&iacute;vel para resolver sua pend&ecirc;ncia e evitar que o pagamento da sua comiss&atilde;o seja <strong><span style=""color: #ff0000;"">bloqueada!</span></strong></span></p>" +
            @"<hr />" +
            @"<p><span style=""color: #0000ff;""><span style=""color: #000000;"">&copy;2018 -</span> <strong><span style=""color: #0000ff;"">Viva Bem, Viva Valle...</span></strong></span></p>" +
            @"<p style=""text - align: left; "">&nbsp;</p>";
                                    mail.Body = EmailHtml;
                                    await smtp.SendMailAsync(mail);
                                    //MessageBox.Show("Enviado com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    splashScreenManagerP.CloseWaitForm();
                                }

                            }

                        }

                        if (_alterarCad == true)
                        {
                            m_pendencias.status = (int)e_StatusPendencia.A_Resolver;
                            c_pendencias.AlterarPendencias(m_pendencias);
                            MessageBox.Show("Pendência Alterada com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            this.Close();
                        }
                        else if (_alterarCad == false)
                        {
                            c_pendencias.NovoPendencias(m_pendencias);
                            MessageBox.Show("Nova Pendência Salva com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AtualizarGrid();
                            this.Close();
                        }
                    }

                }

                else
                {
                    MessageBox.Show("Verifique se todos os campos foram preenchidos!...", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error:" + ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
