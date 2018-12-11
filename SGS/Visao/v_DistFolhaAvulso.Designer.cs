namespace SGS.Visao
{
    partial class v_DistFolhaAvulso
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
            this.btnBaixar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimir = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiImprimirGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimirProtocolo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnIddistribuicaofolhasavulsas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnLoteamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnCorretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFolhapagina = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFormaPagamento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnValorFolha = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataDistribuicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataCancelado = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataDevolucao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFk_corretor_distribuicaofolhasavulsas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFk_loteamento_distribuicaofolhasavulsas = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
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
            this.tabFormControl1.Size = new System.Drawing.Size(981, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
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
            this.tabFormContentContainer1.Controls.Add(this.btnBaixar);
            this.tabFormContentContainer1.Controls.Add(this.btnImprimir);
            this.tabFormContentContainer1.Controls.Add(this.btnAtualizar);
            this.tabFormContentContainer1.Controls.Add(this.btnImprimirProtocolo);
            this.tabFormContentContainer1.Controls.Add(this.btnExportar);
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnAlterar);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.groupControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(981, 365);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaixar.ImageOptions.Image = global::SGS.Properties.Resources.AlterarStatusContrato24x24;
            this.btnBaixar.Location = new System.Drawing.Point(3, 309);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 44);
            this.btnBaixar.TabIndex = 17;
            this.btnBaixar.Text = "Status";
            this.btnBaixar.ToolTip = "Clique aqui para mudar o status do registro selecionado!";
            this.btnBaixar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.DropDownControl = this.popupMenu1;
            this.btnImprimir.ImageOptions.Image = global::SGS.Properties.Resources.Imprimir_24x24;
            this.btnImprimir.Location = new System.Drawing.Point(246, 309);
            this.btnImprimir.MenuManager = this.barManager1;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 44);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Relatórios";
            this.btnImprimir.ToolTip = "Clique aqui para imprimir relatórios!";
            this.btnImprimir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImprimirGrid)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbiImprimirGrid
            // 
            this.bbiImprimirGrid.Caption = "ImprimirGrid";
            this.bbiImprimirGrid.Id = 0;
            this.bbiImprimirGrid.Name = "bbiImprimirGrid";
            this.bbiImprimirGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimirGrid_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiImprimirGrid});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(981, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 420);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(981, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(981, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizar.ImageOptions.Image = global::SGS.Properties.Resources.atualizacao24x24;
            this.btnAtualizar.Location = new System.Drawing.Point(354, 309);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 44);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.ToolTip = "Clique aqui para atualizar o grid!";
            this.btnAtualizar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnImprimirProtocolo
            // 
            this.btnImprimirProtocolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimirProtocolo.ImageOptions.Image = global::SGS.Properties.Resources.ImprimirTermic2_24x24;
            this.btnImprimirProtocolo.Location = new System.Drawing.Point(165, 309);
            this.btnImprimirProtocolo.Name = "btnImprimirProtocolo";
            this.btnImprimirProtocolo.Size = new System.Drawing.Size(75, 44);
            this.btnImprimirProtocolo.TabIndex = 14;
            this.btnImprimirProtocolo.Text = "Imprimir";
            this.btnImprimirProtocolo.ToolTip = "Clique aqui para imprimir protocolo do registro selecionado!";
            this.btnImprimirProtocolo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnImprimirProtocolo.Click += new System.EventHandler(this.btnImprimirProtocolo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnExportar.Location = new System.Drawing.Point(84, 309);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 44);
            this.btnExportar.TabIndex = 13;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.ToolTip = "Clique aqui para exportar os registro do grid para o Excel!";
            this.btnExportar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(660, 309);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Distribuir";
            this.btnNovo.ToolTip = "Clique aqui para distribuir contratos!";
            this.btnNovo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(741, 309);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.ToolTip = "Clique aqui para alterar os dados do registro selecionado!";
            this.btnAlterar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(822, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.ToolTip = "Clique aqui para excluir o registro selecionado!";
            this.btnExcluir.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Warning;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(903, 309);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.ToolTip = "Clique aqui para fecha essa janela!";
            this.btnVoltar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(975, 297);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Todas";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(971, 274);
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
            this.ColumnIddistribuicaofolhasavulsas,
            this.ColumnFolhapagina,
            this.ColumnStatus,
            this.ColumnDataDistribuicao,
            this.ColumnDataCancelado,
            this.ColumnDataDevolucao,
            this.ColumnFormaPagamento,
            this.ColumnValorFolha,
            this.ColumnUsuarioCad,
            this.ColumnFk_corretor_distribuicaofolhasavulsas,
            this.ColumnCorretor,
            this.ColumnFk_loteamento_distribuicaofolhasavulsas,
            this.ColumnLoteamento});
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
            this.advBandedGridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.advBandedGridView1_CustomColumnDisplayText);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Todas";
            this.gridBand1.Columns.Add(this.ColumnIddistribuicaofolhasavulsas);
            this.gridBand1.Columns.Add(this.ColumnLoteamento);
            this.gridBand1.Columns.Add(this.ColumnCorretor);
            this.gridBand1.Columns.Add(this.ColumnFolhapagina);
            this.gridBand1.Columns.Add(this.ColumnStatus);
            this.gridBand1.Columns.Add(this.ColumnFormaPagamento);
            this.gridBand1.Columns.Add(this.ColumnValorFolha);
            this.gridBand1.Columns.Add(this.ColumnDataDistribuicao);
            this.gridBand1.Columns.Add(this.ColumnDataCancelado);
            this.gridBand1.Columns.Add(this.ColumnDataDevolucao);
            this.gridBand1.Columns.Add(this.ColumnUsuarioCad);
            this.gridBand1.Columns.Add(this.ColumnFk_corretor_distribuicaofolhasavulsas);
            this.gridBand1.Columns.Add(this.ColumnFk_loteamento_distribuicaofolhasavulsas);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1188;
            // 
            // ColumnIddistribuicaofolhasavulsas
            // 
            this.ColumnIddistribuicaofolhasavulsas.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnIddistribuicaofolhasavulsas.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIddistribuicaofolhasavulsas.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIddistribuicaofolhasavulsas.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnIddistribuicaofolhasavulsas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIddistribuicaofolhasavulsas.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIddistribuicaofolhasavulsas.Caption = "Código";
            this.ColumnIddistribuicaofolhasavulsas.FieldName = "iddistribuicaofolhasavulsas";
            this.ColumnIddistribuicaofolhasavulsas.Name = "ColumnIddistribuicaofolhasavulsas";
            this.ColumnIddistribuicaofolhasavulsas.Visible = true;
            this.ColumnIddistribuicaofolhasavulsas.Width = 52;
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
            this.ColumnLoteamento.Width = 140;
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
            this.ColumnCorretor.Width = 146;
            // 
            // ColumnFolhapagina
            // 
            this.ColumnFolhapagina.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnFolhapagina.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFolhapagina.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFolhapagina.Caption = "Folha-N°";
            this.ColumnFolhapagina.FieldName = "folhapagina";
            this.ColumnFolhapagina.Name = "ColumnFolhapagina";
            this.ColumnFolhapagina.Visible = true;
            this.ColumnFolhapagina.Width = 229;
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
            this.ColumnStatus.Width = 79;
            // 
            // ColumnFormaPagamento
            // 
            this.ColumnFormaPagamento.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnFormaPagamento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFormaPagamento.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFormaPagamento.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnFormaPagamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnFormaPagamento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnFormaPagamento.Caption = "Pagamento";
            this.ColumnFormaPagamento.FieldName = "formapagamento";
            this.ColumnFormaPagamento.Name = "ColumnFormaPagamento";
            this.ColumnFormaPagamento.Visible = true;
            this.ColumnFormaPagamento.Width = 78;
            // 
            // ColumnValorFolha
            // 
            this.ColumnValorFolha.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnValorFolha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnValorFolha.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnValorFolha.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnValorFolha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnValorFolha.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnValorFolha.Caption = "Valor Folha";
            this.ColumnValorFolha.DisplayFormat.FormatString = "c";
            this.ColumnValorFolha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColumnValorFolha.FieldName = "valorfolha";
            this.ColumnValorFolha.Name = "ColumnValorFolha";
            this.ColumnValorFolha.Visible = true;
            this.ColumnValorFolha.Width = 94;
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
            this.ColumnDataDistribuicao.Width = 96;
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
            this.ColumnDataCancelado.Width = 99;
            // 
            // ColumnDataDevolucao
            // 
            this.ColumnDataDevolucao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDataDevolucao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataDevolucao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataDevolucao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDataDevolucao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataDevolucao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataDevolucao.Caption = "Data Devolução";
            this.ColumnDataDevolucao.DisplayFormat.FormatString = "g";
            this.ColumnDataDevolucao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDataDevolucao.FieldName = "datadevolucao";
            this.ColumnDataDevolucao.Name = "ColumnDataDevolucao";
            this.ColumnDataDevolucao.Visible = true;
            this.ColumnDataDevolucao.Width = 99;
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
            this.ColumnUsuarioCad.Width = 76;
            // 
            // ColumnFk_corretor_distribuicaofolhasavulsas
            // 
            this.ColumnFk_corretor_distribuicaofolhasavulsas.Caption = "Fk_corretor_distribuicaofolhasavulsas";
            this.ColumnFk_corretor_distribuicaofolhasavulsas.FieldName = "fk_corretor_distribuicaofolhasavulsas";
            this.ColumnFk_corretor_distribuicaofolhasavulsas.Name = "ColumnFk_corretor_distribuicaofolhasavulsas";
            // 
            // ColumnFk_loteamento_distribuicaofolhasavulsas
            // 
            this.ColumnFk_loteamento_distribuicaofolhasavulsas.Caption = "Fk_loteamento_distribuicaofolhasavulsas";
            this.ColumnFk_loteamento_distribuicaofolhasavulsas.FieldName = "fk_loteamento_distribuicaofolhasavulsas";
            this.ColumnFk_loteamento_distribuicaofolhasavulsas.Name = "ColumnFk_loteamento_distribuicaofolhasavulsas";
            // 
            // v_DistFolhaAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 420);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "v_DistFolhaAvulso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Distribuição de Folha Avulso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_DistFolhaAvulso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.DropDownButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
        private DevExpress.XtraEditors.SimpleButton btnImprimirProtocolo;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiImprimirGrid;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnIddistribuicaofolhasavulsas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnLoteamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnCorretor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFolhapagina;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnStatus;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFormaPagamento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnValorFolha;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataDistribuicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataCancelado;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataDevolucao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFk_corretor_distribuicaofolhasavulsas;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFk_loteamento_distribuicaofolhasavulsas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnBaixar;
    }
}