namespace SGS.Visao
{
    partial class v_Usuario
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
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPageUsuarios = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxUsuarios = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gdvUsuarios = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumnIdusuario = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnNome = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnLogin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnSenha = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnPermissao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tabFormPageNovoUsuario = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gbxNovoUsuario = new DevExpress.XtraEditors.GroupControl();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditPermissao = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblSenhasConfirmacao = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirmaSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxUsuarios)).BeginInit();
            this.gbxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoUsuario)).BeginInit();
            this.gbxNovoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPermissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmaSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.AllowMoveTabs = false;
            this.tabFormControl1.AllowMoveTabsToOuterForm = false;
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPageUsuarios);
            this.tabFormControl1.Pages.Add(this.tabFormPageNovoUsuario);
            this.tabFormControl1.SelectedPage = this.tabFormPageUsuarios;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(510, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPageUsuarios
            // 
            this.tabFormPageUsuarios.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPageUsuarios.Name = "tabFormPageUsuarios";
            this.tabFormPageUsuarios.Text = "Usuários";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.AutoScroll = false;
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.gbxUsuarios);
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(510, 273);
            this.tabFormContentContainer1.TabIndex = 1;
            this.tabFormContentContainer1.Click += new System.EventHandler(this.tabFormContentContainer1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(188, 223);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(269, 223);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(349, 223);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(430, 223);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbxUsuarios
            // 
            this.gbxUsuarios.Controls.Add(this.gridControl1);
            this.gbxUsuarios.Location = new System.Drawing.Point(0, 7);
            this.gbxUsuarios.Name = "gbxUsuarios";
            this.gbxUsuarios.Size = new System.Drawing.Size(508, 210);
            this.gbxUsuarios.TabIndex = 0;
            this.gbxUsuarios.Text = "Todos";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gdvUsuarios;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 187);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuarios});
            // 
            // gdvUsuarios
            // 
            this.gdvUsuarios.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.gdvUsuarios.Appearance.EvenRow.Options.UseBackColor = true;
            this.gdvUsuarios.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.gdvUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumnIdusuario,
            this.gridColumnNome,
            this.gridColumnLogin,
            this.gridColumnSenha,
            this.gridColumnStatus,
            this.gridColumnPermissao});
            this.gdvUsuarios.GridControl = this.gridControl1;
            this.gdvUsuarios.Name = "gdvUsuarios";
            this.gdvUsuarios.OptionsBehavior.Editable = false;
            this.gdvUsuarios.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gdvUsuarios.OptionsPrint.PrintBandHeader = false;
            this.gdvUsuarios.OptionsPrint.PrintDetails = true;
            this.gdvUsuarios.OptionsPrint.PrintFilterInfo = true;
            this.gdvUsuarios.OptionsPrint.PrintGroupFooter = false;
            this.gdvUsuarios.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gdvUsuarios.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gdvUsuarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gdvUsuarios.OptionsView.ShowFooter = true;
            this.gdvUsuarios.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Todos os Usuários estão no Grid.";
            this.gridBand1.Columns.Add(this.gridColumnIdusuario);
            this.gridBand1.Columns.Add(this.gridColumnNome);
            this.gridBand1.Columns.Add(this.gridColumnLogin);
            this.gridBand1.Columns.Add(this.gridColumnSenha);
            this.gridBand1.Columns.Add(this.gridColumnStatus);
            this.gridBand1.Columns.Add(this.gridColumnPermissao);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 757;
            // 
            // gridColumnIdusuario
            // 
            this.gridColumnIdusuario.Caption = "Código";
            this.gridColumnIdusuario.FieldName = "idusuario";
            this.gridColumnIdusuario.Name = "gridColumnIdusuario";
            this.gridColumnIdusuario.Visible = true;
            this.gridColumnIdusuario.Width = 57;
            // 
            // gridColumnNome
            // 
            this.gridColumnNome.Caption = "Nome";
            this.gridColumnNome.FieldName = "nome";
            this.gridColumnNome.Name = "gridColumnNome";
            this.gridColumnNome.Visible = true;
            this.gridColumnNome.Width = 204;
            // 
            // gridColumnLogin
            // 
            this.gridColumnLogin.Caption = "Login";
            this.gridColumnLogin.FieldName = "login";
            this.gridColumnLogin.Name = "gridColumnLogin";
            this.gridColumnLogin.Visible = true;
            this.gridColumnLogin.Width = 85;
            // 
            // gridColumnSenha
            // 
            this.gridColumnSenha.Caption = "Senha";
            this.gridColumnSenha.FieldName = "senha";
            this.gridColumnSenha.Name = "gridColumnSenha";
            this.gridColumnSenha.Visible = true;
            this.gridColumnSenha.Width = 216;
            // 
            // gridColumnStatus
            // 
            this.gridColumnStatus.Caption = "Status";
            this.gridColumnStatus.FieldName = "status";
            this.gridColumnStatus.Name = "gridColumnStatus";
            this.gridColumnStatus.Visible = true;
            this.gridColumnStatus.Width = 77;
            // 
            // gridColumnPermissao
            // 
            this.gridColumnPermissao.Caption = "Permissão Nvl.";
            this.gridColumnPermissao.FieldName = "nivel";
            this.gridColumnPermissao.Name = "gridColumnPermissao";
            this.gridColumnPermissao.Visible = true;
            this.gridColumnPermissao.Width = 118;
            // 
            // tabFormPageNovoUsuario
            // 
            this.tabFormPageNovoUsuario.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPageNovoUsuario.Name = "tabFormPageNovoUsuario";
            this.tabFormPageNovoUsuario.Text = "Novo Usuário";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.gbxNovoUsuario);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(510, 273);
            this.tabFormContentContainer2.TabIndex = 2;
            // 
            // gbxNovoUsuario
            // 
            this.gbxNovoUsuario.Controls.Add(this.btnSalvar);
            this.gbxNovoUsuario.Controls.Add(this.groupControl2);
            this.gbxNovoUsuario.Controls.Add(this.btnCancelar);
            this.gbxNovoUsuario.Controls.Add(this.groupControl1);
            this.gbxNovoUsuario.Controls.Add(this.txtLogin);
            this.gbxNovoUsuario.Controls.Add(this.labelControl2);
            this.gbxNovoUsuario.Controls.Add(this.txtNome);
            this.gbxNovoUsuario.Controls.Add(this.labelControl1);
            this.gbxNovoUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxNovoUsuario.Location = new System.Drawing.Point(0, 0);
            this.gbxNovoUsuario.Name = "gbxNovoUsuario";
            this.gbxNovoUsuario.Size = new System.Drawing.Size(510, 273);
            this.gbxNovoUsuario.TabIndex = 0;
            this.gbxNovoUsuario.Text = "Dados";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(342, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lookUpEditPermissao);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.lblSenhasConfirmacao);
            this.groupControl2.Controls.Add(this.txtConfirmaSenha);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtSenha);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(223, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(275, 190);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Senha/Permissão";
            // 
            // lookUpEditPermissao
            // 
            this.lookUpEditPermissao.Location = new System.Drawing.Point(5, 149);
            this.lookUpEditPermissao.Name = "lookUpEditPermissao";
            this.lookUpEditPermissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPermissao.Properties.DisplayMember = "nome";
            this.lookUpEditPermissao.Properties.DropDownRows = 5;
            this.lookUpEditPermissao.Properties.NullText = "";
            this.lookUpEditPermissao.Properties.ValueMember = "idpermissao";
            this.lookUpEditPermissao.Size = new System.Drawing.Size(265, 20);
            this.lookUpEditPermissao.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Permissão:";
            // 
            // lblSenhasConfirmacao
            // 
            this.lblSenhasConfirmacao.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSenhasConfirmacao.Appearance.Options.UseForeColor = true;
            this.lblSenhasConfirmacao.Location = new System.Drawing.Point(80, 113);
            this.lblSenhasConfirmacao.Name = "lblSenhasConfirmacao";
            this.lblSenhasConfirmacao.Size = new System.Drawing.Size(122, 13);
            this.lblSenhasConfirmacao.TabIndex = 11;
            this.lblSenhasConfirmacao.Text = "As senhas não conferem!";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Location = new System.Drawing.Point(5, 87);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Properties.UseSystemPasswordChar = true;
            this.txtConfirmaSenha.Size = new System.Drawing.Size(265, 20);
            this.txtConfirmaSenha.TabIndex = 4;
            this.txtConfirmaSenha.Leave += new System.EventHandler(this.txtConfirmaSenha_Leave);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 67);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(112, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Confirmação de Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(5, 43);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.UseSystemPasswordChar = true;
            this.txtSenha.Size = new System.Drawing.Size(265, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Senha:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnCancelar.Location = new System.Drawing.Point(423, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 44);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rbtInativo);
            this.groupControl1.Controls.Add(this.rbtAtivo);
            this.groupControl1.Location = new System.Drawing.Point(12, 114);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(185, 100);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Status";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(5, 60);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(59, 17);
            this.rbtInativo.TabIndex = 0;
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
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 88);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Size = new System.Drawing.Size(185, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Login:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Size = new System.Drawing.Size(185, 20);
            this.txtNome.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // v_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 328);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "v_Usuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.v_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxUsuarios)).EndInit();
            this.gbxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuarios)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxNovoUsuario)).EndInit();
            this.gbxNovoUsuario.ResumeLayout(false);
            this.gbxNovoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPermissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmaSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPageUsuarios;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabFormPageNovoUsuario;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl gbxUsuarios;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.GroupControl gbxNovoUsuario;
        private DevExpress.XtraGrid.GridControl gridControl1;
        
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblSenhasConfirmacao;
        private DevExpress.XtraEditors.TextEdit txtConfirmaSenha;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gdvUsuarios;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnIdusuario;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnNome;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnLogin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnSenha;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnPermissao;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPermissao;
        
    }
}