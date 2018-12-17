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
            this.gbxCorretores = new DevExpress.XtraEditors.GroupControl();
            this.cbxcCorretores = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).BeginInit();
            this.gbxCorretores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcCorretores.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCorretores
            // 
            this.gbxCorretores.Controls.Add(this.label1);
            this.gbxCorretores.Controls.Add(this.cbxcCorretores);
            this.gbxCorretores.Location = new System.Drawing.Point(12, 12);
            this.gbxCorretores.Name = "gbxCorretores";
            this.gbxCorretores.Size = new System.Drawing.Size(784, 297);
            this.gbxCorretores.TabIndex = 0;
            this.gbxCorretores.Text = "Corretores";
            // 
            // cbxcCorretores
            // 
            this.cbxcCorretores.Location = new System.Drawing.Point(8, 37);
            this.cbxcCorretores.Name = "cbxcCorretores";
            this.cbxcCorretores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxcCorretores.Size = new System.Drawing.Size(358, 20);
            this.cbxcCorretores.TabIndex = 0;
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
            // v_NovoPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 459);
            this.Controls.Add(this.gbxCorretores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_NovoPlantao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Plantão";
            this.Load += new System.EventHandler(this.v_NovoPlantao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxCorretores)).EndInit();
            this.gbxCorretores.ResumeLayout(false);
            this.gbxCorretores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcCorretores.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxCorretores;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxcCorretores;
    }
}