namespace SGS.Visao
{
    partial class v_Login
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
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.gbxEmpresaLicenca = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLicenca = new DevExpress.XtraEditors.LabelControl();
            this.gbxDadosAcesso = new DevExpress.XtraEditors.GroupControl();
            this.cbxLembrarAcesso = new DevExpress.XtraEditors.CheckEdit();
            this.cbxMostrarSenha = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSair = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEmpresaLicenca)).BeginInit();
            this.gbxEmpresaLicenca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxDadosAcesso)).BeginInit();
            this.gbxDadosAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLembrarAcesso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMostrarSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AllowMoveTabs = false;
            this.tabFormControl1.AllowMoveTabsToOuterForm = false;
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(297, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.Click += new System.EventHandler(this.tabFormControl1_Click);
            // 
            // gbxEmpresaLicenca
            // 
            this.gbxEmpresaLicenca.Controls.Add(this.pictureBox1);
            this.gbxEmpresaLicenca.Controls.Add(this.lblLicenca);
            this.gbxEmpresaLicenca.Location = new System.Drawing.Point(12, 61);
            this.gbxEmpresaLicenca.Name = "gbxEmpresaLicenca";
            this.gbxEmpresaLicenca.Size = new System.Drawing.Size(273, 147);
            this.gbxEmpresaLicenca.TabIndex = 1;
            this.gbxEmpresaLicenca.Text = "Empresa/Licença";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLicenca
            // 
            this.lblLicenca.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenca.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLicenca.Appearance.Options.UseFont = true;
            this.lblLicenca.Appearance.Options.UseForeColor = true;
            this.lblLicenca.Location = new System.Drawing.Point(5, 128);
            this.lblLicenca.Name = "lblLicenca";
            this.lblLicenca.Size = new System.Drawing.Size(32, 11);
            this.lblLicenca.TabIndex = 1;
            this.lblLicenca.Text = "Licença:";
            // 
            // gbxDadosAcesso
            // 
            this.gbxDadosAcesso.Controls.Add(this.cbxLembrarAcesso);
            this.gbxDadosAcesso.Controls.Add(this.cbxMostrarSenha);
            this.gbxDadosAcesso.Controls.Add(this.labelControl3);
            this.gbxDadosAcesso.Controls.Add(this.txtSenha);
            this.gbxDadosAcesso.Controls.Add(this.txtUsuario);
            this.gbxDadosAcesso.Controls.Add(this.labelControl2);
            this.gbxDadosAcesso.Location = new System.Drawing.Point(12, 214);
            this.gbxDadosAcesso.Name = "gbxDadosAcesso";
            this.gbxDadosAcesso.Size = new System.Drawing.Size(273, 141);
            this.gbxDadosAcesso.TabIndex = 2;
            this.gbxDadosAcesso.Text = "Dados de Acesso";
            // 
            // cbxLembrarAcesso
            // 
            this.cbxLembrarAcesso.Location = new System.Drawing.Point(22, 114);
            this.cbxLembrarAcesso.Name = "cbxLembrarAcesso";
            this.cbxLembrarAcesso.Properties.Caption = "Lembrar Usuário";
            this.cbxLembrarAcesso.Properties.PictureChecked = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxLembrarAcesso.Properties.PictureGrayed = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxLembrarAcesso.Properties.PictureUnchecked = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxLembrarAcesso.Size = new System.Drawing.Size(104, 19);
            this.cbxLembrarAcesso.TabIndex = 5;
            this.cbxLembrarAcesso.CheckedChanged += new System.EventHandler(this.cbxLembrarAcesso_CheckedChanged);
            // 
            // cbxMostrarSenha
            // 
            this.cbxMostrarSenha.Location = new System.Drawing.Point(160, 114);
            this.cbxMostrarSenha.Name = "cbxMostrarSenha";
            this.cbxMostrarSenha.Properties.Caption = "Mostrar Senha";
            this.cbxMostrarSenha.Properties.PictureChecked = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxMostrarSenha.Properties.PictureGrayed = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxMostrarSenha.Properties.PictureUnchecked = global::SGS.Properties.Resources.MostrarSenha24x24;
            this.cbxMostrarSenha.Size = new System.Drawing.Size(91, 19);
            this.cbxMostrarSenha.TabIndex = 4;
            this.cbxMostrarSenha.CheckedChanged += new System.EventHandler(this.cbxMostrarSenha_CheckedChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(22, 88);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(229, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(22, 43);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Size = new System.Drawing.Size(229, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Usuário:";
            // 
            // btnSair
            // 
            this.btnSair.ImageOptions.Image = global::SGS.Properties.Resources.Sair_22x22;
            this.btnSair.Location = new System.Drawing.Point(210, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = global::SGS.Properties.Resources.LoginSenha24x24;
            this.btnLogin.Location = new System.Drawing.Point(129, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(9, 358);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(99, 13);
            this.lblEsqueceuSenha.TabIndex = 0;
            this.lblEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lblEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEsqueceuSenha_LinkClicked);
            // 
            // v_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 395);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbxDadosAcesso);
            this.Controls.Add(this.gbxEmpresaLicenca);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "v_Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.v_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEmpresaLicenca)).EndInit();
            this.gbxEmpresaLicenca.ResumeLayout(false);
            this.gbxEmpresaLicenca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxDadosAcesso)).EndInit();
            this.gbxDadosAcesso.ResumeLayout(false);
            this.gbxDadosAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLembrarAcesso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMostrarSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnSair;
        private DevExpress.XtraEditors.GroupControl gbxDadosAcesso;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl gbxEmpresaLicenca;
        private DevExpress.XtraEditors.LabelControl lblLicenca;
        private DevExpress.XtraEditors.CheckEdit cbxMostrarSenha;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.CheckEdit cbxLembrarAcesso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblEsqueceuSenha;
    }
}