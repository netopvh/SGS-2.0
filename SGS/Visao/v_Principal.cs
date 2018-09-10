﻿
using SGS.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao
{
    public partial class v_Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string _usuario;
        int _permissao;

        v_AtualizarSistema v_atualizarSistema;

        v_Corretor v_corretor;
        v_Usuario v_usuario;
        c_Permissao c_permissao;
        c_Empresalicenca c_empresalicenca;
        v_Pendencias v_pendencias;
        v_EmpresaLicenca v_empresalicenca;
        v_Loteamento v_empreendimento;
        v_Backup v_backup;
        v_RestaurarBackup v_restaurarBackup;
        v_ImpressoraTermica v_impressoTermica;

        public v_Principal()
        {
            InitializeComponent();
            
        }
        public v_Principal(string Usuario)
        {
            InitializeComponent();
            _usuario = Usuario;
            this.v_corretor = new v_Corretor(_usuario, _permissao);
            this.v_usuario = new v_Usuario(_permissao);
            this.c_permissao = new c_Permissao();
            this.c_empresalicenca = new c_Empresalicenca();
            this.v_pendencias = new v_Pendencias(_usuario,_permissao);
            this.v_empresalicenca = new v_EmpresaLicenca(false,true);
            this.v_empreendimento = new v_Loteamento(_usuario,_permissao);
            this.v_backup = new v_Backup();
            this.v_restaurarBackup = new v_RestaurarBackup();
            this.v_impressoTermica = new v_ImpressoraTermica();
            this.v_atualizarSistema = new v_AtualizarSistema();
        }

        private void bbiCorretor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_corretor.ShowDialog();
        }

        private void ribbonControlPrincipal_Click(object sender, EventArgs e)
        {

        }
        private void LogoEmpresa()
        {
            try
            {
                Stream stream = new MemoryStream(c_empresalicenca.CarrregarLogoMarca());
                var image = Image.FromStream(stream);
                this.BackgroundImage = image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (ArgumentNullException)
            {

                //throw;
            }
        }
        private void v_Principal_Load(object sender, EventArgs e)
        {
            
            //LogoEmpresa();
            VersaoAssembly();
            _permissao = c_permissao.AutenticarPermissao(_usuario);
            bsiUsuario.Caption = "Usuário:" + _usuario + " Permissão:(Nivel:" + _permissao + ")";
            Permissao();   
        }
        private void VersaoAssembly()
        {
            bsiVersao.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void bbiUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_usuario.ShowDialog();
        }

        private void v_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Permissao()
        {
            
        }

        private void bbiPendencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_pendencias.ShowDialog();
        }

        private void bbiEmpresaLicenca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_empresalicenca.ShowDialog();
        }

        private void bbiLoteamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_empreendimento.ShowDialog();
        }

        private void bbiFazerBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_backup.ShowDialog();
        }

        private void bbiRestaurarBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_restaurarBackup.ShowDialog();
        }

        private void bbiImpressoraTermica_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_impressoTermica.ShowDialog();
        }

        private void bsiVersao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Na aba Sistema tem onde atualizar o sistema!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bbiVerificarAtualizacao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_atualizarSistema.ShowDialog();
        }
    }
}
