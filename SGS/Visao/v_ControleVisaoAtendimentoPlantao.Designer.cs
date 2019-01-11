namespace SGS.Visao
{
    partial class v_ControleVisaoAtendimentoPlantao
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPauseSlider = new DevExpress.XtraEditors.SimpleButton();
            this.btnProximoCorretorDaVez = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltarCorretorDaVez = new DevExpress.XtraEditors.SimpleButton();
            this.btnVoltar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProximoCorretorDaVez);
            this.groupBox1.Controls.Add(this.btnVoltarCorretorDaVez);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Corretor da vez:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPauseSlider);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slider";
            // 
            // btnPauseSlider
            // 
            this.btnPauseSlider.ImageOptions.Image = global::SGS.Properties.Resources.Pausar30x30;
            this.btnPauseSlider.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnPauseSlider.Location = new System.Drawing.Point(47, 20);
            this.btnPauseSlider.Name = "btnPauseSlider";
            this.btnPauseSlider.Size = new System.Drawing.Size(75, 44);
            this.btnPauseSlider.TabIndex = 2;
            this.btnPauseSlider.Click += new System.EventHandler(this.btnPauseSlider_Click);
            // 
            // btnProximoCorretorDaVez
            // 
            this.btnProximoCorretorDaVez.ImageOptions.Image = global::SGS.Properties.Resources.Proximo30x30;
            this.btnProximoCorretorDaVez.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProximoCorretorDaVez.Location = new System.Drawing.Point(87, 20);
            this.btnProximoCorretorDaVez.Name = "btnProximoCorretorDaVez";
            this.btnProximoCorretorDaVez.Size = new System.Drawing.Size(75, 44);
            this.btnProximoCorretorDaVez.TabIndex = 2;
            this.btnProximoCorretorDaVez.Click += new System.EventHandler(this.btnProximoCorretorDaVez_Click);
            // 
            // btnVoltarCorretorDaVez
            // 
            this.btnVoltarCorretorDaVez.ImageOptions.Image = global::SGS.Properties.Resources.Anterior30x30;
            this.btnVoltarCorretorDaVez.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnVoltarCorretorDaVez.Location = new System.Drawing.Point(6, 20);
            this.btnVoltarCorretorDaVez.Name = "btnVoltarCorretorDaVez";
            this.btnVoltarCorretorDaVez.Size = new System.Drawing.Size(75, 44);
            this.btnVoltarCorretorDaVez.TabIndex = 1;
            this.btnVoltarCorretorDaVez.Click += new System.EventHandler(this.btnVoltarCorretorDaVez_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ImageOptions.Image = global::SGS.Properties.Resources.VoltasOffice24x24;
            this.btnVoltar.Location = new System.Drawing.Point(111, 174);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 44);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // v_ControleVisaoAtendimentoPlantao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 228);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "v_ControleVisaoAtendimentoPlantao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Remoto Plantão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnProximoCorretorDaVez;
        private DevExpress.XtraEditors.SimpleButton btnVoltarCorretorDaVez;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnPauseSlider;
        private DevExpress.XtraEditors.SimpleButton btnVoltar;
    }
}