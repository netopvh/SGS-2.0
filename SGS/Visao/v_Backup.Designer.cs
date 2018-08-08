namespace SGS.Visao
{
    partial class v_Backup
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
            this.rbtLocalEscolhido = new System.Windows.Forms.RadioButton();
            this.gbxLocal = new System.Windows.Forms.GroupBox();
            this.txtLocalPadrao = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cbxFechaSistema = new System.Windows.Forms.CheckBox();
            this.rbtLocalPadrao = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pgbBackup = new System.Windows.Forms.ProgressBar();
            this.v = new System.Windows.Forms.Label();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.gbxLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtLocalEscolhido
            // 
            this.rbtLocalEscolhido.AutoSize = true;
            this.rbtLocalEscolhido.Location = new System.Drawing.Point(8, 19);
            this.rbtLocalEscolhido.Name = "rbtLocalEscolhido";
            this.rbtLocalEscolhido.Size = new System.Drawing.Size(205, 17);
            this.rbtLocalEscolhido.TabIndex = 0;
            this.rbtLocalEscolhido.TabStop = true;
            this.rbtLocalEscolhido.Text = "Escolhe o local para efetuar o backup";
            this.rbtLocalEscolhido.UseVisualStyleBackColor = true;
            // 
            // gbxLocal
            // 
            this.gbxLocal.Controls.Add(this.txtLocalPadrao);
            this.gbxLocal.Controls.Add(this.lblLocal);
            this.gbxLocal.Controls.Add(this.cbxFechaSistema);
            this.gbxLocal.Controls.Add(this.rbtLocalPadrao);
            this.gbxLocal.Controls.Add(this.rbtLocalEscolhido);
            this.gbxLocal.Location = new System.Drawing.Point(12, 12);
            this.gbxLocal.Name = "gbxLocal";
            this.gbxLocal.Size = new System.Drawing.Size(403, 136);
            this.gbxLocal.TabIndex = 2;
            this.gbxLocal.TabStop = false;
            this.gbxLocal.Text = "Local";
            this.gbxLocal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtLocalPadrao
            // 
            this.txtLocalPadrao.Enabled = false;
            this.txtLocalPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalPadrao.Location = new System.Drawing.Point(9, 84);
            this.txtLocalPadrao.Name = "txtLocalPadrao";
            this.txtLocalPadrao.Size = new System.Drawing.Size(388, 21);
            this.txtLocalPadrao.TabIndex = 3;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(6, 68);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(73, 13);
            this.lblLocal.TabIndex = 2;
            this.lblLocal.Text = "Local Padrão:";
            // 
            // cbxFechaSistema
            // 
            this.cbxFechaSistema.AutoSize = true;
            this.cbxFechaSistema.Location = new System.Drawing.Point(9, 110);
            this.cbxFechaSistema.Name = "cbxFechaSistema";
            this.cbxFechaSistema.Size = new System.Drawing.Size(169, 17);
            this.cbxFechaSistema.TabIndex = 4;
            this.cbxFechaSistema.Text = "Fecha o sistema após Backup";
            this.cbxFechaSistema.UseVisualStyleBackColor = true;
            // 
            // rbtLocalPadrao
            // 
            this.rbtLocalPadrao.AutoSize = true;
            this.rbtLocalPadrao.Location = new System.Drawing.Point(8, 42);
            this.rbtLocalPadrao.Name = "rbtLocalPadrao";
            this.rbtLocalPadrao.Size = new System.Drawing.Size(184, 17);
            this.rbtLocalPadrao.TabIndex = 1;
            this.rbtLocalPadrao.TabStop = true;
            this.rbtLocalPadrao.Text = "Efetuar o Backup no local padrão";
            this.rbtLocalPadrao.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pgbBackup
            // 
            this.pgbBackup.Location = new System.Drawing.Point(12, 176);
            this.pgbBackup.Name = "pgbBackup";
            this.pgbBackup.Size = new System.Drawing.Size(403, 23);
            this.pgbBackup.Step = 1;
            this.pgbBackup.TabIndex = 5;
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(9, 160);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(57, 13);
            this.v.TabIndex = 4;
            this.v.Text = "Progresso:";
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgresso.ForeColor = System.Drawing.Color.Red;
            this.lblProgresso.Location = new System.Drawing.Point(72, 160);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(16, 13);
            this.lblProgresso.TabIndex = 6;
            this.lblProgresso.Text = "%";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(259, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(340, 205);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 35);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(178, 205);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 35);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // v_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 243);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.v);
            this.Controls.Add(this.pgbBackup);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gbxLocal);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "v_Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar Backup";
            this.Load += new System.EventHandler(this.v_Backup_Load);
            this.gbxLocal.ResumeLayout(false);
            this.gbxLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtLocalEscolhido;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox gbxLocal;
        private System.Windows.Forms.RadioButton rbtLocalPadrao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtLocalPadrao;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.CheckBox cbxFechaSistema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar pgbBackup;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}