namespace SGS.Visao
{
    partial class v_StatusFolhaAvulso
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
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDevolvido = new System.Windows.Forms.RadioButton();
            this.rbtCancelado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageOptions.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.Location = new System.Drawing.Point(176, 66);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.ToolTip = "Clique aqui se deseja salvar as alterações!";
            this.btnSalvar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(257, 66);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.ToolTip = "Clique aqui para fecha essa janela!";
            this.btnVoltar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataCad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtDevolvido);
            this.groupBox1.Controls.Add(this.rbtCancelado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 48);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o status";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(208, 16);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(103, 21);
            this.dtpDataCad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // rbtDevolvido
            // 
            this.rbtDevolvido.AutoSize = true;
            this.rbtDevolvido.Location = new System.Drawing.Point(90, 20);
            this.rbtDevolvido.Name = "rbtDevolvido";
            this.rbtDevolvido.Size = new System.Drawing.Size(72, 17);
            this.rbtDevolvido.TabIndex = 2;
            this.rbtDevolvido.TabStop = true;
            this.rbtDevolvido.Text = "Devolvido";
            this.rbtDevolvido.UseVisualStyleBackColor = true;
            // 
            // rbtCancelado
            // 
            this.rbtCancelado.AutoSize = true;
            this.rbtCancelado.Location = new System.Drawing.Point(9, 20);
            this.rbtCancelado.Name = "rbtCancelado";
            this.rbtCancelado.Size = new System.Drawing.Size(75, 17);
            this.rbtCancelado.TabIndex = 1;
            this.rbtCancelado.TabStop = true;
            this.rbtCancelado.Text = "Cancelado";
            this.rbtCancelado.UseVisualStyleBackColor = true;
            // 
            // v_StatusFolhaAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 121);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_StatusFolhaAvulso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar Status Folha Avulso";
            this.Load += new System.EventHandler(this.v_StatusFolhaAvulso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDevolvido;
        private System.Windows.Forms.RadioButton rbtCancelado;
    }
}