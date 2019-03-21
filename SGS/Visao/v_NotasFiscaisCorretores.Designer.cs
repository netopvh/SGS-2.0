namespace SGS.Visao
{
    partial class v_NotasFiscaisCorretores
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
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.ColunaCodigoNota = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaNumeroNota = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaDataCad = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ColunaNotaFiscalAnexo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(474, 55);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Notas";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.gridControl1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 55);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(474, 395);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(474, 322);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.ColunaCodigoNota,
            this.ColunaNumeroNota,
            this.ColunaDataCad,
            this.ColunaNotaFiscalAnexo});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            // 
            // ColunaCodigoNota
            // 
            this.ColunaCodigoNota.Caption = "Código";
            this.ColunaCodigoNota.Name = "ColunaCodigoNota";
            this.ColunaCodigoNota.Visible = true;
            this.ColunaCodigoNota.Width = 52;
            // 
            // ColunaNumeroNota
            // 
            this.ColunaNumeroNota.Caption = "Número NF";
            this.ColunaNumeroNota.Name = "ColunaNumeroNota";
            this.ColunaNumeroNota.Visible = true;
            this.ColunaNumeroNota.Width = 170;
            // 
            // ColunaDataCad
            // 
            this.ColunaDataCad.Caption = "Data Cad.";
            this.ColunaDataCad.Name = "ColunaDataCad";
            this.ColunaDataCad.Visible = true;
            this.ColunaDataCad.Width = 102;
            // 
            // ColunaNotaFiscalAnexo
            // 
            this.ColunaNotaFiscalAnexo.Caption = "NF Anexo";
            this.ColunaNotaFiscalAnexo.Name = "ColunaNotaFiscalAnexo";
            this.ColunaNotaFiscalAnexo.Visible = true;
            this.ColunaNotaFiscalAnexo.Width = 119;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Todas";
            this.gridBand1.Columns.Add(this.ColunaCodigoNota);
            this.gridBand1.Columns.Add(this.ColunaNumeroNota);
            this.gridBand1.Columns.Add(this.ColunaDataCad);
            this.gridBand1.Columns.Add(this.ColunaNotaFiscalAnexo);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 443;
            // 
            // v_NotasFiscaisCorretores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "v_NotasFiscaisCorretores";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Notas Fiscais Corretores";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaCodigoNota;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaNumeroNota;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaDataCad;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ColunaNotaFiscalAnexo;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}