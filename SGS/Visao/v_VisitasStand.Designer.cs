﻿namespace SGS.Visao
{
    partial class v_VisitasStand
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.GridcolumnIdAtendimento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnNomeCliente = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnTelefone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnLocalizou = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnCidadeUF = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnEmpreendimento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnDataAtendimento = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnIdentificador = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnCorretorAtual = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnAtendimentoAnterior = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnSituacao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnDataCompra = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.GridcolumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlterar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnComprou = new DevExpress.XtraEditors.SimpleButton();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiAtendimentosSintetico = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImprimirGrid = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDesistiu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.searchControl1);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(776, 338);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Todas os registros";
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(422, 28);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Size = new System.Drawing.Size(350, 20);
            this.searchControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(772, 315);
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
            this.GridcolumnIdAtendimento,
            this.GridcolumnNomeCliente,
            this.GridcolumnTelefone,
            this.GridcolumnAtendimentoAnterior,
            this.GridcolumnIdentificador,
            this.GridcolumnLocalizou,
            this.GridcolumnSituacao,
            this.GridcolumnCidadeUF,
            this.GridcolumnCorretorAtual,
            this.GridcolumnEmpreendimento,
            this.GridcolumnDataAtendimento,
            this.GridcolumnDataCompra,
            this.GridcolumnUsuarioCad});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsPrint.PrintBandHeader = false;
            this.advBandedGridView1.OptionsPrint.PrintDetails = true;
            this.advBandedGridView1.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridView1.OptionsPrint.PrintGroupFooter = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand1.Caption = "Você pode pesquisar os registros filtrando como no Excel o Grid.";
            this.gridBand1.Columns.Add(this.GridcolumnIdAtendimento);
            this.gridBand1.Columns.Add(this.GridcolumnNomeCliente);
            this.gridBand1.Columns.Add(this.GridcolumnTelefone);
            this.gridBand1.Columns.Add(this.GridcolumnLocalizou);
            this.gridBand1.Columns.Add(this.GridcolumnCidadeUF);
            this.gridBand1.Columns.Add(this.GridcolumnEmpreendimento);
            this.gridBand1.Columns.Add(this.GridcolumnDataAtendimento);
            this.gridBand1.Columns.Add(this.GridcolumnIdentificador);
            this.gridBand1.Columns.Add(this.GridcolumnCorretorAtual);
            this.gridBand1.Columns.Add(this.GridcolumnAtendimentoAnterior);
            this.gridBand1.Columns.Add(this.GridcolumnSituacao);
            this.gridBand1.Columns.Add(this.GridcolumnDataCompra);
            this.gridBand1.Columns.Add(this.GridcolumnUsuarioCad);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1085;
            // 
            // GridcolumnIdAtendimento
            // 
            this.GridcolumnIdAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnIdAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnIdAtendimento.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnIdAtendimento.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnIdAtendimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnIdAtendimento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnIdAtendimento.Caption = "Código";
            this.GridcolumnIdAtendimento.FieldName = "idatendimento";
            this.GridcolumnIdAtendimento.Name = "GridcolumnIdAtendimento";
            this.GridcolumnIdAtendimento.Visible = true;
            this.GridcolumnIdAtendimento.Width = 63;
            // 
            // GridcolumnNomeCliente
            // 
            this.GridcolumnNomeCliente.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnNomeCliente.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnNomeCliente.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnNomeCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnNomeCliente.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnNomeCliente.Caption = "Cliente";
            this.GridcolumnNomeCliente.FieldName = "nomeCliente";
            this.GridcolumnNomeCliente.Name = "GridcolumnNomeCliente";
            this.GridcolumnNomeCliente.Visible = true;
            this.GridcolumnNomeCliente.Width = 58;
            // 
            // GridcolumnTelefone
            // 
            this.GridcolumnTelefone.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnTelefone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnTelefone.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnTelefone.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnTelefone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnTelefone.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnTelefone.Caption = "Telefone";
            this.GridcolumnTelefone.FieldName = "telefone";
            this.GridcolumnTelefone.Name = "GridcolumnTelefone";
            this.GridcolumnTelefone.Visible = true;
            this.GridcolumnTelefone.Width = 61;
            // 
            // GridcolumnLocalizou
            // 
            this.GridcolumnLocalizou.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnLocalizou.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnLocalizou.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnLocalizou.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnLocalizou.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnLocalizou.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnLocalizou.Caption = "Localizou";
            this.GridcolumnLocalizou.FieldName = "localizou";
            this.GridcolumnLocalizou.Name = "GridcolumnLocalizou";
            this.GridcolumnLocalizou.Visible = true;
            this.GridcolumnLocalizou.Width = 62;
            // 
            // GridcolumnCidadeUF
            // 
            this.GridcolumnCidadeUF.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnCidadeUF.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnCidadeUF.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnCidadeUF.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnCidadeUF.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnCidadeUF.Caption = "Cidade-UF";
            this.GridcolumnCidadeUF.FieldName = "cidadeUF";
            this.GridcolumnCidadeUF.Name = "GridcolumnCidadeUF";
            this.GridcolumnCidadeUF.Visible = true;
            this.GridcolumnCidadeUF.Width = 69;
            // 
            // GridcolumnEmpreendimento
            // 
            this.GridcolumnEmpreendimento.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnEmpreendimento.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnEmpreendimento.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnEmpreendimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnEmpreendimento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnEmpreendimento.Caption = "Empreendimento";
            this.GridcolumnEmpreendimento.FieldName = "empreendimento";
            this.GridcolumnEmpreendimento.Name = "GridcolumnEmpreendimento";
            this.GridcolumnEmpreendimento.Visible = true;
            this.GridcolumnEmpreendimento.Width = 99;
            // 
            // GridcolumnDataAtendimento
            // 
            this.GridcolumnDataAtendimento.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnDataAtendimento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnDataAtendimento.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnDataAtendimento.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnDataAtendimento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnDataAtendimento.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnDataAtendimento.Caption = "Data Atendimento";
            this.GridcolumnDataAtendimento.DisplayFormat.FormatString = "g";
            this.GridcolumnDataAtendimento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GridcolumnDataAtendimento.FieldName = "dataAtendimento";
            this.GridcolumnDataAtendimento.Name = "GridcolumnDataAtendimento";
            this.GridcolumnDataAtendimento.Visible = true;
            this.GridcolumnDataAtendimento.Width = 106;
            // 
            // GridcolumnIdentificador
            // 
            this.GridcolumnIdentificador.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnIdentificador.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnIdentificador.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnIdentificador.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnIdentificador.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnIdentificador.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnIdentificador.Caption = "Identificador";
            this.GridcolumnIdentificador.FieldName = "identificador";
            this.GridcolumnIdentificador.Name = "GridcolumnIdentificador";
            this.GridcolumnIdentificador.Visible = true;
            this.GridcolumnIdentificador.Width = 92;
            // 
            // GridcolumnCorretorAtual
            // 
            this.GridcolumnCorretorAtual.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnCorretorAtual.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnCorretorAtual.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnCorretorAtual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnCorretorAtual.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnCorretorAtual.Caption = "Corretor Atual";
            this.GridcolumnCorretorAtual.FieldName = "corretorAtual";
            this.GridcolumnCorretorAtual.Name = "GridcolumnCorretorAtual";
            this.GridcolumnCorretorAtual.Visible = true;
            this.GridcolumnCorretorAtual.Width = 146;
            // 
            // GridcolumnAtendimentoAnterior
            // 
            this.GridcolumnAtendimentoAnterior.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnAtendimentoAnterior.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnAtendimentoAnterior.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnAtendimentoAnterior.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnAtendimentoAnterior.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnAtendimentoAnterior.Caption = "Atendimento Anterior";
            this.GridcolumnAtendimentoAnterior.FieldName = "atendimentoAnterior";
            this.GridcolumnAtendimentoAnterior.Name = "GridcolumnAtendimentoAnterior";
            this.GridcolumnAtendimentoAnterior.Visible = true;
            this.GridcolumnAtendimentoAnterior.Width = 153;
            // 
            // GridcolumnSituacao
            // 
            this.GridcolumnSituacao.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnSituacao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnSituacao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnSituacao.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnSituacao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnSituacao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnSituacao.Caption = "Situação";
            this.GridcolumnSituacao.FieldName = "comprou";
            this.GridcolumnSituacao.Name = "GridcolumnSituacao";
            this.GridcolumnSituacao.Visible = true;
            this.GridcolumnSituacao.Width = 62;
            // 
            // GridcolumnDataCompra
            // 
            this.GridcolumnDataCompra.AppearanceCell.Options.UseTextOptions = true;
            this.GridcolumnDataCompra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnDataCompra.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnDataCompra.AppearanceHeader.Options.UseTextOptions = true;
            this.GridcolumnDataCompra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GridcolumnDataCompra.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GridcolumnDataCompra.Caption = "Data Compra";
            this.GridcolumnDataCompra.DisplayFormat.FormatString = "d";
            this.GridcolumnDataCompra.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.GridcolumnDataCompra.FieldName = "dataCompra";
            this.GridcolumnDataCompra.Name = "GridcolumnDataCompra";
            this.GridcolumnDataCompra.Visible = true;
            this.GridcolumnDataCompra.Width = 82;
            // 
            // GridcolumnUsuarioCad
            // 
            this.GridcolumnUsuarioCad.Caption = "Usuário Cad.";
            this.GridcolumnUsuarioCad.FieldName = "usuariocad";
            this.GridcolumnUsuarioCad.Name = "GridcolumnUsuarioCad";
            this.GridcolumnUsuarioCad.Visible = true;
            this.GridcolumnUsuarioCad.Width = 32;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(713, 356);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(632, 356);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 44);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.ImageOptions.Image = global::SGS.Properties.Resources.EditarRegistro24x24;
            this.btnAlterar.Location = new System.Drawing.Point(551, 356);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 44);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(470, 356);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnExportar.Location = new System.Drawing.Point(174, 356);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 44);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnComprou
            // 
            this.btnComprou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComprou.ImageOptions.Image = global::SGS.Properties.Resources.FechaNegocio24x24;
            this.btnComprou.Location = new System.Drawing.Point(12, 356);
            this.btnComprou.Name = "btnComprou";
            this.btnComprou.Size = new System.Drawing.Size(75, 44);
            this.btnComprou.TabIndex = 6;
            this.btnComprou.Text = "Comprou";
            this.btnComprou.Click += new System.EventHandler(this.btnComprou_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtualizar.ImageOptions.Image = global::SGS.Properties.Resources.atualizacao24x24;
            this.btnAtualizar.Location = new System.Drawing.Point(255, 356);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 44);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.Image = global::SGS.Properties.Resources.Imprimir_24x24;
            this.dropDownButton1.Location = new System.Drawing.Point(336, 356);
            this.dropDownButton1.MenuManager = this.barManager1;
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(103, 44);
            this.dropDownButton1.TabIndex = 8;
            this.dropDownButton1.Text = "Relatórios";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiAtendimentosSintetico),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImprimirGrid)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // bbiAtendimentosSintetico
            // 
            this.bbiAtendimentosSintetico.Caption = "Atendimentos Sintetico";
            this.bbiAtendimentosSintetico.Id = 0;
            this.bbiAtendimentosSintetico.Name = "bbiAtendimentosSintetico";
            this.bbiAtendimentosSintetico.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAtendimentosSintetico_ItemClick);
            // 
            // bbiImprimirGrid
            // 
            this.bbiImprimirGrid.Caption = "ImprimirGrid";
            this.bbiImprimirGrid.Id = 1;
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
            this.bbiAtendimentosSintetico,
            this.bbiImprimirGrid});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 404);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 404);
            // 
            // btnDesistiu
            // 
            this.btnDesistiu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesistiu.ImageOptions.Image = global::SGS.Properties.Resources.Triste24x24;
            this.btnDesistiu.Location = new System.Drawing.Point(93, 356);
            this.btnDesistiu.Name = "btnDesistiu";
            this.btnDesistiu.Size = new System.Drawing.Size(75, 44);
            this.btnDesistiu.TabIndex = 13;
            this.btnDesistiu.Text = "Desistiu";
            this.btnDesistiu.Click += new System.EventHandler(this.btnDesistiu_Click);
            // 
            // v_VisitasStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.btnDesistiu);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnComprou);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "v_VisitasStand";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Visitas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.v_VisitasStand_Activated);
            this.Load += new System.EventHandler(this.v_VisitasStand_Load);
            this.Enter += new System.EventHandler(this.v_VisitasStand_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnAlterar;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraGrid.GridControl gridControl1;
        
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnIdAtendimento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnNomeCliente;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnTelefone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnAtendimentoAnterior;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnIdentificador;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnLocalizou;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnSituacao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnCidadeUF;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnCorretorAtual;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnEmpreendimento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnDataAtendimento;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnDataCompra;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn GridcolumnUsuarioCad;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnComprou;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem bbiAtendimentosSintetico;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnDesistiu;
        private DevExpress.XtraBars.BarButtonItem bbiImprimirGrid;
    }
}