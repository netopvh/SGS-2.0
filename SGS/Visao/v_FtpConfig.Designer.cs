namespace SGS.Visao
{
    partial class v_FtpConfig
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
            this.txtDiretorioVersaoUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiretorioSetupUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiretorioSalvarSetup = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenhaFTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuarioFTP = new System.Windows.Forms.TextBox();
            this.btnCopiarExemplo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório do arquivo remoto versão update:";
            // 
            // txtDiretorioVersaoUpdate
            // 
            this.txtDiretorioVersaoUpdate.Location = new System.Drawing.Point(15, 25);
            this.txtDiretorioVersaoUpdate.Name = "txtDiretorioVersaoUpdate";
            this.txtDiretorioVersaoUpdate.Size = new System.Drawing.Size(358, 21);
            this.txtDiretorioVersaoUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diretório do arquivo remoto setup update:";
            // 
            // txtDiretorioSetupUpdate
            // 
            this.txtDiretorioSetupUpdate.Location = new System.Drawing.Point(15, 65);
            this.txtDiretorioSetupUpdate.Name = "txtDiretorioSetupUpdate";
            this.txtDiretorioSetupUpdate.Size = new System.Drawing.Size(358, 21);
            this.txtDiretorioSetupUpdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diretório onde o arquivo de setup sera salvo:";
            // 
            // txtDiretorioSalvarSetup
            // 
            this.txtDiretorioSalvarSetup.Location = new System.Drawing.Point(15, 105);
            this.txtDiretorioSalvarSetup.Name = "txtDiretorioSalvarSetup";
            this.txtDiretorioSalvarSetup.Size = new System.Drawing.Size(358, 21);
            this.txtDiretorioSalvarSetup.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenhaFTP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsuarioFTP);
            this.groupBox1.Location = new System.Drawing.Point(15, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credencial de acesso FTP";
            // 
            // txtSenhaFTP
            // 
            this.txtSenhaFTP.Location = new System.Drawing.Point(182, 33);
            this.txtSenhaFTP.Name = "txtSenhaFTP";
            this.txtSenhaFTP.Size = new System.Drawing.Size(170, 21);
            this.txtSenhaFTP.TabIndex = 9;
            this.txtSenhaFTP.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuário:";
            // 
            // txtUsuarioFTP
            // 
            this.txtUsuarioFTP.Location = new System.Drawing.Point(9, 33);
            this.txtUsuarioFTP.Name = "txtUsuarioFTP";
            this.txtUsuarioFTP.Size = new System.Drawing.Size(170, 21);
            this.txtUsuarioFTP.TabIndex = 7;
            // 
            // btnCopiarExemplo
            // 
            this.btnCopiarExemplo.Image = global::SGS.Properties.Resources.Copiar24x24;
            this.btnCopiarExemplo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopiarExemplo.Location = new System.Drawing.Point(15, 208);
            this.btnCopiarExemplo.Name = "btnCopiarExemplo";
            this.btnCopiarExemplo.Size = new System.Drawing.Size(103, 44);
            this.btnCopiarExemplo.TabIndex = 9;
            this.btnCopiarExemplo.Text = "Copiar Exemplo";
            this.btnCopiarExemplo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopiarExemplo.UseVisualStyleBackColor = true;
            this.btnCopiarExemplo.Click += new System.EventHandler(this.btnCopiarExemplo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(219, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(300, 208);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // v_FtpConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.btnCopiarExemplo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDiretorioSalvarSetup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiretorioSetupUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiretorioVersaoUpdate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_FtpConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações servidor FTP";
            this.Load += new System.EventHandler(this.v_FtpConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretorioVersaoUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiretorioSetupUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiretorioSalvarSetup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuarioFTP;
        private System.Windows.Forms.TextBox txtSenhaFTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCopiarExemplo;
    }
}