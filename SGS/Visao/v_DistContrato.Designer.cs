﻿namespace SGS.Visao
{
    partial class v_DistContrato
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleIconSet formatConditionRuleIconSet1 = new DevExpress.XtraEditors.FormatConditionRuleIconSet();
            DevExpress.XtraEditors.FormatConditionIconSet formatConditionIconSet1 = new DevExpress.XtraEditors.FormatConditionIconSet();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon1 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon2 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon3 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon4 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            DevExpress.XtraEditors.FormatConditionIconSetIcon formatConditionIconSetIcon5 = new DevExpress.XtraEditors.FormatConditionIconSetIcon();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnCodigo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFk_Corretor_DistContrato = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnCorretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFk_Loteamento_DistContrato = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnLoteamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnNumeroContrato = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataDistribuicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataCancelado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDevolucao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataExtravio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnImprimirProtocolo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaixar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1002, 357);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Todas";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.TextChanged += new System.EventHandler(this.gridControl1_EmbeddedNavigator_TextChanged);
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(998, 334);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColumnCodigo,
            this.ColumnFk_Corretor_DistContrato,
            this.ColumnCorretor,
            this.ColumnFk_Loteamento_DistContrato,
            this.ColumnLoteamento,
            this.ColumnNumeroContrato,
            this.ColumnStatus,
            this.ColumnDataDistribuicao,
            this.ColumnDataExtravio,
            this.ColumnDataCancelado,
            this.ColumnDevolucao,
            this.ColumnUsuarioCad});
            gridFormatRule1.Column = this.ColumnStatus;
            gridFormatRule1.ColumnApplyTo = this.ColumnStatus;
            gridFormatRule1.Name = "Format0";
            formatConditionIconSet1.CategoryName = "Ratings";
            formatConditionIconSetIcon1.PredefinedName = "Signs3_2.png";
            formatConditionIconSetIcon1.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon2.PredefinedName = "Symbols3_3.png";
            formatConditionIconSetIcon2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon3.PredefinedName = "Symbols23_2.png";
            formatConditionIconSetIcon3.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            formatConditionIconSetIcon3.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon4.PredefinedName = "Symbols23_3.png";
            formatConditionIconSetIcon4.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSetIcon5.PredefinedName = "Symbols23_1.png";
            formatConditionIconSetIcon5.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            formatConditionIconSetIcon5.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual;
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon3);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon4);
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon5);
            formatConditionIconSet1.Name = "Ratings5";
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number;
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1;
            gridFormatRule1.Rule = formatConditionRuleIconSet1;
            this.advBandedGridView1.FormatRules.Add(gridFormatRule1);
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.CustomFilterDisplayText += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.advBandedGridView1_CustomFilterDisplayText);
            this.advBandedGridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridView1_CustomColumnDisplayText_1);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.ColumnCodigo);
            this.gridBand1.Columns.Add(this.ColumnFk_Corretor_DistContrato);
            this.gridBand1.Columns.Add(this.ColumnCorretor);
            this.gridBand1.Columns.Add(this.ColumnFk_Loteamento_DistContrato);
            this.gridBand1.Columns.Add(this.ColumnLoteamento);
            this.gridBand1.Columns.Add(this.ColumnNumeroContrato);
            this.gridBand1.Columns.Add(this.ColumnStatus);
            this.gridBand1.Columns.Add(this.ColumnDataDistribuicao);
            this.gridBand1.Columns.Add(this.ColumnDataCancelado);
            this.gridBand1.Columns.Add(this.ColumnDevolucao);
            this.gridBand1.Columns.Add(this.ColumnDataExtravio);
            this.gridBand1.Columns.Add(this.ColumnUsuarioCad);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1088;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnCodigo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnCodigo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnCodigo.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnCodigo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnCodigo.Caption = "Código";
            this.ColumnCodigo.FieldName = "iddistribuicaocontratos";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Visible = true;
            this.ColumnCodigo.Width = 51;
            // 
            // ColumnFk_Corretor_DistContrato
            // 
            this.ColumnFk_Corretor_DistContrato.Caption = "Fk_Corretor_DistContrato";
            this.ColumnFk_Corretor_DistContrato.FieldName = "fk_corretor_distribuicaocontratos";
            this.ColumnFk_Corretor_DistContrato.Name = "ColumnFk_Corretor_DistContrato";
            this.ColumnFk_Corretor_DistContrato.Width = 61;
            // 
            // ColumnCorretor
            // 
            this.ColumnCorretor.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnCorretor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnCorretor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnCorretor.Caption = "Corretor";
            this.ColumnCorretor.FieldName = "nome1";
            this.ColumnCorretor.Name = "ColumnCorretor";
            this.ColumnCorretor.Visible = true;
            this.ColumnCorretor.Width = 215;
            // 
            // ColumnFk_Loteamento_DistContrato
            // 
            this.ColumnFk_Loteamento_DistContrato.Caption = "Fk_Loteamento_DistContrato";
            this.ColumnFk_Loteamento_DistContrato.FieldName = "fk_loteamento_distribuicaocontratos";
            this.ColumnFk_Loteamento_DistContrato.Name = "ColumnFk_Loteamento_DistContrato";
            this.ColumnFk_Loteamento_DistContrato.Width = 35;
            // 
            // ColumnLoteamento
            // 
            this.ColumnLoteamento.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnLoteamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnLoteamento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnLoteamento.Caption = "Empreendimento";
            this.ColumnLoteamento.FieldName = "nome";
            this.ColumnLoteamento.Name = "ColumnLoteamento";
            this.ColumnLoteamento.Visible = true;
            this.ColumnLoteamento.Width = 216;
            // 
            // ColumnNumeroContrato
            // 
            this.ColumnNumeroContrato.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnNumeroContrato.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnNumeroContrato.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnNumeroContrato.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnNumeroContrato.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnNumeroContrato.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnNumeroContrato.Caption = "Número Contrato";
            this.ColumnNumeroContrato.FieldName = "numerocontrato";
            this.ColumnNumeroContrato.Name = "ColumnNumeroContrato";
            this.ColumnNumeroContrato.Visible = true;
            this.ColumnNumeroContrato.Width = 107;
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
            this.ColumnStatus.Width = 95;
            // 
            // ColumnDataDistribuicao
            // 
            this.ColumnDataDistribuicao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDataDistribuicao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataDistribuicao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataDistribuicao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDataDistribuicao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataDistribuicao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataDistribuicao.Caption = "Data Distribuição";
            this.ColumnDataDistribuicao.DisplayFormat.FormatString = "g";
            this.ColumnDataDistribuicao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDataDistribuicao.FieldName = "datadistribuicao";
            this.ColumnDataDistribuicao.Name = "ColumnDataDistribuicao";
            this.ColumnDataDistribuicao.Visible = true;
            this.ColumnDataDistribuicao.Width = 107;
            // 
            // ColumnDataCancelado
            // 
            this.ColumnDataCancelado.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDataCancelado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataCancelado.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataCancelado.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDataCancelado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataCancelado.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataCancelado.Caption = "Data Cancelado";
            this.ColumnDataCancelado.DisplayFormat.FormatString = "g";
            this.ColumnDataCancelado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDataCancelado.FieldName = "datacancelado";
            this.ColumnDataCancelado.Name = "ColumnDataCancelado";
            this.ColumnDataCancelado.Visible = true;
            this.ColumnDataCancelado.Width = 90;
            // 
            // ColumnDevolucao
            // 
            this.ColumnDevolucao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDevolucao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDevolucao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDevolucao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDevolucao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDevolucao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDevolucao.Caption = "Data Devolução";
            this.ColumnDevolucao.DisplayFormat.FormatString = "g";
            this.ColumnDevolucao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDevolucao.FieldName = "datadevolucao";
            this.ColumnDevolucao.Name = "ColumnDevolucao";
            this.ColumnDevolucao.Visible = true;
            this.ColumnDevolucao.Width = 89;
            // 
            // ColumnDataExtravio
            // 
            this.ColumnDataExtravio.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDataExtravio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataExtravio.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataExtravio.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDataExtravio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataExtravio.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataExtravio.Caption = "Data Extravio";
            this.ColumnDataExtravio.DisplayFormat.FormatString = "g";
            this.ColumnDataExtravio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDataExtravio.FieldName = "dataextravio";
            this.ColumnDataExtravio.Name = "ColumnDataExtravio";
            this.ColumnDataExtravio.Visible = true;
            this.ColumnDataExtravio.Width = 91;
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
            this.ColumnUsuarioCad.Width = 27;
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(1002, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 1;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Distribuições";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnImprimirProtocolo);
            this.tabFormContentContainer1.Controls.Add(this.btnExportar);
            this.tabFormContentContainer1.Controls.Add(this.btnBaixar);
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.groupControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1002, 418);
            this.tabFormContentContainer1.TabIndex = 2;
            // 
            // btnImprimirProtocolo
            // 
            this.btnImprimirProtocolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimirProtocolo.ImageOptions.Image = global::SGS.Properties.Resources.ImprimirTermic2_24x24;
            this.btnImprimirProtocolo.Location = new System.Drawing.Point(165, 369);
            this.btnImprimirProtocolo.Name = "btnImprimirProtocolo";
            this.btnImprimirProtocolo.Size = new System.Drawing.Size(75, 44);
            this.btnImprimirProtocolo.TabIndex = 7;
            this.btnImprimirProtocolo.Text = "Imprimir";
            this.btnImprimirProtocolo.Click += new System.EventHandler(this.btnImprimirProtocolo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnExportar.Location = new System.Drawing.Point(84, 369);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 44);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnBaixar
            // 
            this.btnBaixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaixar.ImageOptions.Image = global::SGS.Properties.Resources.atualizacao24x24;
            this.btnBaixar.Location = new System.Drawing.Point(3, 369);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 44);
            this.btnBaixar.TabIndex = 5;
            this.btnBaixar.Text = "Status";
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(681, 369);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Distribuir";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(762, 369);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(843, 369);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(924, 369);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // v_DistContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 473);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "v_DistContrato";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Controle de Distribuições de Contratos";
            this.Load += new System.EventHandler(this.v_DistContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
        private DevExpress.XtraEditors.SimpleButton btnBaixar;
        private DevExpress.XtraEditors.SimpleButton btnImprimirProtocolo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnCodigo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnCorretor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnLoteamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnNumeroContrato;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataDistribuicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataExtravio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataCancelado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDevolucao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFk_Corretor_DistContrato;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFk_Loteamento_DistContrato;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}