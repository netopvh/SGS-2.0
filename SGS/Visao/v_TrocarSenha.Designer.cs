namespace SGS.Visao
{
    partial class v_TrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TrocarSenha));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new DevExpress.XtraEditors.TextEdit();
            this.btnTrocarSenha = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMostrarSenhas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAtual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarSenha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Size = new System.Drawing.Size(265, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha Atual:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(15, 84);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Properties.UseSystemPasswordChar = true;
            this.txtSenhaAtual.Size = new System.Drawing.Size(265, 20);
            this.txtSenhaAtual.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nova Senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(15, 123);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Properties.UseSystemPasswordChar = true;
            this.txtNovaSenha.Size = new System.Drawing.Size(265, 20);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(15, 162);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Properties.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.Size = new System.Drawing.Size(265, 20);
            this.txtConfirmarSenha.TabIndex = 4;
            // 
            // btnTrocarSenha
            // 
            this.btnTrocarSenha.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrocarSenha.ImageOptions.Image")));
            this.btnTrocarSenha.Location = new System.Drawing.Point(170, 188);
            this.btnTrocarSenha.Name = "btnTrocarSenha";
            this.btnTrocarSenha.Size = new System.Drawing.Size(110, 44);
            this.btnTrocarSenha.TabIndex = 5;
            this.btnTrocarSenha.Text = "Trocar Senha";
            this.btnTrocarSenha.Click += new System.EventHandler(this.btnTrocarSenha_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Entre com os seguintes dados:";
            // 
            // cbxMostrarSenhas
            // 
            this.cbxMostrarSenhas.AutoSize = true;
            this.cbxMostrarSenhas.Location = new System.Drawing.Point(15, 188);
            this.cbxMostrarSenhas.Name = "cbxMostrarSenhas";
            this.cbxMostrarSenhas.Size = new System.Drawing.Size(101, 17);
            this.cbxMostrarSenhas.TabIndex = 6;
            this.cbxMostrarSenhas.Text = "Mostrar Senhas";
            this.cbxMostrarSenhas.UseVisualStyleBackColor = true;
            this.cbxMostrarSenhas.CheckedChanged += new System.EventHandler(this.cbxMostrarSenhas_CheckedChanged);
            // 
            // v_TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 244);
            this.Controls.Add(this.cbxMostrarSenhas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTrocarSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "v_TrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar Senha";
            this.Load += new System.EventHandler(this.v_TrocarSenha_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.v_TrocarSenha_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenhaAtual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNovaSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarSenha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSenhaAtual;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtNovaSenha;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtConfirmarSenha;
        private DevExpress.XtraEditors.SimpleButton btnTrocarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxMostrarSenhas;
    }
}