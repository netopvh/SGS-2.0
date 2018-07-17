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
            this.gdvCorretores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCPF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTelefone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPageNovoCorretor = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxNovoCorretor = new DevExpress.XtraEditors.GroupControl();
            this.txtTelefone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCPF = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.corretorTableAdapter = new SGS.dbsgsDataSetTableAdapters.corretorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).BeginInit();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCorretores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corretorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbsgsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCorretores)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoCorretor)).BeginInit();
            this.gbxNovoCorretor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl
            // 
            this.tabFormControl.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl.Name = "tabFormControl";
            this.tabFormControl.Pages.Add(this.tabFormPageCorretores);
            this.tabFormControl.Pages.Add(this.tabFormPageNovoCorretor);
            this.tabFormControl.SelectedPage = this.tabFormPageCorretores;
            this.tabFormControl.ShowAddPageButton = false;
            this.tabFormControl.ShowTabCloseButtons = false;
            this.tabFormControl.Size = new System.Drawing.Size(496, 55);
            this.tabFormControl.TabForm = this;
            this.tabFormControl.TabIndex = 0;
            this.tabFormControl.TabStop = false;
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
            this.tabFormContentContainer1.Size = new System.Drawing.Size(496, 274);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(175, 248);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(256, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(337, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(418, 248);
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
            this.gbxCorretores.Size = new System.Drawing.Size(496, 242);
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
            this.gcCorretores.Size = new System.Drawing.Size(492, 219);
            this.gcCorretores.TabIndex = 0;
            this.gcCorretores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCorretores});
            // 
            // corretorBindingSource
            // 
            this.corretorBindingSource.DataMember = "corretor";
            this.corretorBindingSource.DataSource = this.dbsgsDataSet;
            // 
            // dbsgsDataSet
            // 
            this.dbsgsDataSet.DataSetName = "dbsgsDataSet";
            this.dbsgsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gdvCorretores
            // 
            this.gdvCorretores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodigo,
            this.gridColumnNome,
            this.gridColumnCPF,
            this.gridColumnTelefone,
            this.gridColumnEmail});
            this.gdvCorretores.GridControl = this.gcCorretores;
            this.gdvCorretores.Name = "gdvCorretores";
            this.gdvCorretores.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gdvCorretores.OptionsPrint.PrintFilterInfo = true;
            this.gdvCorretores.OptionsPrint.PrintFooter = false;
            this.gdvCorretores.OptionsPrint.PrintGroupFooter = false;
            this.gdvCorretores.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCodigo
            // 
            this.gridColumnCodigo.Caption = "Código";
            this.gridColumnCodigo.FieldName = "idcorretor";
            this.gridColumnCodigo.Name = "gridColumnCodigo";
            this.gridColumnCodigo.Visible = true;
            this.gridColumnCodigo.VisibleIndex = 0;
            // 
            // gridColumnNome
            // 
            this.gridColumnNome.Caption = "Nome";
            this.gridColumnNome.FieldName = "nome";
            this.gridColumnNome.Name = "gridColumnNome";
            this.gridColumnNome.Visible = true;
            this.gridColumnNome.VisibleIndex = 1;
            // 
            // gridColumnCPF
            // 
            this.gridColumnCPF.Caption = "CPF";
            this.gridColumnCPF.FieldName = "cpf";
            this.gridColumnCPF.Name = "gridColumnCPF";
            this.gridColumnCPF.Visible = true;
            this.gridColumnCPF.VisibleIndex = 2;
            // 
            // gridColumnTelefone
            // 
            this.gridColumnTelefone.Caption = "Telefone";
            this.gridColumnTelefone.FieldName = "telefone";
            this.gridColumnTelefone.Name = "gridColumnTelefone";
            this.gridColumnTelefone.Visible = true;
            this.gridColumnTelefone.VisibleIndex = 3;
            // 
            // gridColumnEmail
            // 
            this.gridColumnEmail.Caption = "E-mail";
            this.gridColumnEmail.FieldName = "email";
            this.gridColumnEmail.Name = "gridColumnEmail";
            this.gridColumnEmail.Visible = true;
            this.gridColumnEmail.VisibleIndex = 4;
            // 
            // tabFormPageNovoCorretor
            // 
            this.tabFormPageNovoCorretor.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPageNovoCorretor.Name = "tabFormPageNovoCorretor";
            this.tabFormPageNovoCorretor.Text = "Novo Corretor";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.btnSalvar);
            this.tabFormContentContainer2.Controls.Add(this.gbxNovoCorretor);
            this.tabFormContentContainer2.Controls.Add(this.btnCancelar);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(496, 274);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(337, 248);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbxNovoCorretor
            // 
            this.gbxNovoCorretor.Controls.Add(this.txtTelefone);
            this.gbxNovoCorretor.Controls.Add(this.labelControl4);
            this.gbxNovoCorretor.Controls.Add(this.txtEmail);
            this.gbxNovoCorretor.Controls.Add(this.labelControl3);
            this.gbxNovoCorretor.Controls.Add(this.txtCPF);
            this.gbxNovoCorretor.Controls.Add(this.labelControl2);
            this.gbxNovoCorretor.Controls.Add(this.txtNome);
            this.gbxNovoCorretor.Controls.Add(this.labelControl1);
            this.gbxNovoCorretor.Location = new System.Drawing.Point(0, 0);
            this.gbxNovoCorretor.Name = "gbxNovoCorretor";
            this.gbxNovoCorretor.Size = new System.Drawing.Size(496, 242);
            this.gbxNovoCorretor.TabIndex = 1;
            this.gbxNovoCorretor.Text = "Dados";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(5, 177);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Properties.Mask.EditMask = "(\\d?\\d?) \\d\\d\\d\\d\\d-\\d\\d\\d\\d";
            this.txtTelefone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefone.Size = new System.Drawing.Size(167, 20);
            this.txtTelefone.TabIndex = 7;
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
            this.txtEmail.TabIndex = 5;
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
            this.txtCPF.TabIndex = 3;
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // corretorTableAdapter
            // 
            this.corretorTableAdapter.ClearBeforeFill = true;
            // 
            // v_Corretor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 329);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.MaximizeBox = false;
            this.Name = "v_Corretor";
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
            ((System.ComponentModel.ISupportInitialize)(this.gdvCorretores)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoCorretor)).EndInit();
            this.gbxNovoCorretor.ResumeLayout(false);
            this.gbxNovoCorretor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCorretores;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNome;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCPF;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTelefone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
    }
}