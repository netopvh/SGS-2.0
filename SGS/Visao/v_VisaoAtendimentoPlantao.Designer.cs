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
            this.lblDataHoraCerta = new System.Windows.Forms.Label();
            this.lblSejaBemVindo = new System.Windows.Forms.Label();
            this.gbxCorretores = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.posicao = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.corretor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gbxVideo = new System.Windows.Forms.GroupBox();
            this.gbxTempoCorretor = new System.Windows.Forms.GroupBox();
            this.lblCorretorDaVez = new System.Windows.Forms.Label();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timerDataHoraCerta = new System.Windows.Forms.Timer(this.components);
            this.timerTempoPorPessoa = new System.Windows.Forms.Timer(this.components);
            this.gbxLogoHora.SuspendLayout();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.gbxTempoCorretor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogoHora
            // 
            this.gbxLogoHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLogoHora.BackColor = System.Drawing.Color.White;
            this.gbxLogoHora.Controls.Add(this.lblDataHoraCerta);
            this.gbxLogoHora.Controls.Add(this.lblSejaBemVindo);
            this.gbxLogoHora.Location = new System.Drawing.Point(12, 0);
            this.gbxLogoHora.Name = "gbxLogoHora";
            this.gbxLogoHora.Size = new System.Drawing.Size(1125, 91);
            this.gbxLogoHora.TabIndex = 0;
            this.gbxLogoHora.TabStop = false;
            // 
            // lblDataHoraCerta
            // 
            this.lblDataHoraCerta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataHoraCerta.AutoSize = true;
            this.lblDataHoraCerta.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataHoraCerta.ForeColor = System.Drawing.Color.Green;
            this.lblDataHoraCerta.Location = new System.Drawing.Point(717, 27);
            this.lblDataHoraCerta.Name = "lblDataHoraCerta";
            this.lblDataHoraCerta.Size = new System.Drawing.Size(402, 42);
            this.lblDataHoraCerta.TabIndex = 2;
            this.lblDataHoraCerta.Text = "31/12/9999 60:60:60";
            // 
            // lblSejaBemVindo
            // 
            this.lblSejaBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSejaBemVindo.AutoSize = true;
            this.lblSejaBemVindo.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.gridControl1.Location = new System.Drawing.Point(3, 26);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(251, 293);
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
            // gbxVideo
            // 
            this.gbxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxVideo.BackColor = System.Drawing.Color.White;
            this.gbxVideo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVideo.Location = new System.Drawing.Point(12, 97);
            this.gbxVideo.Name = "gbxVideo";
            this.gbxVideo.Size = new System.Drawing.Size(862, 322);
            this.gbxVideo.TabIndex = 2;
            this.gbxVideo.TabStop = false;
            this.gbxVideo.Text = "TV";
            // 
            // gbxTempoCorretor
            // 
            this.gbxTempoCorretor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTempoCorretor.BackColor = System.Drawing.Color.White;
            this.gbxTempoCorretor.Controls.Add(this.lblCorretorDaVez);
            this.gbxTempoCorretor.Controls.Add(this.lblTempoRestante);
            this.gbxTempoCorretor.Controls.Add(this.label2);
            this.gbxTempoCorretor.Controls.Add(this.label1);
            this.gbxTempoCorretor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTempoCorretor.Location = new System.Drawing.Point(12, 425);
            this.gbxTempoCorretor.Name = "gbxTempoCorretor";
            this.gbxTempoCorretor.Size = new System.Drawing.Size(1125, 79);
            this.gbxTempoCorretor.TabIndex = 3;
            this.gbxTempoCorretor.TabStop = false;
            this.gbxTempoCorretor.Text = "Tempo";
            // 
            // lblCorretorDaVez
            // 
            this.lblCorretorDaVez.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCorretorDaVez.AutoSize = true;
            this.lblCorretorDaVez.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretorDaVez.ForeColor = System.Drawing.Color.Red;
            this.lblCorretorDaVez.Location = new System.Drawing.Point(313, 26);
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
            this.lblTempoRestante.Location = new System.Drawing.Point(983, 26);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(119, 42);
            this.lblTempoRestante.TabIndex = 3;
            this.lblTempoRestante.Text = "00:00";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tempo Restante:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Corretor da vez:";
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
        private System.Windows.Forms.Label lblDataHoraCerta;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorretorDaVez;
        private System.Windows.Forms.Timer timerDataHoraCerta;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn posicao;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn corretor;
        private System.Windows.Forms.Timer timerTempoPorPessoa;
    }
}