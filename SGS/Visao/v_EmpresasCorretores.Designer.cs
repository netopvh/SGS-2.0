namespace SGS.Visao
{
    partial class v_EmpresasCorretores
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
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.Todos = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColunaCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaNomeEmpresa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaCNPJ = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaCreciJuridico = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaDataCadastro = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(723, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Empresas";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.gridControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(723, 395);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(402, 348);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(483, 348);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(564, 348);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(645, 348);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 342);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.advBandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.Todos});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColunaCodigo,
            this.ColunaNomeEmpresa,
            this.ColunaCNPJ,
            this.ColunaStatus,
            this.ColunaCreciJuridico,
            this.ColunaUsuarioCad,
            this.ColunaDataCadastro});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsPrint.PrintDetails = true;
            this.advBandedGridView1.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridView1_CustomColumnDisplayText);
            // 
            // Todos
            // 
            this.Todos.Caption = "Todos";
            this.Todos.Columns.Add(this.ColunaCodigo);
            this.Todos.Columns.Add(this.ColunaNomeEmpresa);
            this.Todos.Columns.Add(this.ColunaCNPJ);
            this.Todos.Columns.Add(this.ColunaCreciJuridico);
            this.Todos.Columns.Add(this.ColunaStatus);
            this.Todos.Columns.Add(this.ColunaDataCadastro);
            this.Todos.Columns.Add(this.ColunaUsuarioCad);
            this.Todos.Name = "Todos";
            this.Todos.VisibleIndex = 0;
            this.Todos.Width = 768;
            // 
            // ColunaCodigo
            // 
            this.ColunaCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCodigo.Caption = "Código";
            this.ColunaCodigo.FieldName = "idempresacorretor";
            this.ColunaCodigo.Name = "ColunaCodigo";
            this.ColunaCodigo.Visible = true;
            this.ColunaCodigo.Width = 74;
            // 
            // ColunaNomeEmpresa
            // 
            this.ColunaNomeEmpresa.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaNomeEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaNomeEmpresa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaNomeEmpresa.Caption = "Nome Empresa";
            this.ColunaNomeEmpresa.FieldName = "nomeempresa";
            this.ColunaNomeEmpresa.Name = "ColunaNomeEmpresa";
            this.ColunaNomeEmpresa.Visible = true;
            this.ColunaNomeEmpresa.Width = 196;
            // 
            // ColunaCNPJ
            // 
            this.ColunaCNPJ.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaCNPJ.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCNPJ.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCNPJ.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaCNPJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCNPJ.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCNPJ.Caption = "CNPJ";
            this.ColunaCNPJ.FieldName = "cnpj";
            this.ColunaCNPJ.Name = "ColunaCNPJ";
            this.ColunaCNPJ.Visible = true;
            this.ColunaCNPJ.Width = 154;
            // 
            // ColunaCreciJuridico
            // 
            this.ColunaCreciJuridico.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaCreciJuridico.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCreciJuridico.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCreciJuridico.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaCreciJuridico.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaCreciJuridico.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaCreciJuridico.Caption = "Creci Jurídico";
            this.ColunaCreciJuridico.FieldName = "crecijuridico";
            this.ColunaCreciJuridico.Name = "ColunaCreciJuridico";
            this.ColunaCreciJuridico.Visible = true;
            this.ColunaCreciJuridico.Width = 92;
            // 
            // ColunaStatus
            // 
            this.ColunaStatus.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaStatus.Caption = "Status";
            this.ColunaStatus.FieldName = "status";
            this.ColunaStatus.Name = "ColunaStatus";
            this.ColunaStatus.Visible = true;
            this.ColunaStatus.Width = 80;
            // 
            // ColunaDataCadastro
            // 
            this.ColunaDataCadastro.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaDataCadastro.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaDataCadastro.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaDataCadastro.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaDataCadastro.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaDataCadastro.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaDataCadastro.Caption = "Data Cad.";
            this.ColunaDataCadastro.DisplayFormat.FormatString = "d";
            this.ColunaDataCadastro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColunaDataCadastro.FieldName = "datacadastro";
            this.ColunaDataCadastro.Name = "ColunaDataCadastro";
            this.ColunaDataCadastro.Visible = true;
            // 
            // ColunaUsuarioCad
            // 
            this.ColunaUsuarioCad.AppearanceCell.Options.UseTextOptions = true;
            this.ColunaUsuarioCad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaUsuarioCad.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaUsuarioCad.AppearanceHeader.Options.UseTextOptions = true;
            this.ColunaUsuarioCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColunaUsuarioCad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColunaUsuarioCad.Caption = "Usuário Cad.";
            this.ColunaUsuarioCad.FieldName = "usuariocad";
            this.ColunaUsuarioCad.Name = "ColunaUsuarioCad";
            this.ColunaUsuarioCad.Visible = true;
            this.ColunaUsuarioCad.Width = 97;
            // 
            // v_EmpresasCorretores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "v_EmpresasCorretores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Empresas dos Corretores";
            this.Load += new System.EventHandler(this.v_EmpresasCorretores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaNomeEmpresa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaCNPJ;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaCreciJuridico;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand Todos;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaDataCadastro;
    }
}