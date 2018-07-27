using SGS.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        
        v_Corretor v_corretor;
        v_Usuario v_usuario;
        c_Permissao c_permissao;
        v_Pendencias v_pendencias;
        v_EmpresaLicenca v_empresalicenca;
        v_Loteamento v_empreendimento;
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
            this.v_pendencias = new v_Pendencias(_usuario,_permissao);
            this.v_empresalicenca = new v_EmpresaLicenca(false,true);
            this.v_empreendimento = new v_Loteamento(_usuario,_permissao);
            
           
        }

        private void bbiCorretor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_corretor.ShowDialog();
        }

        private void ribbonControlPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void v_Principal_Load(object sender, EventArgs e)
        {

            _permissao = c_permissao.AutenticarPermissao(_usuario);
            bsiUsuario.Caption = "Usuário:" + _usuario + " Permissão:(Nivel:" + _permissao + ")";
            Permissao();   
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
    }
}
