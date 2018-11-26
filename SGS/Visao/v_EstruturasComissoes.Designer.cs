namespace SGS.Visao
{
    partial class v_EstruturasComissoes
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
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnIdEstruturaComissao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDescricao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnPorcentagemImob = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnPorcentagemCorretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.tabFormControl1.Size = new System.Drawing.Size(537, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Estruturas";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.groupControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(537, 270);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(375, 222);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(294, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(213, 222);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(456, 222);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(528, 213);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Todas";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(524, 190);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.advBandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColumnIdEstruturaComissao,
            this.ColumnDescricao,
            this.ColumnPorcentagemImob,
            this.ColumnPorcentagemCorretor,
            this.ColumnStatus,
            this.ColumnUsuarioCad});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsPrint.PrintBandHeader = false;
            this.advBandedGridView1.OptionsPrint.PrintDetails = true;
            this.advBandedGridView1.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridView1.OptionsPrint.PrintGroupFooter = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.ColumnIdEstruturaComissao);
            this.gridBand1.Columns.Add(this.ColumnDescricao);
            this.gridBand1.Columns.Add(this.ColumnPorcentagemImob);
            this.gridBand1.Columns.Add(this.ColumnPorcentagemCorretor);
            this.gridBand1.Columns.Add(this.ColumnStatus);
            this.gridBand1.Columns.Add(this.ColumnUsuarioCad);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 755;
            // 
            // ColumnIdEstruturaComissao
            // 
            this.ColumnIdEstruturaComissao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnIdEstruturaComissao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIdEstruturaComissao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIdEstruturaComissao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnIdEstruturaComissao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIdEstruturaComissao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIdEstruturaComissao.Caption = "Código";
            this.ColumnIdEstruturaComissao.FieldName = "idestruturacomissao";
            this.ColumnIdEstruturaComissao.Name = "ColumnIdEstruturaComissao";
            this.ColumnIdEstruturaComissao.Visible = true;
            this.ColumnIdEstruturaComissao.Width = 53;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDescricao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDescricao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDescricao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDescricao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDescricao.Caption = "Descrição";
            this.ColumnDescricao.FieldName = "descricao";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.Visible = true;
            this.ColumnDescricao.Width = 330;
            // 
            // ColumnPorcentagemImob
            // 
            this.ColumnPorcentagemImob.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnPorcentagemImob.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPorcentagemImob.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPorcentagemImob.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPorcentagemImob.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPorcentagemImob.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPorcentagemImob.Caption = "% Imob";
            this.ColumnPorcentagemImob.DisplayFormat.FormatString = "{0:f2} %";
            this.ColumnPorcentagemImob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColumnPorcentagemImob.FieldName = "porcentagemimob";
            this.ColumnPorcentagemImob.Name = "ColumnPorcentagemImob";
            this.ColumnPorcentagemImob.Visible = true;
            this.ColumnPorcentagemImob.Width = 64;
            // 
            // ColumnPorcentagemCorretor
            // 
            this.ColumnPorcentagemCorretor.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnPorcentagemCorretor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPorcentagemCorretor.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPorcentagemCorretor.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPorcentagemCorretor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPorcentagemCorretor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPorcentagemCorretor.Caption = "% Corretor";
            this.ColumnPorcentagemCorretor.DisplayFormat.FormatString = "{0:f2} %";
            this.ColumnPorcentagemCorretor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColumnPorcentagemCorretor.FieldName = "porcentagemcorretor";
            this.ColumnPorcentagemCorretor.Name = "ColumnPorcentagemCorretor";
            this.ColumnPorcentagemCorretor.Visible = true;
            this.ColumnPorcentagemCorretor.Width = 85;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnStatus.Caption = "Status";
            this.ColumnStatus.FieldName = "status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Visible = true;
            this.ColumnStatus.Width = 105;
            // 
            // ColumnUsuarioCad
            // 
            this.ColumnUsuarioCad.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnUsuarioCad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnUsuarioCad.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnUsuarioCad.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnUsuarioCad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnUsuarioCad.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnUsuarioCad.Caption = "Usuário Cad.";
            this.ColumnUsuarioCad.FieldName = "usuariocad";
            this.ColumnUsuarioCad.Name = "ColumnUsuarioCad";
            this.ColumnUsuarioCad.Visible = true;
            this.ColumnUsuarioCad.Width = 118;
            // 
            // v_EstruturasComissoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 325);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "v_EstruturasComissoes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Estruturas de Comissões";
            this.Load += new System.EventHandler(this.v_EstruturasComissoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnIdEstruturaComissao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDescricao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnPorcentagemImob;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnPorcentagemCorretor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnUsuarioCad;
    }
}