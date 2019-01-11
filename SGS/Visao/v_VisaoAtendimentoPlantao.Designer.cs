namespace SGS.Visao
{
    partial class v_VisaoAtendimentoPlantao
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
            this.gbxLogoHora = new System.Windows.Forms.GroupBox();
            this.lblDataDoDia = new System.Windows.Forms.Label();
            this.lblHoraCerta = new System.Windows.Forms.Label();
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.gbxCorretores = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.posicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.corretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.idcorretorplantao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbxVideo = new System.Windows.Forms.GroupBox();
            this.pictureBoxSlider = new System.Windows.Forms.PictureBox();
            this.gbxTempoCorretor = new System.Windows.Forms.GroupBox();
            this.lblCorretorDaVez = new System.Windows.Forms.Label();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblCorretor = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timerDataHoraCerta = new System.Windows.Forms.Timer(this.components);
            this.timerTempoPorPessoa = new System.Windows.Forms.Timer(this.components);
            this.timerSliderImagens = new System.Windows.Forms.Timer(this.components);
            this.gbxLogoHora.SuspendLayout();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.gbxVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).BeginInit();
            this.gbxTempoCorretor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogoHora
            // 
            this.gbxLogoHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLogoHora.BackColor = System.Drawing.Color.White;
            this.gbxLogoHora.Controls.Add(this.lblDataDoDia);
            this.gbxLogoHora.Controls.Add(this.lblHoraCerta);
            this.gbxLogoHora.Controls.Add(this.lblSejaBemVindo);
            this.gbxLogoHora.Location = new System.Drawing.Point(12, 0);
            this.gbxLogoHora.Name = "gbxLogoHora";
            this.gbxLogoHora.Size = new System.Drawing.Size(1125, 91);
            this.gbxLogoHora.TabIndex = 0;
            this.gbxLogoHora.TabStop = false;
            // 
            // lblDataDoDia
            // 
            this.lblDataDoDia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataDoDia.AutoSize = true;
            this.lblDataDoDia.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDoDia.ForeColor = System.Drawing.Color.Black;
            this.lblDataDoDia.Location = new System.Drawing.Point(711, 27);
            this.lblDataDoDia.Name = "lblDataDoDia";
            this.lblDataDoDia.Size = new System.Drawing.Size(234, 42);
            this.lblDataDoDia.TabIndex = 3;
            this.lblDataDoDia.Text = "31/12/9999";
            // 
            // lblHoraCerta
            // 
            this.lblHoraCerta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHoraCerta.AutoSize = true;
            this.lblHoraCerta.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCerta.ForeColor = System.Drawing.Color.Green;
            this.lblHoraCerta.Location = new System.Drawing.Point(943, 27);
            this.lblHoraCerta.Name = "lblHoraCerta";
            this.lblHoraCerta.Size = new System.Drawing.Size(176, 42);
            this.lblHoraCerta.TabIndex = 2;
            this.lblHoraCerta.Text = "60:60:60";
            this.lblHoraCerta.TextChanged += new System.EventHandler(this.lblDataHoraCerta_TextChanged);
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSejaBemVindo.ForeColor = System.Drawing.Color.Black;
            this.lblSejaBemVindo.Location = new System.Drawing.Point(6, 27);
            this.lblSejaBemVindo.Name = "lblSejaBemVindo";
            this.lblSejaBemVindo.Size = new System.Drawing.Size(294, 42);
            this.lblSejaBemVindo.TabIndex = 1;
            this.lblSejaBemVindo.Text = "Seja Bem Vindo";
            this.lblSejaBemVindo.Click += new System.EventHandler(this.lblSejaBemVindo_Click);
            // 
            // gbxCorretores
            // 
            this.gbxCorretores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCorretores.BackColor = System.Drawing.Color.White;
            this.gbxCorretores.Controls.Add(this.gridControl1);
            this.gbxCorretores.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCorretores.Location = new System.Drawing.Point(880, 97);
            this.gbxCorretores.Name = "gbxCorretores";
            this.gbxCorretores.Size = new System.Drawing.Size(257, 322);
            this.gbxCorretores.TabIndex = 1;
            this.gbxCorretores.TabStop = false;
            this.gbxCorretores.Text = "Corretores";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
            this.gridControl1.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(3, 26);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(251, 293);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.TabStop = false;
            this.gridControl1.UseDisabledStatePainter = false;
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
            this.idcorretorplantao,
            this.posicao,
            this.corretor});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Todos do Plantão";
            this.gridBand1.Columns.Add(this.posicao);
            this.gridBand1.Columns.Add(this.corretor);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 265;
            // 
            // posicao
            // 
            this.posicao.AppearanceCell.Options.UseTextOptions = true;
            this.posicao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.posicao.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.posicao.AppearanceHeader.Options.UseTextOptions = true;
            this.posicao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.posicao.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.posicao.Caption = "Posição";
            this.posicao.FieldName = "posicao";
            this.posicao.Name = "posicao";
            this.posicao.Visible = true;
            this.posicao.Width = 44;
            // 
            // corretor
            // 
            this.corretor.AppearanceHeader.Options.UseTextOptions = true;
            this.corretor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.corretor.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.corretor.Caption = "Nome";
            this.corretor.FieldName = "nomecorretor";
            this.corretor.Name = "corretor";
            this.corretor.Visible = true;
            this.corretor.Width = 221;
            // 
            // idcorretorplantao
            // 
            this.idcorretorplantao.Caption = "Código";
            this.idcorretorplantao.FieldName = "idcorretorplantao";
            this.idcorretorplantao.Name = "idcorretorplantao";
            // 
            // gbxVideo
            // 
            this.gbxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxVideo.BackColor = System.Drawing.Color.White;
            this.gbxVideo.Controls.Add(this.pictureBoxSlider);
            this.gbxVideo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVideo.Location = new System.Drawing.Point(12, 97);
            this.gbxVideo.Name = "gbxVideo";
            this.gbxVideo.Size = new System.Drawing.Size(862, 322);
            this.gbxVideo.TabIndex = 2;
            this.gbxVideo.TabStop = false;
            // 
            // pictureBoxSlider
            // 
            this.pictureBoxSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSlider.Location = new System.Drawing.Point(3, 26);
            this.pictureBoxSlider.Name = "pictureBoxSlider";
            this.pictureBoxSlider.Size = new System.Drawing.Size(856, 293);
            this.pictureBoxSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlider.TabIndex = 0;
            this.pictureBoxSlider.TabStop = false;
            // 
            // gbxTempoCorretor
            // 
            this.gbxTempoCorretor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTempoCorretor.BackColor = System.Drawing.Color.White;
            this.gbxTempoCorretor.Controls.Add(this.lblCorretorDaVez);
            this.gbxTempoCorretor.Controls.Add(this.lblTempoRestante);
            this.gbxTempoCorretor.Controls.Add(this.lblTempo);
            this.gbxTempoCorretor.Controls.Add(this.lblCorretor);
            this.gbxTempoCorretor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTempoCorretor.Location = new System.Drawing.Point(12, 425);
            this.gbxTempoCorretor.Name = "gbxTempoCorretor";
            this.gbxTempoCorretor.Size = new System.Drawing.Size(1125, 79);
            this.gbxTempoCorretor.TabIndex = 3;
            this.gbxTempoCorretor.TabStop = false;
            // 
            // lblCorretorDaVez
            // 
            this.lblCorretorDaVez.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCorretorDaVez.AutoSize = true;
            this.lblCorretorDaVez.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretorDaVez.ForeColor = System.Drawing.Color.Red;
            this.lblCorretorDaVez.Location = new System.Drawing.Point(132, 26);
            this.lblCorretorDaVez.Name = "lblCorretorDaVez";
            this.lblCorretorDaVez.Size = new System.Drawing.Size(330, 42);
            this.lblCorretorDaVez.TabIndex = 5;
            this.lblCorretorDaVez.Text = "NOME CORRETOR";
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTempoRestante.AutoSize = true;
            this.lblTempoRestante.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoRestante.ForeColor = System.Drawing.Color.Red;
            this.lblTempoRestante.Location = new System.Drawing.Point(943, 26);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(176, 42);
            this.lblTempoRestante.TabIndex = 3;
            this.lblTempoRestante.Text = "00:00:00";
            this.lblTempoRestante.TextChanged += new System.EventHandler(this.lblTempoRestante_TextChanged);
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Black;
            this.lblTempo.Location = new System.Drawing.Point(795, 26);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(150, 42);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "Tempo:";
            // 
            // lblCorretor
            // 
            this.lblCorretor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCorretor.AutoSize = true;
            this.lblCorretor.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretor.ForeColor = System.Drawing.Color.Black;
            this.lblCorretor.Location = new System.Drawing.Point(6, 26);
            this.lblCorretor.Name = "lblCorretor";
            this.lblCorretor.Size = new System.Drawing.Size(134, 42);
            this.lblCorretor.TabIndex = 3;
            this.lblCorretor.Text = "Nome:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // timerDataHoraCerta
            // 
            this.timerDataHoraCerta.Enabled = true;
            this.timerDataHoraCerta.Interval = 1000;
            this.timerDataHoraCerta.Tick += new System.EventHandler(this.timerHoraCerta_Tick);
            // 
            // timerTempoPorPessoa
            // 
            this.timerTempoPorPessoa.Enabled = true;
            this.timerTempoPorPessoa.Interval = 1000;
            this.timerTempoPorPessoa.Tick += new System.EventHandler(this.timerTempoPorPessoa_Tick);
            // 
            // timerSliderImagens
            // 
            this.timerSliderImagens.Enabled = true;
            this.timerSliderImagens.Interval = 15000;
            this.timerSliderImagens.Tick += new System.EventHandler(this.timerSliderImagens_Tick);
            // 
            // v_VisaoAtendimentoPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 516);
            this.Controls.Add(this.gbxTempoCorretor);
            this.Controls.Add(this.gbxVideo);
            this.Controls.Add(this.gbxCorretores);
            this.Controls.Add(this.gbxLogoHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "v_VisaoAtendimentoPlantao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.v_VisaoAtendimentoPlantao_Load);
            this.gbxLogoHora.ResumeLayout(false);
            this.gbxLogoHora.PerformLayout();
            this.gbxCorretores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.gbxVideo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlider)).EndInit();
            this.gbxTempoCorretor.ResumeLayout(false);
            this.gbxTempoCorretor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogoHora;
        private System.Windows.Forms.GroupBox gbxCorretores;
        private System.Windows.Forms.GroupBox gbxVideo;
        private System.Windows.Forms.GroupBox gbxTempoCorretor;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label lblSejaBemVindo;
        private System.Windows.Forms.Label lblHoraCerta;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblCorretor;
        private System.Windows.Forms.Label lblCorretorDaVez;
        private System.Windows.Forms.Timer timerDataHoraCerta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn posicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn corretor;
        private System.Windows.Forms.Timer timerTempoPorPessoa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn idcorretorplantao;
        private System.Windows.Forms.Label lblDataDoDia;
        private System.Windows.Forms.PictureBox pictureBoxSlider;
        private System.Windows.Forms.Timer timerSliderImagens;
    }
}