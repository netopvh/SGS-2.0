namespace SGS.Visao
{
    partial class v_NovoAtendimento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lookUpEditCiddeUF = new DevExpress.XtraEditors.LookUpEdit();
            this.cidadeEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lookUpEditCorretorAnterior = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEditCorretorAtual = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lookUpEditEmpreendimento = new DevExpress.XtraEditors.LookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLocalizouOutros = new System.Windows.Forms.TextBox();
            this.rbtOutros = new System.Windows.Forms.RadioButton();
            this.rbtFolder = new System.Windows.Forms.RadioButton();
            this.rbtCarroSom = new System.Windows.Forms.RadioButton();
            this.rbtInternet = new System.Windows.Forms.RadioButton();
            this.rbtRadio = new System.Windows.Forms.RadioButton();
            this.rbtTelevisao = new System.Windows.Forms.RadioButton();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCiddeUF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeEstadoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretorAnterior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretorAtual.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpreendimento.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Location = new System.Drawing.Point(9, 32);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(352, 21);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lookUpEditCiddeUF);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtpDataCadastro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefoneCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cliente";
            // 
            // lookUpEditCiddeUF
            // 
            this.lookUpEditCiddeUF.Location = new System.Drawing.Point(122, 71);
            this.lookUpEditCiddeUF.Name = "lookUpEditCiddeUF";
            this.lookUpEditCiddeUF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCiddeUF.Properties.DataSource = this.cidadeEstadoBindingSource;
            this.lookUpEditCiddeUF.Properties.DisplayMember = "CidadeEstado";
            this.lookUpEditCiddeUF.Properties.DropDownRows = 5;
            this.lookUpEditCiddeUF.Properties.NullText = "";
            this.lookUpEditCiddeUF.Properties.ValueMember = "CidadeEstado";
            this.lookUpEditCiddeUF.Size = new System.Drawing.Size(239, 20);
            this.lookUpEditCiddeUF.TabIndex = 3;
            // 
            // cidadeEstadoBindingSource
            // 
            this.cidadeEstadoBindingSource.DataMember = "Cidade_Estado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Data do Cadastro:";
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Location = new System.Drawing.Point(109, 98);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(252, 21);
            this.dtpDataCadastro.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cidade-UF:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(9, 71);
            this.txtTelefoneCliente.Mask = "(99) 00000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(107, 21);
            this.txtTelefoneCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // txtQD
            // 
            this.txtQD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQD.Location = new System.Drawing.Point(38, 78);
            this.txtQD.MaxLength = 3;
            this.txtQD.Name = "txtQD";
            this.txtQD.Size = new System.Drawing.Size(65, 21);
            this.txtQD.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identificador:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lookUpEditCorretorAnterior);
            this.groupBox2.Controls.Add(this.lookUpEditCorretorAtual);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Corretor";
            // 
            // lookUpEditCorretorAnterior
            // 
            this.lookUpEditCorretorAnterior.Location = new System.Drawing.Point(9, 72);
            this.lookUpEditCorretorAnterior.Name = "lookUpEditCorretorAnterior";
            this.lookUpEditCorretorAnterior.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCorretorAnterior.Properties.DisplayMember = "nome";
            this.lookUpEditCorretorAnterior.Properties.DropDownRows = 5;
            this.lookUpEditCorretorAnterior.Properties.NullText = "";
            this.lookUpEditCorretorAnterior.Properties.ValueMember = "nome";
            this.lookUpEditCorretorAnterior.Size = new System.Drawing.Size(352, 20);
            this.lookUpEditCorretorAnterior.TabIndex = 6;
            // 
            // lookUpEditCorretorAtual
            // 
            this.lookUpEditCorretorAtual.Location = new System.Drawing.Point(9, 32);
            this.lookUpEditCorretorAtual.Name = "lookUpEditCorretorAtual";
            this.lookUpEditCorretorAtual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCorretorAtual.Properties.DisplayMember = "nome";
            this.lookUpEditCorretorAtual.Properties.DropDownRows = 5;
            this.lookUpEditCorretorAtual.Properties.NullText = "";
            this.lookUpEditCorretorAtual.Properties.ValueMember = "nome";
            this.lookUpEditCorretorAtual.Size = new System.Drawing.Size(352, 20);
            this.lookUpEditCorretorAtual.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Atendimento anterior?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Atual:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lookUpEditEmpreendimento);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtLT);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtQD);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 109);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empreendimento";
            // 
            // lookUpEditEmpreendimento
            // 
            this.lookUpEditEmpreendimento.Location = new System.Drawing.Point(9, 38);
            this.lookUpEditEmpreendimento.Name = "lookUpEditEmpreendimento";
            this.lookUpEditEmpreendimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEmpreendimento.Properties.DisplayMember = "nome";
            this.lookUpEditEmpreendimento.Properties.DropDownRows = 5;
            this.lookUpEditEmpreendimento.Properties.NullText = "";
            this.lookUpEditEmpreendimento.Properties.ValueMember = "nome";
            this.lookUpEditEmpreendimento.Size = new System.Drawing.Size(352, 20);
            this.lookUpEditEmpreendimento.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "LT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "QD:";
            // 
            // txtLT
            // 
            this.txtLT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLT.Location = new System.Drawing.Point(137, 78);
            this.txtLT.MaxLength = 3;
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(65, 21);
            this.txtLT.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLocalizouOutros);
            this.groupBox4.Controls.Add(this.rbtOutros);
            this.groupBox4.Controls.Add(this.rbtFolder);
            this.groupBox4.Controls.Add(this.rbtCarroSom);
            this.groupBox4.Controls.Add(this.rbtInternet);
            this.groupBox4.Controls.Add(this.rbtRadio);
            this.groupBox4.Controls.Add(this.rbtTelevisao);
            this.groupBox4.Location = new System.Drawing.Point(12, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 78);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Localizou";
            // 
            // txtLocalizouOutros
            // 
            this.txtLocalizouOutros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizouOutros.Enabled = false;
            this.txtLocalizouOutros.Location = new System.Drawing.Point(74, 41);
            this.txtLocalizouOutros.Name = "txtLocalizouOutros";
            this.txtLocalizouOutros.Size = new System.Drawing.Size(268, 21);
            this.txtLocalizouOutros.TabIndex = 16;
            // 
            // rbtOutros
            // 
            this.rbtOutros.AutoSize = true;
            this.rbtOutros.Location = new System.Drawing.Point(9, 42);
            this.rbtOutros.Name = "rbtOutros";
            this.rbtOutros.Size = new System.Drawing.Size(62, 17);
            this.rbtOutros.TabIndex = 15;
            this.rbtOutros.TabStop = true;
            this.rbtOutros.Text = "Outros:";
            this.rbtOutros.UseVisualStyleBackColor = true;
            this.rbtOutros.CheckedChanged += new System.EventHandler(this.rbtOutros_CheckedChanged);
            // 
            // rbtFolder
            // 
            this.rbtFolder.AutoSize = true;
            this.rbtFolder.Location = new System.Drawing.Point(288, 19);
            this.rbtFolder.Name = "rbtFolder";
            this.rbtFolder.Size = new System.Drawing.Size(55, 17);
            this.rbtFolder.TabIndex = 14;
            this.rbtFolder.TabStop = true;
            this.rbtFolder.Text = "Fôlder";
            this.rbtFolder.UseVisualStyleBackColor = true;
            this.rbtFolder.CheckedChanged += new System.EventHandler(this.rbtFolder_CheckedChanged);
            // 
            // rbtCarroSom
            // 
            this.rbtCarroSom.AutoSize = true;
            this.rbtCarroSom.Location = new System.Drawing.Point(208, 19);
            this.rbtCarroSom.Name = "rbtCarroSom";
            this.rbtCarroSom.Size = new System.Drawing.Size(75, 17);
            this.rbtCarroSom.TabIndex = 13;
            this.rbtCarroSom.TabStop = true;
            this.rbtCarroSom.Text = "Carro Som";
            this.rbtCarroSom.UseVisualStyleBackColor = true;
            this.rbtCarroSom.CheckedChanged += new System.EventHandler(this.rbtCarroSom_CheckedChanged);
            // 
            // rbtInternet
            // 
            this.rbtInternet.AutoSize = true;
            this.rbtInternet.Location = new System.Drawing.Point(141, 19);
            this.rbtInternet.Name = "rbtInternet";
            this.rbtInternet.Size = new System.Drawing.Size(65, 17);
            this.rbtInternet.TabIndex = 12;
            this.rbtInternet.TabStop = true;
            this.rbtInternet.Text = "Internet";
            this.rbtInternet.UseVisualStyleBackColor = true;
            this.rbtInternet.CheckedChanged += new System.EventHandler(this.rbtInternet_CheckedChanged);
            // 
            // rbtRadio
            // 
            this.rbtRadio.AutoSize = true;
            this.rbtRadio.Location = new System.Drawing.Point(86, 19);
            this.rbtRadio.Name = "rbtRadio";
            this.rbtRadio.Size = new System.Drawing.Size(52, 17);
            this.rbtRadio.TabIndex = 11;
            this.rbtRadio.TabStop = true;
            this.rbtRadio.Text = "Rádio";
            this.rbtRadio.UseVisualStyleBackColor = true;
            this.rbtRadio.CheckedChanged += new System.EventHandler(this.rbtRadio_CheckedChanged);
            // 
            // rbtTelevisao
            // 
            this.rbtTelevisao.AutoSize = true;
            this.rbtTelevisao.Location = new System.Drawing.Point(9, 19);
            this.rbtTelevisao.Name = "rbtTelevisao";
            this.rbtTelevisao.Size = new System.Drawing.Size(70, 17);
            this.rbtTelevisao.TabIndex = 10;
            this.rbtTelevisao.TabStop = true;
            this.rbtTelevisao.Text = "Televisão";
            this.rbtTelevisao.UseVisualStyleBackColor = true;
            this.rbtTelevisao.CheckedChanged += new System.EventHandler(this.rbtTelevisao_CheckedChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(313, 452);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 35);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::SGS.Properties.Resources.Salvar24x24;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(232, 452);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 35);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // v_NovoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 498);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "v_NovoAtendimento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Atendimento";
            this.Load += new System.EventHandler(this.v_NovoAtendimento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCiddeUF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeEstadoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretorAnterior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCorretorAtual.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmpreendimento.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLocalizouOutros;
        private System.Windows.Forms.RadioButton rbtOutros;
        private System.Windows.Forms.RadioButton rbtFolder;
        private System.Windows.Forms.RadioButton rbtCarroSom;
        private System.Windows.Forms.RadioButton rbtInternet;
        private System.Windows.Forms.RadioButton rbtRadio;
        private System.Windows.Forms.RadioButton rbtTelevisao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCiddeUF;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCorretorAnterior;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCorretorAtual;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditEmpreendimento;
        
        private System.Windows.Forms.BindingSource cidadeEstadoBindingSource;
        
    }
}