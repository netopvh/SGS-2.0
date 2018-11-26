namespace SGS.Visao
{
    partial class v_AjustarComissao
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
            this.cbxEstruturaComissao = new DevExpress.XtraEditors.LookUpEdit();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.gbxEstruturasComissoes = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorcSinal = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxPorcValores = new DevExpress.XtraEditors.GroupControl();
            this.lblSomaImobCorretor = new System.Windows.Forms.Label();
            this.lblValorParcela = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblValorSinal = new System.Windows.Forms.Label();
            this.lblValorLote = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblValorCorretor = new System.Windows.Forms.Label();
            this.lblValorImob = new System.Windows.Forms.Label();
            this.lblPorcCorretor = new System.Windows.Forms.Label();
            this.lblPorcImob = new System.Windows.Forms.Label();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblQtdParcSinal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblValorParcelaSinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstruturaComissao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEstruturasComissoes)).BeginInit();
            this.gbxEstruturasComissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcSinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxPorcValores)).BeginInit();
            this.gbxPorcValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "% Imobiliária:";
            // 
            // cbxEstruturaComissao
            // 
            this.cbxEstruturaComissao.Location = new System.Drawing.Point(5, 24);
            this.cbxEstruturaComissao.Name = "cbxEstruturaComissao";
            this.cbxEstruturaComissao.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstruturaComissao.Properties.NullText = "Selecione o modelo de Comissão - Estruturas";
            this.cbxEstruturaComissao.Properties.EditValueChanged += new System.EventHandler(this.cbxEstruturaComissao_Properties_EditValueChanged);
            this.cbxEstruturaComissao.Size = new System.Drawing.Size(454, 20);
            this.cbxEstruturaComissao.TabIndex = 1;
            this.cbxEstruturaComissao.EditValueChanged += new System.EventHandler(this.cbxEstruturaComissao_EditValueChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(521, 196);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            // 
            // gbxEstruturasComissoes
            // 
            this.gbxEstruturasComissoes.Controls.Add(this.lblValorParcelaSinal);
            this.gbxEstruturasComissoes.Controls.Add(this.label11);
            this.gbxEstruturasComissoes.Controls.Add(this.lblQtdParcSinal);
            this.gbxEstruturasComissoes.Controls.Add(this.label8);
            this.gbxEstruturasComissoes.Controls.Add(this.label5);
            this.gbxEstruturasComissoes.Controls.Add(this.txtPorcSinal);
            this.gbxEstruturasComissoes.Controls.Add(this.cbxEstruturaComissao);
            this.gbxEstruturasComissoes.Controls.Add(this.label9);
            this.gbxEstruturasComissoes.Controls.Add(this.lblValorSinal);
            this.gbxEstruturasComissoes.Controls.Add(this.lblValorLote);
            this.gbxEstruturasComissoes.Controls.Add(this.label10);
            this.gbxEstruturasComissoes.Location = new System.Drawing.Point(12, 12);
            this.gbxEstruturasComissoes.Name = "gbxEstruturasComissoes";
            this.gbxEstruturasComissoes.Size = new System.Drawing.Size(584, 80);
            this.gbxEstruturasComissoes.TabIndex = 3;
            this.gbxEstruturasComissoes.Text = "Estruturas Comissões";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "%Sinal:";
            // 
            // txtPorcSinal
            // 
            this.txtPorcSinal.EditValue = "0";
            this.txtPorcSinal.Location = new System.Drawing.Point(515, 24);
            this.txtPorcSinal.Name = "txtPorcSinal";
            this.txtPorcSinal.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPorcSinal.Properties.Appearance.Options.UseForeColor = true;
            this.txtPorcSinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcSinal.Properties.Mask.EditMask = "n";
            this.txtPorcSinal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcSinal.Properties.EditValueChanged += new System.EventHandler(this.txtPorcSinal_Properties_EditValueChanged);
            this.txtPorcSinal.Size = new System.Drawing.Size(64, 20);
            this.txtPorcSinal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor Corretor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Imobiliária:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "% Corretor:";
            // 
            // gbxPorcValores
            // 
            this.gbxPorcValores.Controls.Add(this.lblSomaImobCorretor);
            this.gbxPorcValores.Controls.Add(this.lblValorParcela);
            this.gbxPorcValores.Controls.Add(this.label7);
            this.gbxPorcValores.Controls.Add(this.label6);
            this.gbxPorcValores.Controls.Add(this.lblValorCorretor);
            this.gbxPorcValores.Controls.Add(this.lblValorImob);
            this.gbxPorcValores.Controls.Add(this.lblPorcCorretor);
            this.gbxPorcValores.Controls.Add(this.lblPorcImob);
            this.gbxPorcValores.Controls.Add(this.label1);
            this.gbxPorcValores.Controls.Add(this.label4);
            this.gbxPorcValores.Controls.Add(this.label3);
            this.gbxPorcValores.Controls.Add(this.label2);
            this.gbxPorcValores.Location = new System.Drawing.Point(12, 98);
            this.gbxPorcValores.Name = "gbxPorcValores";
            this.gbxPorcValores.Size = new System.Drawing.Size(584, 94);
            this.gbxPorcValores.TabIndex = 5;
            this.gbxPorcValores.Text = "Porcentagens/Valores";
            // 
            // lblSomaImobCorretor
            // 
            this.lblSomaImobCorretor.AutoSize = true;
            this.lblSomaImobCorretor.Location = new System.Drawing.Point(405, 69);
            this.lblSomaImobCorretor.Name = "lblSomaImobCorretor";
            this.lblSomaImobCorretor.Size = new System.Drawing.Size(13, 13);
            this.lblSomaImobCorretor.TabIndex = 16;
            this.lblSomaImobCorretor.Text = "0";
            // 
            // lblValorParcela
            // 
            this.lblValorParcela.AutoSize = true;
            this.lblValorParcela.Location = new System.Drawing.Point(84, 69);
            this.lblValorParcela.Name = "lblValorParcela";
            this.lblValorParcela.Size = new System.Drawing.Size(13, 13);
            this.lblValorParcela.TabIndex = 15;
            this.lblValorParcela.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Imob+Corretor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Valor Parcela:";
            // 
            // lblValorSinal
            // 
            this.lblValorSinal.AutoSize = true;
            this.lblValorSinal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorSinal.Location = new System.Drawing.Point(212, 58);
            this.lblValorSinal.Name = "lblValorSinal";
            this.lblValorSinal.Size = new System.Drawing.Size(13, 13);
            this.lblValorSinal.TabIndex = 12;
            this.lblValorSinal.Text = "0";
            // 
            // lblValorLote
            // 
            this.lblValorLote.AutoSize = true;
            this.lblValorLote.ForeColor = System.Drawing.Color.Blue;
            this.lblValorLote.Location = new System.Drawing.Point(67, 58);
            this.lblValorLote.Name = "lblValorLote";
            this.lblValorLote.Size = new System.Drawing.Size(13, 13);
            this.lblValorLote.TabIndex = 11;
            this.lblValorLote.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Sinal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Valor lote:";
            // 
            // lblValorCorretor
            // 
            this.lblValorCorretor.AutoSize = true;
            this.lblValorCorretor.ForeColor = System.Drawing.Color.Blue;
            this.lblValorCorretor.Location = new System.Drawing.Point(405, 45);
            this.lblValorCorretor.Name = "lblValorCorretor";
            this.lblValorCorretor.Size = new System.Drawing.Size(13, 13);
            this.lblValorCorretor.TabIndex = 8;
            this.lblValorCorretor.Text = "0";
            // 
            // lblValorImob
            // 
            this.lblValorImob.AutoSize = true;
            this.lblValorImob.ForeColor = System.Drawing.Color.Blue;
            this.lblValorImob.Location = new System.Drawing.Point(405, 21);
            this.lblValorImob.Name = "lblValorImob";
            this.lblValorImob.Size = new System.Drawing.Size(13, 13);
            this.lblValorImob.TabIndex = 7;
            this.lblValorImob.Text = "0";
            // 
            // lblPorcCorretor
            // 
            this.lblPorcCorretor.AutoSize = true;
            this.lblPorcCorretor.Location = new System.Drawing.Point(84, 45);
            this.lblPorcCorretor.Name = "lblPorcCorretor";
            this.lblPorcCorretor.Size = new System.Drawing.Size(13, 13);
            this.lblPorcCorretor.TabIndex = 6;
            this.lblPorcCorretor.Text = "0";
            // 
            // lblPorcImob
            // 
            this.lblPorcImob.AutoSize = true;
            this.lblPorcImob.Location = new System.Drawing.Point(84, 21);
            this.lblPorcImob.Name = "lblPorcImob";
            this.lblPorcImob.Size = new System.Drawing.Size(13, 13);
            this.lblPorcImob.TabIndex = 5;
            this.lblPorcImob.Text = "0";
            // 
            // btnAplicar
            // 
            this.btnAplicar.ImageOptions.Image = global::SGS.Properties.Resources.AjusteComissao24x24;
            this.btnAplicar.Location = new System.Drawing.Point(440, 196);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 44);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "QtdPacSinal:";
            // 
            // lblQtdParcSinal
            // 
            this.lblQtdParcSinal.AutoSize = true;
            this.lblQtdParcSinal.ForeColor = System.Drawing.Color.Blue;
            this.lblQtdParcSinal.Location = new System.Drawing.Point(374, 58);
            this.lblQtdParcSinal.Name = "lblQtdParcSinal";
            this.lblQtdParcSinal.Size = new System.Drawing.Size(13, 13);
            this.lblQtdParcSinal.TabIndex = 14;
            this.lblQtdParcSinal.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Valor Parcela Sinal:";
            // 
            // lblValorParcelaSinal
            // 
            this.lblValorParcelaSinal.AutoSize = true;
            this.lblValorParcelaSinal.ForeColor = System.Drawing.Color.Blue;
            this.lblValorParcelaSinal.Location = new System.Drawing.Point(509, 58);
            this.lblValorParcelaSinal.Name = "lblValorParcelaSinal";
            this.lblValorParcelaSinal.Size = new System.Drawing.Size(13, 13);
            this.lblValorParcelaSinal.TabIndex = 16;
            this.lblValorParcelaSinal.Text = "0";
            // 
            // v_AjustarComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 250);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.gbxPorcValores);
            this.Controls.Add(this.gbxEstruturasComissoes);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_AjustarComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustar Comissão";
            this.Load += new System.EventHandler(this.v_AjustarComissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstruturaComissao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxEstruturasComissoes)).EndInit();
            this.gbxEstruturasComissoes.ResumeLayout(false);
            this.gbxEstruturasComissoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcSinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbxPorcValores)).EndInit();
            this.gbxPorcValores.ResumeLayout(false);
            this.gbxPorcValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cbxEstruturaComissao;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.GroupControl gbxEstruturasComissoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl gbxPorcValores;
        private System.Windows.Forms.Label lblValorSinal;
        private System.Windows.Forms.Label lblValorLote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblValorCorretor;
        private System.Windows.Forms.Label lblValorImob;
        private System.Windows.Forms.Label lblPorcCorretor;
        private System.Windows.Forms.Label lblPorcImob;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtPorcSinal;
        private System.Windows.Forms.Label lblSomaImobCorretor;
        private System.Windows.Forms.Label lblValorParcela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQtdParcSinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValorParcelaSinal;
        private System.Windows.Forms.Label label11;
    }
}