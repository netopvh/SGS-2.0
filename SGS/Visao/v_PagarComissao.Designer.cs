namespace SGS.Visao
{
    partial class v_PagarComissao
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
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.btnReferenciarNF = new DevExpress.XtraEditors.SimpleButton();
            this.btnPagar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorretor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorComissoParcela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a Data de pagamento:";
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Location = new System.Drawing.Point(16, 125);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(276, 21);
            this.dtpDataPagamento.TabIndex = 1;
            // 
            // btnReferenciarNF
            // 
            this.btnReferenciarNF.ImageOptions.Image = global::SGS.Properties.Resources.NF24x24;
            this.btnReferenciarNF.Location = new System.Drawing.Point(16, 152);
            this.btnReferenciarNF.Name = "btnReferenciarNF";
            this.btnReferenciarNF.Size = new System.Drawing.Size(115, 44);
            this.btnReferenciarNF.TabIndex = 4;
            this.btnReferenciarNF.Text = "Referenciar NF";
            this.btnReferenciarNF.Click += new System.EventHandler(this.btnReferenciarNF_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.ImageOptions.Image = global::SGS.Properties.Resources.APagar24x24;
            this.btnPagar.Location = new System.Drawing.Point(137, 152);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 44);
            this.btnPagar.TabIndex = 3;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(217, 152);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Corretor:";
            // 
            // lblCorretor
            // 
            this.lblCorretor.AutoSize = true;
            this.lblCorretor.Location = new System.Drawing.Point(13, 34);
            this.lblCorretor.Name = "lblCorretor";
            this.lblCorretor.Size = new System.Drawing.Size(48, 13);
            this.lblCorretor.TabIndex = 6;
            this.lblCorretor.Text = "Corretor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor/Parcela:";
            // 
            // lblValorComissoParcela
            // 
            this.lblValorComissoParcela.AutoSize = true;
            this.lblValorComissoParcela.Location = new System.Drawing.Point(13, 84);
            this.lblValorComissoParcela.Name = "lblValorComissoParcela";
            this.lblValorComissoParcela.Size = new System.Drawing.Size(70, 13);
            this.lblValorComissoParcela.TabIndex = 8;
            this.lblValorComissoParcela.Text = "Valor/Parcela";
            // 
            // v_PagarComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 210);
            this.Controls.Add(this.lblValorComissoParcela);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCorretor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReferenciarNF);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_PagarComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagar Comissão";
            this.Load += new System.EventHandler(this.v_PagarComissao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnPagar;
        private DevExpress.XtraEditors.SimpleButton btnReferenciarNF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorretor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValorComissoParcela;
    }
}