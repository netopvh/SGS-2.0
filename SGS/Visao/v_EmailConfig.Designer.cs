namespace SGS.Visao
{
    partial class v_EmailConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaEmail = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHostSMTP = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPortaSMTP = new DevExpress.XtraEditors.TextEdit();
            this.cbxSSL = new System.Windows.Forms.CheckBox();
            this.cbxCredencialPadrao = new System.Windows.Forms.CheckBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnEmailTeste = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostSMTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaSMTP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(8, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Mask.EditMask = "(\\w|[\\.\\-])+@(\\w|[\\-]+\\.)*(\\w|[\\-]){2,63}\\.[a-zA-Z]{2,4}";
            this.txtEmail.Size = new System.Drawing.Size(307, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha do Email:";
            // 
            // txtSenhaEmail
            // 
            this.txtSenhaEmail.Location = new System.Drawing.Point(8, 75);
            this.txtSenhaEmail.Name = "txtSenhaEmail";
            this.txtSenhaEmail.Properties.UseSystemPasswordChar = true;
            this.txtSenhaEmail.Size = new System.Drawing.Size(307, 20);
            this.txtSenhaEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host SMTP:";
            // 
            // txtHostSMTP
            // 
            this.txtHostSMTP.Location = new System.Drawing.Point(8, 37);
            this.txtHostSMTP.Name = "txtHostSMTP";
            this.txtHostSMTP.Size = new System.Drawing.Size(307, 20);
            this.txtHostSMTP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porta:";
            // 
            // txtPortaSMTP
            // 
            this.txtPortaSMTP.Location = new System.Drawing.Point(8, 76);
            this.txtPortaSMTP.Name = "txtPortaSMTP";
            this.txtPortaSMTP.Properties.Mask.EditMask = "d";
            this.txtPortaSMTP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPortaSMTP.Size = new System.Drawing.Size(80, 20);
            this.txtPortaSMTP.TabIndex = 4;
            // 
            // cbxSSL
            // 
            this.cbxSSL.AutoSize = true;
            this.cbxSSL.Location = new System.Drawing.Point(99, 78);
            this.cbxSSL.Name = "cbxSSL";
            this.cbxSSL.Size = new System.Drawing.Size(43, 17);
            this.cbxSSL.TabIndex = 5;
            this.cbxSSL.Text = "SSL";
            this.cbxSSL.UseVisualStyleBackColor = true;
            // 
            // cbxCredencialPadrao
            // 
            this.cbxCredencialPadrao.AutoSize = true;
            this.cbxCredencialPadrao.Location = new System.Drawing.Point(148, 78);
            this.cbxCredencialPadrao.Name = "cbxCredencialPadrao";
            this.cbxCredencialPadrao.Size = new System.Drawing.Size(113, 17);
            this.cbxCredencialPadrao.TabIndex = 6;
            this.cbxCredencialPadrao.Text = "Credencial Padrão";
            this.cbxCredencialPadrao.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtSenhaEmail);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(328, 112);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Conta";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtHostSMTP);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtPortaSMTP);
            this.groupControl2.Controls.Add(this.cbxSSL);
            this.groupControl2.Controls.Add(this.cbxCredencialPadrao);
            this.groupControl2.Location = new System.Drawing.Point(12, 130);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(328, 108);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Servidor SMTP";
            // 
            // btnEmailTeste
            // 
            this.btnEmailTeste.ImageOptions.Image = global::SGS.Properties.Resources.EnviarEmail24x24;
            this.btnEmailTeste.Location = new System.Drawing.Point(87, 244);
            this.btnEmailTeste.Name = "btnEmailTeste";
            this.btnEmailTeste.Size = new System.Drawing.Size(91, 44);
            this.btnEmailTeste.TabIndex = 7;
            this.btnEmailTeste.Text = "Email Teste";
            this.btnEmailTeste.Click += new System.EventHandler(this.btnEmailTeste_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(184, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(265, 244);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // v_EmailConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 294);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnEmailTeste);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_EmailConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Email";
            this.Load += new System.EventHandler(this.v_EmailConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostSMTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaSMTP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSenhaEmail;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtHostSMTP;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtPortaSMTP;
        private System.Windows.Forms.CheckBox cbxSSL;
        private System.Windows.Forms.CheckBox cbxCredencialPadrao;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnEmailTeste;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}