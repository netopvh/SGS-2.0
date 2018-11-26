namespace SGS.Visao
{
    partial class v_NovaDistribuicaoContrato
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
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEditCorretor = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.lookUpEditEmpreendimento = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalContratos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSqcFinal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSqcInicial = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataDistribuicao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpreendimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqcFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqcInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Corretor:";
            // 
            // lookUpEditCorretor
            // 
            this.lookUpEditCorretor.Location = new System.Drawing.Point(15, 25);
            this.lookUpEditCorretor.Name = "lookUpEditCorretor";
            this.lookUpEditCorretor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCorretor.Properties.NullText = "";
            this.lookUpEditCorretor.Size = new System.Drawing.Size(357, 20);
            this.lookUpEditCorretor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empreendimento:";
            // 
            // lookUpEditEmpreendimento
            // 
            this.lookUpEditEmpreendimento.Location = new System.Drawing.Point(15, 64);
            this.lookUpEditEmpreendimento.Name = "lookUpEditEmpreendimento";
            this.lookUpEditEmpreendimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEmpreendimento.Properties.NullText = "";
            this.lookUpEditEmpreendimento.Size = new System.Drawing.Size(357, 20);
            this.lookUpEditEmpreendimento.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblTotalContratos);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtSqcFinal);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtSqcInicial);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Location = new System.Drawing.Point(15, 117);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 76);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Informe a sequencia";
            // 
            // lblTotalContratos
            // 
            this.lblTotalContratos.AutoSize = true;
            this.lblTotalContratos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContratos.ForeColor = System.Drawing.Color.Red;
            this.lblTotalContratos.Location = new System.Drawing.Point(46, 56);
            this.lblTotalContratos.Name = "lblTotalContratos";
            this.lblTotalContratos.Size = new System.Drawing.Size(14, 13);
            this.lblTotalContratos.TabIndex = 14;
            this.lblTotalContratos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            // 
            // txtSqcFinal
            // 
            this.txtSqcFinal.Location = new System.Drawing.Point(226, 24);
            this.txtSqcFinal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtSqcFinal.Name = "txtSqcFinal";
            this.txtSqcFinal.Size = new System.Drawing.Size(126, 21);
            this.txtSqcFinal.TabIndex = 5;
            this.txtSqcFinal.ValueChanged += new System.EventHandler(this.txtSqcFinal_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Final:";
            // 
            // txtSqcInicial
            // 
            this.txtSqcInicial.Location = new System.Drawing.Point(49, 24);
            this.txtSqcInicial.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtSqcInicial.Name = "txtSqcInicial";
            this.txtSqcInicial.Size = new System.Drawing.Size(126, 21);
            this.txtSqcInicial.TabIndex = 4;
            this.txtSqcInicial.ValueChanged += new System.EventHandler(this.txtSqcInicial_ValueChanged);
            this.txtSqcInicial.Enter += new System.EventHandler(this.txtSqcInicial_Enter);
            this.txtSqcInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSqcInicial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inicial:";
            // 
            // dtpDataDistribuicao
            // 
            this.dtpDataDistribuicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDistribuicao.Location = new System.Drawing.Point(110, 90);
            this.dtpDataDistribuicao.Name = "dtpDataDistribuicao";
            this.dtpDataDistribuicao.Size = new System.Drawing.Size(102, 21);
            this.dtpDataDistribuicao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Distribuição:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(297, 199);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(216, 199);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // v_NovaDistribuicaoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataDistribuicao);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lookUpEditEmpreendimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lookUpEditCorretor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_NovaDistribuicaoContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribuir contratos";
            this.Load += new System.EventHandler(this.v_NovaDistribuicaoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpreendimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqcFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSqcInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCorretor;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEmpreendimento;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpDataDistribuicao;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.Label lblTotalContratos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtSqcFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtSqcInicial;
        private System.Windows.Forms.Label label4;
    }
}