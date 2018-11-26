namespace SGS.Visao
{
    partial class v_NovaEstruturaComissao
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
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPorcImob = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorcCorretor = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPorcentagem = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcImob.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcCorretor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(326, 99);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(245, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Size = new System.Drawing.Size(386, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "% Imob.";
            // 
            // txtPorcImob
            // 
            this.txtPorcImob.EditValue = "0,00";
            this.txtPorcImob.Location = new System.Drawing.Point(15, 64);
            this.txtPorcImob.Name = "txtPorcImob";
            this.txtPorcImob.Properties.DisplayFormat.FormatString = "P";
            this.txtPorcImob.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcImob.Properties.Mask.EditMask = "P";
            this.txtPorcImob.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcImob.Size = new System.Drawing.Size(95, 20);
            this.txtPorcImob.TabIndex = 2;
            this.txtPorcImob.EditValueChanged += new System.EventHandler(this.txtPorcImob_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "% Corretor";
            // 
            // txtPorcCorretor
            // 
            this.txtPorcCorretor.EditValue = "0,00";
            this.txtPorcCorretor.Location = new System.Drawing.Point(121, 64);
            this.txtPorcCorretor.Name = "txtPorcCorretor";
            this.txtPorcCorretor.Properties.DisplayFormat.FormatString = "P";
            this.txtPorcCorretor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPorcCorretor.Properties.Mask.EditMask = "P";
            this.txtPorcCorretor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPorcCorretor.Size = new System.Drawing.Size(95, 20);
            this.txtPorcCorretor.TabIndex = 3;
            this.txtPorcCorretor.EditValueChanged += new System.EventHandler(this.txtPorcCorretor_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rbtInativo);
            this.groupControl1.Controls.Add(this.rbtAtivo);
            this.groupControl1.Location = new System.Drawing.Point(15, 90);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(201, 42);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Status";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(61, 20);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(59, 17);
            this.rbtInativo.TabIndex = 1;
            this.rbtInativo.TabStop = true;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Location = new System.Drawing.Point(5, 20);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(50, 17);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total.:";
            // 
            // lblTotalPorcentagem
            // 
            this.lblTotalPorcentagem.AutoSize = true;
            this.lblTotalPorcentagem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPorcentagem.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPorcentagem.Location = new System.Drawing.Point(267, 67);
            this.lblTotalPorcentagem.Name = "lblTotalPorcentagem";
            this.lblTotalPorcentagem.Size = new System.Drawing.Size(27, 13);
            this.lblTotalPorcentagem.TabIndex = 10;
            this.lblTotalPorcentagem.Text = "0%";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // v_NovaEstruturaComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 152);
            this.Controls.Add(this.lblTotalPorcentagem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtPorcCorretor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPorcImob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_NovaEstruturaComissao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Estrutura de Comissão";
            this.Load += new System.EventHandler(this.v_NovaEstruturaComissao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcImob.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcCorretor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPorcImob;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtPorcCorretor;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPorcentagem;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}