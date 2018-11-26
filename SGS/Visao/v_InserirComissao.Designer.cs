namespace SGS.Visao
{
    partial class v_InserirComissao
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
            this.lblArquivo = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.GridColumnEmpresa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnObra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnCorretor_PF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnCliente = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnQD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnLT = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnStatusVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnDataVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnDataCadVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnVlrVenda = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnParcelaTipo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnParcela = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnQtdParcela = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnVencimentoParcela = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridColumnValorParcela = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLocalizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlanilhaExemplo = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(93, 38);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(48, 13);
            this.lblArquivo.TabIndex = 0;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 62);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(786, 326);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Excel";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(782, 303);
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
            this.GridColumnEmpresa,
            this.GridColumnVenda,
            this.GridColumnObra,
            this.GridColumnCorretor_PF,
            this.GridColumnCliente,
            this.GridColumnQD,
            this.GridColumnLT,
            this.GridColumnStatusVenda,
            this.GridColumnDataVenda,
            this.GridColumnDataCadVenda,
            this.GridColumnVlrVenda,
            this.GridColumnParcelaTipo,
            this.GridColumnParcela,
            this.GridColumnQtdParcela,
            this.GridColumnVencimentoParcela,
            this.GridColumnValorParcela});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsSelection.MultiSelect = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Dados";
            this.gridBand1.Columns.Add(this.GridColumnEmpresa);
            this.gridBand1.Columns.Add(this.GridColumnVenda);
            this.gridBand1.Columns.Add(this.GridColumnObra);
            this.gridBand1.Columns.Add(this.GridColumnCorretor_PF);
            this.gridBand1.Columns.Add(this.GridColumnCliente);
            this.gridBand1.Columns.Add(this.GridColumnQD);
            this.gridBand1.Columns.Add(this.GridColumnLT);
            this.gridBand1.Columns.Add(this.GridColumnStatusVenda);
            this.gridBand1.Columns.Add(this.GridColumnDataVenda);
            this.gridBand1.Columns.Add(this.GridColumnDataCadVenda);
            this.gridBand1.Columns.Add(this.GridColumnVlrVenda);
            this.gridBand1.Columns.Add(this.GridColumnParcelaTipo);
            this.gridBand1.Columns.Add(this.GridColumnParcela);
            this.gridBand1.Columns.Add(this.GridColumnQtdParcela);
            this.gridBand1.Columns.Add(this.GridColumnVencimentoParcela);
            this.gridBand1.Columns.Add(this.GridColumnValorParcela);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1109;
            // 
            // GridColumnEmpresa
            // 
            this.GridColumnEmpresa.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnEmpresa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnEmpresa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnEmpresa.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnEmpresa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnEmpresa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnEmpresa.Caption = "Empresa";
            this.GridColumnEmpresa.FieldName = "empresa";
            this.GridColumnEmpresa.Name = "GridColumnEmpresa";
            this.GridColumnEmpresa.Visible = true;
            this.GridColumnEmpresa.Width = 76;
            // 
            // GridColumnVenda
            // 
            this.GridColumnVenda.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVenda.Caption = "Venda";
            this.GridColumnVenda.FieldName = "venda";
            this.GridColumnVenda.Name = "GridColumnVenda";
            this.GridColumnVenda.Visible = true;
            this.GridColumnVenda.Width = 41;
            // 
            // GridColumnObra
            // 
            this.GridColumnObra.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnObra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnObra.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnObra.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnObra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnObra.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnObra.Caption = "Obra";
            this.GridColumnObra.FieldName = "obra";
            this.GridColumnObra.Name = "GridColumnObra";
            this.GridColumnObra.Visible = true;
            this.GridColumnObra.Width = 35;
            // 
            // GridColumnCorretor_PF
            // 
            this.GridColumnCorretor_PF.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnCorretor_PF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnCorretor_PF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnCorretor_PF.Caption = "Corretor-PF";
            this.GridColumnCorretor_PF.FieldName = "corretor";
            this.GridColumnCorretor_PF.Name = "GridColumnCorretor_PF";
            this.GridColumnCorretor_PF.Visible = true;
            this.GridColumnCorretor_PF.Width = 84;
            // 
            // GridColumnCliente
            // 
            this.GridColumnCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnCliente.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnCliente.Caption = "Cliente";
            this.GridColumnCliente.FieldName = "cliente";
            this.GridColumnCliente.Name = "GridColumnCliente";
            this.GridColumnCliente.Visible = true;
            this.GridColumnCliente.Width = 71;
            // 
            // GridColumnQD
            // 
            this.GridColumnQD.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnQD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnQD.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnQD.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnQD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnQD.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnQD.Caption = "QD";
            this.GridColumnQD.DisplayFormat.FormatString = "{0:d3}";
            this.GridColumnQD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnQD.FieldName = "qd";
            this.GridColumnQD.Name = "GridColumnQD";
            this.GridColumnQD.Visible = true;
            this.GridColumnQD.Width = 36;
            // 
            // GridColumnLT
            // 
            this.GridColumnLT.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnLT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnLT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnLT.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnLT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnLT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnLT.Caption = "LT";
            this.GridColumnLT.DisplayFormat.FormatString = "{0:d3}";
            this.GridColumnLT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnLT.FieldName = "lt";
            this.GridColumnLT.Name = "GridColumnLT";
            this.GridColumnLT.Visible = true;
            this.GridColumnLT.Width = 46;
            // 
            // GridColumnStatusVenda
            // 
            this.GridColumnStatusVenda.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnStatusVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnStatusVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnStatusVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnStatusVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnStatusVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnStatusVenda.Caption = "StatusVenda";
            this.GridColumnStatusVenda.FieldName = "statusvenda";
            this.GridColumnStatusVenda.Name = "GridColumnStatusVenda";
            this.GridColumnStatusVenda.Visible = true;
            this.GridColumnStatusVenda.Width = 95;
            // 
            // GridColumnDataVenda
            // 
            this.GridColumnDataVenda.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnDataVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnDataVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnDataVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnDataVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnDataVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnDataVenda.Caption = "DataVenda";
            this.GridColumnDataVenda.DisplayFormat.FormatString = "d";
            this.GridColumnDataVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GridColumnDataVenda.FieldName = "datavenda";
            this.GridColumnDataVenda.Name = "GridColumnDataVenda";
            this.GridColumnDataVenda.Visible = true;
            this.GridColumnDataVenda.Width = 78;
            // 
            // GridColumnDataCadVenda
            // 
            this.GridColumnDataCadVenda.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnDataCadVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnDataCadVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnDataCadVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnDataCadVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnDataCadVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnDataCadVenda.Caption = "DataCadVenda";
            this.GridColumnDataCadVenda.DisplayFormat.FormatString = "d";
            this.GridColumnDataCadVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GridColumnDataCadVenda.FieldName = "datacad";
            this.GridColumnDataCadVenda.Name = "GridColumnDataCadVenda";
            this.GridColumnDataCadVenda.Visible = true;
            this.GridColumnDataCadVenda.Width = 95;
            // 
            // GridColumnVlrVenda
            // 
            this.GridColumnVlrVenda.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnVlrVenda.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVlrVenda.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVlrVenda.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnVlrVenda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVlrVenda.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVlrVenda.Caption = "VlrVenda";
            this.GridColumnVlrVenda.DisplayFormat.FormatString = "c";
            this.GridColumnVlrVenda.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnVlrVenda.FieldName = "vlrvenda";
            this.GridColumnVlrVenda.Name = "GridColumnVlrVenda";
            this.GridColumnVlrVenda.Visible = true;
            this.GridColumnVlrVenda.Width = 78;
            // 
            // GridColumnParcelaTipo
            // 
            this.GridColumnParcelaTipo.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnParcelaTipo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnParcelaTipo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnParcelaTipo.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnParcelaTipo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnParcelaTipo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnParcelaTipo.Caption = "ParcelaTipo";
            this.GridColumnParcelaTipo.FieldName = "parcelatipo";
            this.GridColumnParcelaTipo.Name = "GridColumnParcelaTipo";
            this.GridColumnParcelaTipo.Visible = true;
            this.GridColumnParcelaTipo.Width = 86;
            // 
            // GridColumnParcela
            // 
            this.GridColumnParcela.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnParcela.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnParcela.Caption = "Parcela";
            this.GridColumnParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnParcela.FieldName = "parcela";
            this.GridColumnParcela.Name = "GridColumnParcela";
            this.GridColumnParcela.Visible = true;
            this.GridColumnParcela.Width = 57;
            // 
            // GridColumnQtdParcela
            // 
            this.GridColumnQtdParcela.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnQtdParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnQtdParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnQtdParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnQtdParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnQtdParcela.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnQtdParcela.Caption = "QtdParcela";
            this.GridColumnQtdParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnQtdParcela.FieldName = "qtdparc";
            this.GridColumnQtdParcela.Name = "GridColumnQtdParcela";
            this.GridColumnQtdParcela.Visible = true;
            this.GridColumnQtdParcela.Width = 83;
            // 
            // GridColumnVencimentoParcela
            // 
            this.GridColumnVencimentoParcela.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnVencimentoParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVencimentoParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVencimentoParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnVencimentoParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnVencimentoParcela.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnVencimentoParcela.Caption = "Vencimento";
            this.GridColumnVencimentoParcela.DisplayFormat.FormatString = "d";
            this.GridColumnVencimentoParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GridColumnVencimentoParcela.FieldName = "vencimento";
            this.GridColumnVencimentoParcela.Name = "GridColumnVencimentoParcela";
            this.GridColumnVencimentoParcela.Visible = true;
            this.GridColumnVencimentoParcela.Width = 74;
            // 
            // GridColumnValorParcela
            // 
            this.GridColumnValorParcela.AppearanceCell.Options.UseTextOptions = true;
            this.GridColumnValorParcela.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnValorParcela.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnValorParcela.AppearanceHeader.Options.UseTextOptions = true;
            this.GridColumnValorParcela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridColumnValorParcela.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridColumnValorParcela.Caption = "ValorParcela";
            this.GridColumnValorParcela.DisplayFormat.FormatString = "c";
            this.GridColumnValorParcela.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GridColumnValorParcela.FieldName = "valorparcela";
            this.GridColumnValorParcela.Name = "GridColumnValorParcela";
            this.GridColumnValorParcela.Visible = true;
            this.GridColumnValorParcela.Width = 74;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(723, 394);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnLocalizar.Location = new System.Drawing.Point(12, 12);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 44);
            this.btnLocalizar.TabIndex = 3;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(642, 394);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(147, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(651, 21);
            this.textBox1.TabIndex = 5;
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(147, 12);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Size = new System.Drawing.Size(651, 20);
            this.searchControl1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grid:";
            // 
            // btnPlanilhaExemplo
            // 
            this.btnPlanilhaExemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanilhaExemplo.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnPlanilhaExemplo.Location = new System.Drawing.Point(533, 394);
            this.btnPlanilhaExemplo.Name = "btnPlanilhaExemplo";
            this.btnPlanilhaExemplo.Size = new System.Drawing.Size(103, 44);
            this.btnPlanilhaExemplo.TabIndex = 8;
            this.btnPlanilhaExemplo.Text = "Excel Exemplo";
            this.btnPlanilhaExemplo.Click += new System.EventHandler(this.btnPlanilhaExemplo_Click);
            // 
            // v_InserirComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.btnPlanilhaExemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblArquivo);
            this.Name = "v_InserirComissao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir parcelas de Comissões";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_InserirComissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label lblArquivo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnLocalizar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnEmpresa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnObra;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnCorretor_PF;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnCliente;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnQD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnLT;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnStatusVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnDataVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnDataCadVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnVlrVenda;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnParcelaTipo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnParcela;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnQtdParcela;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnVencimentoParcela;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridColumnValorParcela;
        private DevExpress.XtraEditors.SimpleButton btnPlanilhaExemplo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}