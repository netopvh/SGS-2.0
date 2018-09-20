namespace SGS.Visao
{
    partial class v_ImpressoraTermica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTeste = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPortas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxModelos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCortarPapel = new System.Windows.Forms.GroupBox();
            this.btnCortarPapel = new System.Windows.Forms.Button();
            this.radioButtonCorteTotal = new System.Windows.Forms.RadioButton();
            this.radioButtonCorteParcial = new System.Windows.Forms.RadioButton();
            this.gbxImpressao = new System.Windows.Forms.GroupBox();
            this.btnCaracterAcentuado = new System.Windows.Forms.Button();
            this.btnTextoSimples = new System.Windows.Forms.Button();
            this.txtTextoSimples = new System.Windows.Forms.TextBox();
            this.btnImprimirTextoSimples = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxCortarPapel.SuspendLayout();
            this.gbxImpressao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeste);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxPortas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxModelos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelo/Porta/IP";
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(309, 58);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(121, 23);
            this.btnTeste.TabIndex = 5;
            this.btnTeste.Text = "Testar Conexão";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(309, 32);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(121, 21);
            this.txtIP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // cbxPortas
            // 
            this.cbxPortas.FormattingEnabled = true;
            this.cbxPortas.Location = new System.Drawing.Point(182, 32);
            this.cbxPortas.Name = "cbxPortas";
            this.cbxPortas.Size = new System.Drawing.Size(121, 21);
            this.cbxPortas.TabIndex = 3;
            this.cbxPortas.SelectedIndexChanged += new System.EventHandler(this.cbxPortas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta:";
            // 
            // cbxModelos
            // 
            this.cbxModelos.FormattingEnabled = true;
            this.cbxModelos.Location = new System.Drawing.Point(9, 32);
            this.cbxModelos.Name = "cbxModelos";
            this.cbxModelos.Size = new System.Drawing.Size(167, 21);
            this.cbxModelos.TabIndex = 1;
            this.cbxModelos.SelectedIndexChanged += new System.EventHandler(this.cbxModelos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // gbxCortarPapel
            // 
            this.gbxCortarPapel.Controls.Add(this.btnCortarPapel);
            this.gbxCortarPapel.Controls.Add(this.radioButtonCorteTotal);
            this.gbxCortarPapel.Controls.Add(this.radioButtonCorteParcial);
            this.gbxCortarPapel.Location = new System.Drawing.Point(457, 12);
            this.gbxCortarPapel.Name = "gbxCortarPapel";
            this.gbxCortarPapel.Size = new System.Drawing.Size(160, 90);
            this.gbxCortarPapel.TabIndex = 1;
            this.gbxCortarPapel.TabStop = false;
            this.gbxCortarPapel.Text = "Cortar Papel";
            // 
            // btnCortarPapel
            // 
            this.btnCortarPapel.Location = new System.Drawing.Point(73, 56);
            this.btnCortarPapel.Name = "btnCortarPapel";
            this.btnCortarPapel.Size = new System.Drawing.Size(75, 23);
            this.btnCortarPapel.TabIndex = 5;
            this.btnCortarPapel.Text = "Cortar Papel";
            this.btnCortarPapel.UseVisualStyleBackColor = true;
            this.btnCortarPapel.Click += new System.EventHandler(this.btnCortarPapel_Click);
            // 
            // radioButtonCorteTotal
            // 
            this.radioButtonCorteTotal.AutoSize = true;
            this.radioButtonCorteTotal.Location = new System.Drawing.Point(71, 33);
            this.radioButtonCorteTotal.Name = "radioButtonCorteTotal";
            this.radioButtonCorteTotal.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCorteTotal.TabIndex = 4;
            this.radioButtonCorteTotal.TabStop = true;
            this.radioButtonCorteTotal.Text = "Corte Total";
            this.radioButtonCorteTotal.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorteParcial
            // 
            this.radioButtonCorteParcial.AutoSize = true;
            this.radioButtonCorteParcial.Location = new System.Drawing.Point(8, 33);
            this.radioButtonCorteParcial.Name = "radioButtonCorteParcial";
            this.radioButtonCorteParcial.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCorteParcial.TabIndex = 3;
            this.radioButtonCorteParcial.TabStop = true;
            this.radioButtonCorteParcial.Text = "Parcial";
            this.radioButtonCorteParcial.UseVisualStyleBackColor = true;
            // 
            // gbxImpressao
            // 
            this.gbxImpressao.Controls.Add(this.btnCaracterAcentuado);
            this.gbxImpressao.Controls.Add(this.btnTextoSimples);
            this.gbxImpressao.Controls.Add(this.txtTextoSimples);
            this.gbxImpressao.Location = new System.Drawing.Point(12, 108);
            this.gbxImpressao.Name = "gbxImpressao";
            this.gbxImpressao.Size = new System.Drawing.Size(605, 59);
            this.gbxImpressao.TabIndex = 2;
            this.gbxImpressao.TabStop = false;
            this.gbxImpressao.Text = "Impressão de texto simples (Bematech TX)";
            // 
            // btnCaracterAcentuado
            // 
            this.btnCaracterAcentuado.Location = new System.Drawing.Point(477, 20);
            this.btnCaracterAcentuado.Name = "btnCaracterAcentuado";
            this.btnCaracterAcentuado.Size = new System.Drawing.Size(112, 23);
            this.btnCaracterAcentuado.TabIndex = 2;
            this.btnCaracterAcentuado.Text = "Caracter Acentuado";
            this.btnCaracterAcentuado.UseVisualStyleBackColor = true;
            this.btnCaracterAcentuado.Click += new System.EventHandler(this.btnCaracterAcentuado_Click);
            // 
            // btnTextoSimples
            // 
            this.btnTextoSimples.Location = new System.Drawing.Point(360, 20);
            this.btnTextoSimples.Name = "btnTextoSimples";
            this.btnTextoSimples.Size = new System.Drawing.Size(111, 23);
            this.btnTextoSimples.TabIndex = 1;
            this.btnTextoSimples.Text = "Texto Simples";
            this.btnTextoSimples.UseVisualStyleBackColor = true;
            this.btnTextoSimples.Click += new System.EventHandler(this.btnTextoSimples_Click);
            // 
            // txtTextoSimples
            // 
            this.txtTextoSimples.Location = new System.Drawing.Point(6, 22);
            this.txtTextoSimples.Name = "txtTextoSimples";
            this.txtTextoSimples.Size = new System.Drawing.Size(348, 21);
            this.txtTextoSimples.TabIndex = 0;
            this.txtTextoSimples.Text = "Insira o texto ou clique nos botões ao lado";
            // 
            // btnImprimirTextoSimples
            // 
            this.btnImprimirTextoSimples.Image = global::SGS.Properties.Resources.Imprimir_24x24;
            this.btnImprimirTextoSimples.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimirTextoSimples.Location = new System.Drawing.Point(338, 173);
            this.btnImprimirTextoSimples.Name = "btnImprimirTextoSimples";
            this.btnImprimirTextoSimples.Size = new System.Drawing.Size(89, 44);
            this.btnImprimirTextoSimples.TabIndex = 3;
            this.btnImprimirTextoSimples.Text = "Imprimir";
            this.btnImprimirTextoSimples.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirTextoSimples.UseVisualStyleBackColor = true;
            this.btnImprimirTextoSimples.Click += new System.EventHandler(this.btnImprimirTextoSimples_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(433, 173);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 44);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(528, 173);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 44);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // v_ImpressoraTermica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 225);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnImprimirTextoSimples);
            this.Controls.Add(this.gbxImpressao);
            this.Controls.Add(this.gbxCortarPapel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "v_ImpressoraTermica";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações da Impressora Térmica";
            this.Load += new System.EventHandler(this.v_ImpressoraTermica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxCortarPapel.ResumeLayout(false);
            this.gbxCortarPapel.PerformLayout();
            this.gbxImpressao.ResumeLayout(false);
            this.gbxImpressao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPortas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCortarPapel;
        private System.Windows.Forms.Button btnCortarPapel;
        private System.Windows.Forms.RadioButton radioButtonCorteTotal;
        private System.Windows.Forms.RadioButton radioButtonCorteParcial;
        private System.Windows.Forms.GroupBox gbxImpressao;
        private System.Windows.Forms.Button btnCaracterAcentuado;
        private System.Windows.Forms.Button btnTextoSimples;
        private System.Windows.Forms.TextBox txtTextoSimples;
        private System.Windows.Forms.Button btnImprimirTextoSimples;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
    }
}