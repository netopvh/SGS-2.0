namespace SGS.Visao
{
    partial class v_NovaDistribuicaoFolhaAvulso
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
            this.splashScreenManagerP = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SGS.Visao.WaitForm1), true, true);
            this.components = new System.ComponentModel.Container();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gbxDistribuir = new DevExpress.XtraEditors.GroupControl();
            this.gbxFolhaValor = new DevExpress.XtraEditors.GroupControl();
            this.rbtPGAprazo = new System.Windows.Forms.RadioButton();
            this.txtValorFolha = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtPGAvista = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFolha = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpDataDistribuicao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEmpreendimento = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCorretor = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNotificarCorretorEmail = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbxDistribuir)).BeginInit();
            this.gbxDistribuir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFolhaValor)).BeginInit();
            this.gbxFolhaValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFolha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFolha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpreendimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCorretor.Properties)).BeginInit();
            this.SuspendLayout();
            // splashScreenManagerP
            // 
            this.splashScreenManagerP.ClosingDelay = 500;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // gbxDistribuir
            // 
            this.gbxDistribuir.Controls.Add(this.gbxFolhaValor);
            this.gbxDistribuir.Controls.Add(this.dtpDataDistribuicao);
            this.gbxDistribuir.Controls.Add(this.label4);
            this.gbxDistribuir.Controls.Add(this.cbxEmpreendimento);
            this.gbxDistribuir.Controls.Add(this.label2);
            this.gbxDistribuir.Controls.Add(this.cbxCorretor);
            this.gbxDistribuir.Controls.Add(this.label1);
            this.gbxDistribuir.Location = new System.Drawing.Point(12, 12);
            this.gbxDistribuir.Name = "gbxDistribuir";
            this.gbxDistribuir.Size = new System.Drawing.Size(439, 252);
            this.gbxDistribuir.TabIndex = 0;
            this.gbxDistribuir.Text = "Distribuir para:";
            // 
            // gbxFolhaValor
            // 
            this.gbxFolhaValor.Controls.Add(this.rbtPGAprazo);
            this.gbxFolhaValor.Controls.Add(this.txtValorFolha);
            this.gbxFolhaValor.Controls.Add(this.label5);
            this.gbxFolhaValor.Controls.Add(this.rbtPGAvista);
            this.gbxFolhaValor.Controls.Add(this.label3);
            this.gbxFolhaValor.Controls.Add(this.cbxFolha);
            this.gbxFolhaValor.Location = new System.Drawing.Point(5, 124);
            this.gbxFolhaValor.Name = "gbxFolhaValor";
            this.gbxFolhaValor.Size = new System.Drawing.Size(429, 119);
            this.gbxFolhaValor.TabIndex = 8;
            this.gbxFolhaValor.Text = "Folha/Valor";
            // 
            // rbtPGAprazo
            // 
            this.rbtPGAprazo.AutoSize = true;
            this.rbtPGAprazo.Location = new System.Drawing.Point(229, 77);
            this.rbtPGAprazo.Name = "rbtPGAprazo";
            this.rbtPGAprazo.Size = new System.Drawing.Size(62, 17);
            this.rbtPGAprazo.TabIndex = 7;
            this.rbtPGAprazo.TabStop = true;
            this.rbtPGAprazo.Text = "Á Prazo";
            this.rbtPGAprazo.UseVisualStyleBackColor = true;
            // 
            // txtValorFolha
            // 
            this.txtValorFolha.EditValue = "0,00";
            this.txtValorFolha.Location = new System.Drawing.Point(8, 76);
            this.txtValorFolha.Name = "txtValorFolha";
            this.txtValorFolha.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFolha.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtValorFolha.Properties.Appearance.Options.UseFont = true;
            this.txtValorFolha.Properties.Appearance.Options.UseForeColor = true;
            this.txtValorFolha.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValorFolha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtValorFolha.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtValorFolha.Properties.DisplayFormat.FormatString = "c";
            this.txtValorFolha.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtValorFolha.Properties.Mask.EditMask = "c";
            this.txtValorFolha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorFolha.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtValorFolha.Size = new System.Drawing.Size(141, 20);
            this.txtValorFolha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor:";
            // 
            // rbtPGAvista
            // 
            this.rbtPGAvista.AutoSize = true;
            this.rbtPGAvista.Location = new System.Drawing.Point(165, 77);
            this.rbtPGAvista.Name = "rbtPGAvista";
            this.rbtPGAvista.Size = new System.Drawing.Size(58, 17);
            this.rbtPGAvista.TabIndex = 6;
            this.rbtPGAvista.TabStop = true;
            this.rbtPGAvista.Text = "Á Vista";
            this.rbtPGAvista.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Folha:";
            // 
            // cbxFolha
            // 
            this.cbxFolha.Location = new System.Drawing.Point(8, 37);
            this.cbxFolha.Name = "cbxFolha";
            this.cbxFolha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFolha.Properties.Items.AddRange(new object[] {
            "PÁGINA NÚMERO - 01 - MODELO ESGOTO",
            "PÁGINA NÚMERO - 02 - MODELO ESGOTO",
            "PÁGINA NÚMERO - 01 - CARBONADAS",
            "PÁGINA NÚMERO - 02 - CARBONADAS",
            "PÁGINA NÚMERO - 03 - CARBONADAS",
            "PÁGINA NÚMERO - 04",
            "PÁGINA NÚMERO - 05",
            "PÁGINA NÚMERO - 06",
            "PÁGINA NÚMERO - 07",
            "PÁGINA NÚMERO - 08",
            "PÁGINA NÚMERO - 09",
            "PÁGINA NÚMERO - 10",
            "PÁGINA NÚMERO - 11",
            "PÁGINA NÚMERO - 12",
            "PÁGINA NÚMERO - 13",
            "PÁGINA NÚMERO - 14",
            "PÁGINA NÚMERO - 15",
            "PÁGINA NÚMERO - 16",
            "PÁGINA NÚMERO - 17",
            "PÁGINA NÚMERO - 18",
            "PÁGINA NÚMERO - 19"});
            this.cbxFolha.Properties.PopupSizeable = true;
            this.cbxFolha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxFolha.Size = new System.Drawing.Size(416, 20);
            this.cbxFolha.TabIndex = 4;
            // 
            // dtpDataDistribuicao
            // 
            this.dtpDataDistribuicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDistribuicao.Location = new System.Drawing.Point(100, 102);
            this.dtpDataDistribuicao.Name = "dtpDataDistribuicao";
            this.dtpDataDistribuicao.Size = new System.Drawing.Size(98, 21);
            this.dtpDataDistribuicao.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Distribuição:";
            // 
            // cbxEmpreendimento
            // 
            this.cbxEmpreendimento.Location = new System.Drawing.Point(5, 76);
            this.cbxEmpreendimento.Name = "cbxEmpreendimento";
            this.cbxEmpreendimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpreendimento.Properties.NullText = "";
            this.cbxEmpreendimento.Size = new System.Drawing.Size(429, 20);
            this.cbxEmpreendimento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empreendimento:";
            // 
            // cbxCorretor
            // 
            this.cbxCorretor.Location = new System.Drawing.Point(5, 37);
            this.cbxCorretor.Name = "cbxCorretor";
            this.cbxCorretor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxCorretor.Properties.NullText = "";
            this.cbxCorretor.Size = new System.Drawing.Size(429, 20);
            this.cbxCorretor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corretor:";
            // 
            // cbxNotificarCorretorEmail
            // 
            this.cbxNotificarCorretorEmail.AutoSize = true;
            this.cbxNotificarCorretorEmail.Checked = true;
            this.cbxNotificarCorretorEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNotificarCorretorEmail.Location = new System.Drawing.Point(12, 270);
            this.cbxNotificarCorretorEmail.Name = "cbxNotificarCorretorEmail";
            this.cbxNotificarCorretorEmail.Size = new System.Drawing.Size(207, 17);
            this.cbxNotificarCorretorEmail.TabIndex = 0;
            this.cbxNotificarCorretorEmail.TabStop = false;
            this.cbxNotificarCorretorEmail.Text = "Notificar Corretor sobre a Distribuição";
            this.cbxNotificarCorretorEmail.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(376, 270);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(295, 270);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // v_NovaDistribuicaoFolhaAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 320);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbxNotificarCorretorEmail);
            this.Controls.Add(this.gbxDistribuir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_NovaDistribuicaoFolhaAvulso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Distribuição";
            this.Load += new System.EventHandler(this.v_NovaDistribuicaoFolhaAvulso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxDistribuir)).EndInit();
            this.gbxDistribuir.ResumeLayout(false);
            this.gbxDistribuir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxFolhaValor)).EndInit();
            this.gbxFolhaValor.ResumeLayout(false);
            this.gbxFolhaValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorFolha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFolha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpreendimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCorretor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl gbxDistribuir;
        private DevExpress.XtraEditors.LookUpEdit cbxEmpreendimento;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit cbxCorretor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataDistribuicao;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl gbxFolhaValor;
        private System.Windows.Forms.CheckBox cbxNotificarCorretorEmail;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.RadioButton rbtPGAprazo;
        private DevExpress.XtraEditors.TextEdit txtValorFolha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtPGAvista;
        private DevExpress.XtraEditors.ComboBoxEdit cbxFolha;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerP;
    }
}