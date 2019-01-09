namespace SGS.Visao
{
    partial class v_NovoPlantao
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
            this.gbxCorretores = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ColumnPosicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColumnCorretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.btnExcluirCorretor = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdicionarCorretor = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxcCorretores = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxTempo = new DevExpress.XtraEditors.GroupControl();
            this.cbxEquipe = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.tseTempoPorPessoa = new DevExpress.XtraEditors.TimeSpanEdit();
            this.btnIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tsePlantaoInicia = new DevExpress.XtraEditors.TimeSpanEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.tsePlantaoTermina = new DevExpress.XtraEditors.TimeSpanEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).BeginInit();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcCorretores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxTempo)).BeginInit();
            this.gbxTempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEquipe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseTempoPorPessoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsePlantaoInicia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsePlantaoTermina.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCorretores
            // 
            this.gbxCorretores.Controls.Add(this.gridControl1);
            this.gbxCorretores.Controls.Add(this.btnExcluirCorretor);
            this.gbxCorretores.Controls.Add(this.btnAdicionarCorretor);
            this.gbxCorretores.Controls.Add(this.label1);
            this.gbxCorretores.Controls.Add(this.cbxcCorretores);
            this.gbxCorretores.Location = new System.Drawing.Point(12, 12);
            this.gbxCorretores.Name = "gbxCorretores";
            this.gbxCorretores.Size = new System.Drawing.Size(526, 268);
            this.gbxCorretores.TabIndex = 0;
            this.gbxCorretores.Text = "Corretores";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 63);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(426, 194);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.TabStop = false;
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
            this.ColumnPosicao,
            this.ColumnCorretor});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Corretores:";
            this.gridBand1.Columns.Add(this.ColumnPosicao);
            this.gridBand1.Columns.Add(this.ColumnCorretor);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 418;
            // 
            // ColumnPosicao
            // 
            this.ColumnPosicao.AppearanceCell.Options.UseTextOptions = true;
            this.ColumnPosicao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPosicao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPosicao.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnPosicao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnPosicao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnPosicao.Caption = "Posição";
            this.ColumnPosicao.FieldName = "posicao";
            this.ColumnPosicao.Name = "ColumnPosicao";
            this.ColumnPosicao.Visible = true;
            this.ColumnPosicao.Width = 62;
            // 
            // ColumnCorretor
            // 
            this.ColumnCorretor.AppearanceHeader.Options.UseTextOptions = true;
            this.ColumnCorretor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColumnCorretor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColumnCorretor.Caption = "Nome Corretor";
            this.ColumnCorretor.FieldName = "corretor";
            this.ColumnCorretor.Name = "ColumnCorretor";
            this.ColumnCorretor.Visible = true;
            this.ColumnCorretor.Width = 356;
            // 
            // btnExcluirCorretor
            // 
            this.btnExcluirCorretor.ImageOptions.Image = global::SGS.Properties.Resources.DeletarPessoa24x24;
            this.btnExcluirCorretor.Location = new System.Drawing.Point(440, 113);
            this.btnExcluirCorretor.Name = "btnExcluirCorretor";
            this.btnExcluirCorretor.Size = new System.Drawing.Size(75, 44);
            this.btnExcluirCorretor.TabIndex = 3;
            this.btnExcluirCorretor.Text = "Excluir";
            this.btnExcluirCorretor.Click += new System.EventHandler(this.btnExcluirCorretor_Click);
            // 
            // btnAdicionarCorretor
            // 
            this.btnAdicionarCorretor.ImageOptions.Image = global::SGS.Properties.Resources.addPessoa24x24;
            this.btnAdicionarCorretor.Location = new System.Drawing.Point(440, 63);
            this.btnAdicionarCorretor.Name = "btnAdicionarCorretor";
            this.btnAdicionarCorretor.Size = new System.Drawing.Size(75, 44);
            this.btnAdicionarCorretor.TabIndex = 2;
            this.btnAdicionarCorretor.Text = "Adicionar";
            this.btnAdicionarCorretor.Click += new System.EventHandler(this.btnAdicionarCorretor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione os Corretores do Plantão:";
            // 
            // cbxcCorretores
            // 
            this.cbxcCorretores.EditValue = "";
            this.cbxcCorretores.Location = new System.Drawing.Point(8, 37);
            this.cbxcCorretores.Name = "cbxcCorretores";
            this.cbxcCorretores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxcCorretores.Size = new System.Drawing.Size(507, 20);
            this.cbxcCorretores.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(463, 366);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // gbxTempo
            // 
            this.gbxTempo.Controls.Add(this.cbxEquipe);
            this.gbxTempo.Controls.Add(this.label5);
            this.gbxTempo.Controls.Add(this.tseTempoPorPessoa);
            this.gbxTempo.Controls.Add(this.btnIniciar);
            this.gbxTempo.Controls.Add(this.label4);
            this.gbxTempo.Controls.Add(this.tsePlantaoInicia);
            this.gbxTempo.Controls.Add(this.label3);
            this.gbxTempo.Controls.Add(this.tsePlantaoTermina);
            this.gbxTempo.Controls.Add(this.label2);
            this.gbxTempo.Location = new System.Drawing.Point(12, 286);
            this.gbxTempo.Name = "gbxTempo";
            this.gbxTempo.Size = new System.Drawing.Size(526, 74);
            this.gbxTempo.TabIndex = 3;
            this.gbxTempo.Text = "Tempo/Equipe";
            // 
            // cbxEquipe
            // 
            this.cbxEquipe.Location = new System.Drawing.Point(335, 37);
            this.cbxEquipe.Name = "cbxEquipe";
            this.cbxEquipe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEquipe.Properties.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbxEquipe.Size = new System.Drawing.Size(42, 20);
            this.cbxEquipe.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Equipe:";
            // 
            // tseTempoPorPessoa
            // 
            this.tseTempoPorPessoa.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tseTempoPorPessoa.Location = new System.Drawing.Point(226, 37);
            this.tseTempoPorPessoa.Name = "tseTempoPorPessoa";
            this.tseTempoPorPessoa.Properties.AllowEditDays = false;
            this.tseTempoPorPessoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tseTempoPorPessoa.Properties.Mask.EditMask = "HH:mm:ss";
            this.tseTempoPorPessoa.Size = new System.Drawing.Size(103, 20);
            this.tseTempoPorPessoa.TabIndex = 6;
            // 
            // btnIniciar
            // 
            this.btnIniciar.ImageOptions.Image = global::SGS.Properties.Resources.PlayMostrarTV24x24;
            this.btnIniciar.Location = new System.Drawing.Point(386, 20);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(129, 44);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Salvar e Iniciar";
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plantão Termina as:";
            // 
            // tsePlantaoInicia
            // 
            this.tsePlantaoInicia.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tsePlantaoInicia.Location = new System.Drawing.Point(8, 38);
            this.tsePlantaoInicia.Name = "tsePlantaoInicia";
            this.tsePlantaoInicia.Properties.AllowEditDays = false;
            this.tsePlantaoInicia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tsePlantaoInicia.Properties.Mask.EditMask = "HH:mm:ss";
            this.tsePlantaoInicia.Size = new System.Drawing.Size(103, 20);
            this.tsePlantaoInicia.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plantão Inicia as:";
            // 
            // tsePlantaoTermina
            // 
            this.tsePlantaoTermina.EditValue = System.TimeSpan.Parse("00:00:00");
            this.tsePlantaoTermina.Location = new System.Drawing.Point(117, 38);
            this.tsePlantaoTermina.Name = "tsePlantaoTermina";
            this.tsePlantaoTermina.Properties.AllowEditDays = false;
            this.tsePlantaoTermina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tsePlantaoTermina.Properties.Mask.EditMask = "HH:mm:ss";
            this.tsePlantaoTermina.Size = new System.Drawing.Size(103, 20);
            this.tsePlantaoTermina.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tempo por Pessoa:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // v_NovoPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 416);
            this.Controls.Add(this.gbxTempo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gbxCorretores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_NovoPlantao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Plantão";
            this.Load += new System.EventHandler(this.v_NovoPlantao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).EndInit();
            this.gbxCorretores.ResumeLayout(false);
            this.gbxCorretores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcCorretores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxTempo)).EndInit();
            this.gbxTempo.ResumeLayout(false);
            this.gbxTempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEquipe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tseTempoPorPessoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsePlantaoInicia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsePlantaoTermina.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxCorretores;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxcCorretores;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarCorretor;
        private DevExpress.XtraEditors.SimpleButton btnExcluirCorretor;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnIniciar;
        private DevExpress.XtraEditors.GroupControl gbxTempo;
        private DevExpress.XtraEditors.TimeSpanEdit tsePlantaoTermina;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TimeSpanEdit tseTempoPorPessoa;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TimeSpanEdit tsePlantaoInicia;
        private System.Windows.Forms.Label label3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnPosicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColumnCorretor;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEquipe;
        private System.Windows.Forms.Label label5;
    }
}