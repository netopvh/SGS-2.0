namespace SGS.Visao
{
    partial class v_Corretor
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
            this.tabFormControl = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPageCorretores = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxCorretores = new DevExpress.XtraEditors.GroupControl();
            this.gcCorretores = new DevExpress.XtraGrid.GridControl();
            this.corretorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbsgsDataSet = new SGS.dbsgsDataSet();
            this.tabFormPageNovoCorretor = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gbxNovoCorretor = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxStatus = new DevExpress.XtraEditors.GroupControl();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.corretorTableAdapter = new SGS.dbsgsDataSetTableAdapters.corretorTableAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gdvCorretores = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnNome = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnCPF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnTelefone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnEmail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).BeginInit();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCorretores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsgsDataSet)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoCorretor)).BeginInit();
            this.gbxNovoCorretor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxStatus)).BeginInit();
            this.gbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCorretores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl
            // 
            this.tabFormControl.AllowMoveTabs = false;
            this.tabFormControl.AllowMoveTabsToOuterForm = false;
            this.tabFormControl.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl.Name = "tabFormControl";
            this.tabFormControl.Pages.Add(this.tabFormPageCorretores);
            this.tabFormControl.Pages.Add(this.tabFormPageNovoCorretor);
            this.tabFormControl.SelectedPage = this.tabFormPageCorretores;
            this.tabFormControl.ShowAddPageButton = false;
            this.tabFormControl.ShowTabCloseButtons = false;
            this.tabFormControl.Size = new System.Drawing.Size(598, 55);
            this.tabFormControl.TabForm = this;
            this.tabFormControl.TabIndex = 0;
            this.tabFormControl.TabStop = false;
            this.tabFormControl.Click += new System.EventHandler(this.tabFormControl_Click);
            // 
            // tabFormPageCorretores
            // 
            this.tabFormPageCorretores.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPageCorretores.Name = "tabFormPageCorretores";
            this.tabFormPageCorretores.Text = "Corretores";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.gbxCorretores);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(598, 274);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(277, 248);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(358, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(439, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(520, 248);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbxCorretores
            // 
            this.gbxCorretores.Controls.Add(this.gcCorretores);
            this.gbxCorretores.Location = new System.Drawing.Point(0, 0);
            this.gbxCorretores.Name = "gbxCorretores";
            this.gbxCorretores.Size = new System.Drawing.Size(598, 242);
            this.gbxCorretores.TabIndex = 0;
            this.gbxCorretores.Text = "Todos";
            // 
            // gcCorretores
            // 
            this.gcCorretores.DataSource = this.corretorBindingSource;
            this.gcCorretores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCorretores.Location = new System.Drawing.Point(2, 21);
            this.gcCorretores.MainView = this.gdvCorretores;
            this.gcCorretores.Name = "gcCorretores";
            this.gcCorretores.Size = new System.Drawing.Size(594, 219);
            this.gcCorretores.TabIndex = 0;
            this.gcCorretores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCorretores});
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataMember = "corretor";
            this.corretorBindingSource.DataSource = this.dbsgsDataSet;
            this.corretorBindingSource.CurrentChanged += new System.EventHandler(this.corretorBindingSource_CurrentChanged);
            // 
            // dbsgsDataSet
            // 
            this.dbsgsDataSet.DataSetName = "dbsgsDataSet";
            this.dbsgsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabFormPageNovoCorretor
            // 
            this.tabFormPageNovoCorretor.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPageNovoCorretor.Name = "tabFormPageNovoCorretor";
            this.tabFormPageNovoCorretor.Text = "Novo Corretor";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.gbxNovoCorretor);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(598, 274);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // gbxNovoCorretor
            // 
            this.gbxNovoCorretor.Controls.Add(this.btnSalvar);
            this.gbxNovoCorretor.Controls.Add(this.gbxStatus);
            this.gbxNovoCorretor.Controls.Add(this.txtTelefone);
            this.gbxNovoCorretor.Controls.Add(this.btnCancelar);
            this.gbxNovoCorretor.Controls.Add(this.labelControl4);
            this.gbxNovoCorretor.Controls.Add(this.txtEmail);
            this.gbxNovoCorretor.Controls.Add(this.labelControl3);
            this.gbxNovoCorretor.Controls.Add(this.txtCPF);
            this.gbxNovoCorretor.Controls.Add(this.labelControl2);
            this.gbxNovoCorretor.Controls.Add(this.txtNome);
            this.gbxNovoCorretor.Controls.Add(this.labelControl1);
            this.gbxNovoCorretor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNovoCorretor.Location = new System.Drawing.Point(0, 0);
            this.gbxNovoCorretor.Name = "gbxNovoCorretor";
            this.gbxNovoCorretor.Size = new System.Drawing.Size(598, 274);
            this.gbxNovoCorretor.TabIndex = 1;
            this.gbxNovoCorretor.Text = "Dados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(437, 246);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.rbtInativo);
            this.gbxStatus.Controls.Add(this.rbtAtivo);
            this.gbxStatus.Location = new System.Drawing.Point(178, 71);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(217, 126);
            this.gbxStatus.TabIndex = 8;
            this.gbxStatus.Text = "Status";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(5, 64);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(59, 17);
            this.rbtInativo.TabIndex = 1;
            this.rbtInativo.TabStop = true;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Location = new System.Drawing.Point(5, 24);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(50, 17);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(5, 177);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefone.Size = new System.Drawing.Size(167, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(518, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(5, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Size = new System.Drawing.Size(167, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "E-mail:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(5, 88);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?-\\d?\\d?";
            this.txtCPF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtCPF.Size = new System.Drawing.Size(167, 20);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.EditValueChanged += new System.EventHandler(this.txtCPF_EditValueChanged);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.txtNome.Properties.Mask.PlaceHolder = ' ';
            this.txtNome.Size = new System.Drawing.Size(390, 20);
            this.txtNome.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome:";
            // 
            // corretorTableAdapter
            // 
            this.corretorTableAdapter.ClearBeforeFill = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // gdvCorretores
            // 
            this.gdvCorretores.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gdvCorretores.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumnCodigo,
            this.gridColumnNome,
            this.gridColumnCPF,
            this.gridColumnTelefone,
            this.gridColumnEmail,
            this.gridColumnStatus,
            this.gridColumnUsuarioCad});
            this.gdvCorretores.GridControl = this.gcCorretores;
            this.gdvCorretores.Name = "gdvCorretores";
            this.gdvCorretores.OptionsBehavior.Editable = false;
            this.gdvCorretores.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            // 
            // gridColumnCodigo
            // 
            this.gridColumnCodigo.Caption = "Código";
            this.gridColumnCodigo.FieldName = "idcorretor";
            this.gridColumnCodigo.Name = "gridColumnCodigo";
            this.gridColumnCodigo.Visible = true;
            this.gridColumnCodigo.Width = 72;
            // 
            // gridColumnNome
            // 
            this.gridColumnNome.Caption = "Nome";
            this.gridColumnNome.FieldName = "nome";
            this.gridColumnNome.Name = "gridColumnNome";
            this.gridColumnNome.Visible = true;
            this.gridColumnNome.Width = 238;
            // 
            // gridColumnCPF
            // 
            this.gridColumnCPF.Caption = "CPF";
            this.gridColumnCPF.FieldName = "cpf";
            this.gridColumnCPF.Name = "gridColumnCPF";
            this.gridColumnCPF.Visible = true;
            this.gridColumnCPF.Width = 106;
            // 
            // gridColumnTelefone
            // 
            this.gridColumnTelefone.Caption = "Telefone";
            this.gridColumnTelefone.FieldName = "telefone";
            this.gridColumnTelefone.Name = "gridColumnTelefone";
            this.gridColumnTelefone.Visible = true;
            this.gridColumnTelefone.Width = 100;
            // 
            // gridColumnEmail
            // 
            this.gridColumnEmail.Caption = "E-mail";
            this.gridColumnEmail.FieldName = "email";
            this.gridColumnEmail.Name = "gridColumnEmail";
            this.gridColumnEmail.Visible = true;
            this.gridColumnEmail.Width = 215;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.Width = 53;
            // 
            // gridColumnUsuarioCad
            // 
            this.gridColumnUsuarioCad.Caption = "Usuário Cad.";
            this.gridColumnUsuarioCad.FieldName = "usuariocad";
            this.gridColumnUsuarioCad.Name = "gridColumnUsuarioCad";
            this.gridColumnUsuarioCad.Visible = true;
            this.gridColumnUsuarioCad.Width = 82;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Todos os corretores estão no Grid.";
            this.gridBand1.Columns.Add(this.gridColumnCodigo);
            this.gridBand1.Columns.Add(this.gridColumnNome);
            this.gridBand1.Columns.Add(this.gridColumnCPF);
            this.gridBand1.Columns.Add(this.gridColumnTelefone);
            this.gridBand1.Columns.Add(this.gridColumnEmail);
            this.gridBand1.Columns.Add(this.gridColumnStatus);
            this.gridBand1.Columns.Add(this.gridColumnUsuarioCad);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 866;
            // 
            // v_Corretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 329);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "v_Corretor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl;
            this.Text = "Corretor";
            this.Load += new System.EventHandler(this.v_Corretor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).EndInit();
            this.gbxCorretores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCorretores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsgsDataSet)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoCorretor)).EndInit();
            this.gbxNovoCorretor.ResumeLayout(false);
            this.gbxNovoCorretor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxStatus)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCorretores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.TabFormPage tabFormPageCorretores;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabFormPageNovoCorretor;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.GroupControl gbxCorretores;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.GroupControl gbxNovoCorretor;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtTelefone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCPF;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private dbsgsDataSet dbsgsDataSet;
        private System.Windows.Forms.BindingSource corretorBindingSource;
        private dbsgsDataSetTableAdapters.corretorTableAdapter corretorTableAdapter;
        private DevExpress.XtraGrid.GridControl gcCorretores;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl gbxStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private DevExpress.XtraBars.TabFormControl tabFormControl;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gdvCorretores;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnNome;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnCPF;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnTelefone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnUsuarioCad;
    }
}