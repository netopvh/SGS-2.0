namespace SGS.Visao
{
    partial class v_ControlePlatao
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.advBandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBandCorretores = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnIdCorretorPlantao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnPosicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnNomeCorretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnFk_plantao_corretorPlantao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridbandPlantaoes = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnIdPlantao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnEquipe = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnDataPlantao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnHoraInicial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnHoraFinal = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnTempoPessoa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnUsuarioCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.btnExportar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNovo = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcluir = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxTodosPlatoes = new DevExpress.XtraEditors.GroupControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbxTodosPlatoes)).BeginInit();
            this.gbxTodosPlatoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // advBandedGridView2
            // 
            this.advBandedGridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.advBandedGridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.advBandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandCorretores});
            this.advBandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColumnIdCorretorPlantao,
            this.ColumnPosicao,
            this.ColumnNomeCorretor,
            this.ColumnFk_plantao_corretorPlantao});
            this.advBandedGridView2.GridControl = this.gridControl1;
            this.advBandedGridView2.Name = "advBandedGridView2";
            this.advBandedGridView2.OptionsBehavior.Editable = false;
            this.advBandedGridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView2.OptionsPrint.PrintDetails = true;
            this.advBandedGridView2.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView2.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // gridBandCorretores
            // 
            this.gridBandCorretores.Caption = "Corretores";
            this.gridBandCorretores.Columns.Add(this.ColumnIdCorretorPlantao);
            this.gridBandCorretores.Columns.Add(this.ColumnPosicao);
            this.gridBandCorretores.Columns.Add(this.ColumnNomeCorretor);
            this.gridBandCorretores.Columns.Add(this.ColumnFk_plantao_corretorPlantao);
            this.gridBandCorretores.Name = "gridBandCorretores";
            this.gridBandCorretores.VisibleIndex = 0;
            this.gridBandCorretores.Width = 300;
            // 
            // ColumnIdCorretorPlantao
            // 
            this.ColumnIdCorretorPlantao.Caption = "Código";
            this.ColumnIdCorretorPlantao.FieldName = "idcorretorplantao";
            this.ColumnIdCorretorPlantao.Name = "ColumnIdCorretorPlantao";
            this.ColumnIdCorretorPlantao.Visible = true;
            // 
            // ColumnPosicao
            // 
            this.ColumnPosicao.Caption = "Posição";
            this.ColumnPosicao.FieldName = "posicao";
            this.ColumnPosicao.Name = "ColumnPosicao";
            this.ColumnPosicao.Visible = true;
            // 
            // ColumnNomeCorretor
            // 
            this.ColumnNomeCorretor.Caption = "Corretor";
            this.ColumnNomeCorretor.FieldName = "nomecorretor";
            this.ColumnNomeCorretor.Name = "ColumnNomeCorretor";
            this.ColumnNomeCorretor.Visible = true;
            // 
            // ColumnFk_plantao_corretorPlantao
            // 
            this.ColumnFk_plantao_corretorPlantao.Caption = "fk_plantao_corretorplantao";
            this.ColumnFk_plantao_corretorPlantao.FieldName = "fk_plantao_corretorplantao";
            this.ColumnFk_plantao_corretorPlantao.Name = "ColumnFk_plantao_corretorPlantao";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.advBandedGridView2;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(793, 313);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.advBandedGridView2});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightSkyBlue;
            this.advBandedGridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridbandPlantaoes});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColumnIdPlantao,
            this.ColumnEquipe,
            this.ColumnDataPlantao,
            this.ColumnHoraInicial,
            this.ColumnHoraFinal,
            this.ColumnTempoPessoa,
            this.ColumnUsuarioCad});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsPrint.PrintFilterInfo = true;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            // 
            // gridbandPlantaoes
            // 
            this.gridbandPlantaoes.Caption = "Plantões";
            this.gridbandPlantaoes.Columns.Add(this.ColumnIdPlantao);
            this.gridbandPlantaoes.Columns.Add(this.ColumnEquipe);
            this.gridbandPlantaoes.Columns.Add(this.ColumnDataPlantao);
            this.gridbandPlantaoes.Columns.Add(this.ColumnHoraInicial);
            this.gridbandPlantaoes.Columns.Add(this.ColumnHoraFinal);
            this.gridbandPlantaoes.Columns.Add(this.ColumnTempoPessoa);
            this.gridbandPlantaoes.Columns.Add(this.ColumnUsuarioCad);
            this.gridbandPlantaoes.Name = "gridbandPlantaoes";
            this.gridbandPlantaoes.VisibleIndex = 0;
            this.gridbandPlantaoes.Width = 525;
            // 
            // ColumnIdPlantao
            // 
            this.ColumnIdPlantao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnIdPlantao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIdPlantao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIdPlantao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnIdPlantao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnIdPlantao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnIdPlantao.Caption = "Código Plantão";
            this.ColumnIdPlantao.FieldName = "idplantao";
            this.ColumnIdPlantao.Name = "ColumnIdPlantao";
            this.ColumnIdPlantao.Visible = true;
            // 
            // ColumnEquipe
            // 
            this.ColumnEquipe.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnEquipe.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnEquipe.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnEquipe.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnEquipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnEquipe.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnEquipe.Caption = "Equipe";
            this.ColumnEquipe.FieldName = "equipe";
            this.ColumnEquipe.Name = "ColumnEquipe";
            this.ColumnEquipe.Visible = true;
            // 
            // ColumnDataPlantao
            // 
            this.ColumnDataPlantao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnDataPlantao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataPlantao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataPlantao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnDataPlantao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnDataPlantao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnDataPlantao.Caption = "Data Plantão";
            this.ColumnDataPlantao.DisplayFormat.FormatString = "d";
            this.ColumnDataPlantao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnDataPlantao.FieldName = "dataplantao";
            this.ColumnDataPlantao.Name = "ColumnDataPlantao";
            this.ColumnDataPlantao.Visible = true;
            // 
            // ColumnHoraInicial
            // 
            this.ColumnHoraInicial.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnHoraInicial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnHoraInicial.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnHoraInicial.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnHoraInicial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnHoraInicial.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnHoraInicial.Caption = "Hora Inicial Plantão";
            this.ColumnHoraInicial.DisplayFormat.FormatString = "T";
            this.ColumnHoraInicial.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnHoraInicial.FieldName = "horainicial";
            this.ColumnHoraInicial.Name = "ColumnHoraInicial";
            this.ColumnHoraInicial.Visible = true;
            // 
            // ColumnHoraFinal
            // 
            this.ColumnHoraFinal.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnHoraFinal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnHoraFinal.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnHoraFinal.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnHoraFinal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnHoraFinal.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnHoraFinal.Caption = "Hora Final Plantão";
            this.ColumnHoraFinal.DisplayFormat.FormatString = "T";
            this.ColumnHoraFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnHoraFinal.FieldName = "horafinal";
            this.ColumnHoraFinal.Name = "ColumnHoraFinal";
            this.ColumnHoraFinal.Visible = true;
            // 
            // ColumnTempoPessoa
            // 
            this.ColumnTempoPessoa.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnTempoPessoa.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnTempoPessoa.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnTempoPessoa.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnTempoPessoa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnTempoPessoa.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnTempoPessoa.Caption = "Tempo P/ Pessoa";
            this.ColumnTempoPessoa.DisplayFormat.FormatString = "T";
            this.ColumnTempoPessoa.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColumnTempoPessoa.FieldName = "tempoporpessoa";
            this.ColumnTempoPessoa.Name = "ColumnTempoPessoa";
            this.ColumnTempoPessoa.Visible = true;
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
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabCloseButtons = false;
            this.tabFormControl1.Size = new System.Drawing.Size(800, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.Click += new System.EventHandler(this.tabFormControl1_Click);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Plantões";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.btnExportar);
            this.tabFormContentContainer1.Controls.Add(this.btnNovo);
            this.tabFormContentContainer1.Controls.Add(this.btnExcluir);
            this.tabFormContentContainer1.Controls.Add(this.btnVoltar);
            this.tabFormContentContainer1.Controls.Add(this.gbxTodosPlatoes);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(800, 395);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportar.ImageOptions.Image = global::SGS.Properties.Resources.Excel24x24;
            this.btnExportar.Location = new System.Drawing.Point(3, 348);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 44);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Excel";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.ImageOptions.Image = global::SGS.Properties.Resources.NovoRegistro24x24;
            this.btnNovo.Location = new System.Drawing.Point(560, 348);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 44);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.ImageOptions.Image = global::SGS.Properties.Resources.ExcluirRegistro24x24;
            this.btnExcluir.Location = new System.Drawing.Point(641, 348);
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
            this.btnVoltar.Location = new System.Drawing.Point(722, 348);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbxTodosPlatoes
            // 
            this.gbxTodosPlatoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTodosPlatoes.Controls.Add(this.gridControl1);
            this.gbxTodosPlatoes.Location = new System.Drawing.Point(3, 6);
            this.gbxTodosPlatoes.Name = "gbxTodosPlatoes";
            this.gbxTodosPlatoes.Size = new System.Drawing.Size(797, 336);
            this.gbxTodosPlatoes.TabIndex = 0;
            this.gbxTodosPlatoes.Text = "Todos";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // v_ControlePlatao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "v_ControlePlatao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Controle de Plantão";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_ControlePlatao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbxTodosPlatoes)).EndInit();
            this.gbxTodosPlatoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl gbxTodosPlatoes;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraEditors.SimpleButton btnExportar;
        private DevExpress.XtraEditors.SimpleButton btnNovo;
        private DevExpress.XtraEditors.SimpleButton btnExcluir;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnIdPlantao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnEquipe;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnDataPlantao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnHoraInicial;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnHoraFinal;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnTempoPessoa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnUsuarioCad;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandCorretores;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnIdCorretorPlantao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnPosicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnNomeCorretor;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnFk_plantao_corretorPlantao;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridbandPlantaoes;
    }
}