﻿namespace SGS.Visao
{
    partial class v_StatusContrato
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.rbtVendido = new System.Windows.Forms.RadioButton();
            this.rbtCancelado = new System.Windows.Forms.RadioButton();
            this.rbtDevolvido = new System.Windows.Forms.RadioButton();
            this.rbtExtraviado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDataCad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtExtraviado);
            this.groupBox1.Controls.Add(this.rbtDevolvido);
            this.groupBox1.Controls.Add(this.rbtCancelado);
            this.groupBox1.Controls.Add(this.rbtVendido);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o status";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(255, 91);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rbtVendido
            // 
            this.rbtVendido.AutoSize = true;
            this.rbtVendido.Location = new System.Drawing.Point(6, 20);
            this.rbtVendido.Name = "rbtVendido";
            this.rbtVendido.Size = new System.Drawing.Size(63, 17);
            this.rbtVendido.TabIndex = 0;
            this.rbtVendido.TabStop = true;
            this.rbtVendido.Text = "Vendido";
            this.rbtVendido.UseVisualStyleBackColor = true;
            // 
            // rbtCancelado
            // 
            this.rbtCancelado.AutoSize = true;
            this.rbtCancelado.Location = new System.Drawing.Point(75, 20);
            this.rbtCancelado.Name = "rbtCancelado";
            this.rbtCancelado.Size = new System.Drawing.Size(75, 17);
            this.rbtCancelado.TabIndex = 1;
            this.rbtCancelado.TabStop = true;
            this.rbtCancelado.Text = "Cancelado";
            this.rbtCancelado.UseVisualStyleBackColor = true;
            // 
            // rbtDevolvido
            // 
            this.rbtDevolvido.AutoSize = true;
            this.rbtDevolvido.Location = new System.Drawing.Point(156, 20);
            this.rbtDevolvido.Name = "rbtDevolvido";
            this.rbtDevolvido.Size = new System.Drawing.Size(72, 17);
            this.rbtDevolvido.TabIndex = 2;
            this.rbtDevolvido.TabStop = true;
            this.rbtDevolvido.Text = "Devolvido";
            this.rbtDevolvido.UseVisualStyleBackColor = true;
            // 
            // rbtExtraviado
            // 
            this.rbtExtraviado.AutoSize = true;
            this.rbtExtraviado.Location = new System.Drawing.Point(234, 20);
            this.rbtExtraviado.Name = "rbtExtraviado";
            this.rbtExtraviado.Size = new System.Drawing.Size(77, 17);
            this.rbtExtraviado.TabIndex = 3;
            this.rbtExtraviado.TabStop = true;
            this.rbtExtraviado.Text = "Extraviado";
            this.rbtExtraviado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCad.Location = new System.Drawing.Point(46, 44);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(104, 21);
            this.dtpDataCad.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(174, 91);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 44);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // v_StatusContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 146);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_StatusContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar status do contrato";
            this.Load += new System.EventHandler(this.v_StatusContrato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtExtraviado;
        private System.Windows.Forms.RadioButton rbtDevolvido;
        private System.Windows.Forms.RadioButton rbtCancelado;
        private System.Windows.Forms.RadioButton rbtVendido;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSalvar;
    }
}