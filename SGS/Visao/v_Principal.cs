
using SGS.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        
        
        c_Permissao c_permissao;
        c_Empresalicenca c_empresalicenca;
        
        v_EmpresaLicenca v_empresalicenca;
        
        v_Backup v_backup;
        v_RestaurarBackup v_restaurarBackup;
        v_ImpressoraTermica v_impressoTermica;
        v_FtpConfig v_ftpConfig;
        
        public v_Principal()
        {
            InitializeComponent();
            
        }
        public v_Principal(string Usuario,int Permissao)
        {
            InitializeComponent();
            _usuario = Usuario;
            _permissao = Permissao;
            
            
            this.c_permissao = new c_Permissao();
            this.c_empresalicenca = new c_Empresalicenca();
            
            this.v_empresalicenca = new v_EmpresaLicenca(false,true);
            
            this.v_backup = new v_Backup();
            this.v_restaurarBackup = new v_RestaurarBackup();
            this.v_impressoTermica = new v_ImpressoraTermica();
            this.v_atualizarSistema = new v_AtualizarSistema();
            this.v_ftpConfig = new v_FtpConfig();
            
            
        }
        private void Permissao()
        {
            switch (_permissao)
            {
                case 1:
                    bbiAPagar.Enabled = false;
                    bbiAreceber.Enabled = false;
                    bbiEmail.Enabled = false;
                    bbiFechamentoCaixa.Enabled = false;
                    bbiFluxoCaixa.Enabled = false;
                    bbiFTP.Enabled = false;
                    bbiRestaurarBackup.Enabled = false;
                    bbiUsuario.Enabled = false;
                    bbiBaixarRecebimentos.Enabled = false;
                    bbiControleGeral.Enabled = false;
                    bbiEstruturasComissoes.Enabled = false;
                    bbiInserirComissoes.Enabled = false;
                    bbiControlePlantao.Enabled = false;
                    
                    break;
                case 2:
                    bbiAPagar.Enabled = false;
                    bbiAreceber.Enabled = false;
                    bbiEmail.Enabled = false;
                    bbiFechamentoCaixa.Enabled = false;
                    bbiFluxoCaixa.Enabled = false;
                    bbiFTP.Enabled = false;
                    bbiRestaurarBackup.Enabled = false;
                    bbiUsuario.Enabled = false;
                    bbiBaixarRecebimentos.Enabled = false;
                    bbiControleGeral.Enabled = false;
                    bbiEstruturasComissoes.Enabled = false;
                    bbiInserirComissoes.Enabled = false;
                    bbiControlePlantao.Enabled = false;
                    break;
                case 3:
                    bbiAPagar.Enabled = false;
                    bbiAreceber.Enabled = false;
                    bbiEmail.Enabled = true;
                    bbiFechamentoCaixa.Enabled = false;
                    bbiFluxoCaixa.Enabled = false;
                    bbiFTP.Enabled = false;
                    bbiRestaurarBackup.Enabled = false;
                    bbiUsuario.Enabled = false;
                    bbiBaixarRecebimentos.Enabled = false;
                    bbiControleGeral.Enabled = false;
                    bbiEstruturasComissoes.Enabled = false;
                    bbiInserirComissoes.Enabled = false;
                    bbiControlePlantao.Enabled = false;
                    break;
                case 4:
                    bbiAPagar.Enabled = true;
                    bbiAreceber.Enabled = true;
                    bbiEmail.Enabled = true;
                    bbiFechamentoCaixa.Enabled = true;
                    bbiFluxoCaixa.Enabled = true;
                    bbiFTP.Enabled = false;
                    bbiRestaurarBackup.Enabled = false;
                    bbiUsuario.Enabled = false;
                    bbiBaixarRecebimentos.Enabled = true;
                    bbiControleGeral.Enabled = true;
                    bbiEstruturasComissoes.Enabled = true;
                    bbiInserirComissoes.Enabled = true;
                    bbiControlePlantao.Enabled = false;
                    break;
                    
                default:
                    break;
            }

        }

        private void bbiCorretor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_Corretor v_corretor = new v_Corretor(_usuario, _permissao);
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
            string Server = (ConfigurationManager.AppSettings["Server"]);
            bsiUsuario.Caption = "Usuário:" + _usuario + " Permissão:(Nivel:" + _permissao + ") | Servidor:"+ Server;
            Permissao();
            
        }
        private void VersaoAssembly()
        {
            bsiVersao.Caption = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void bbiUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_Usuario v_usuario = new v_Usuario(_permissao);
            v_usuario.ShowDialog();
        }

        private void v_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void bbiPendencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_Pendencias v_pendencias = new v_Pendencias(_usuario, _permissao);
            v_pendencias.ShowDialog();
        }

        private void bbiEmpresaLicenca_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_empresalicenca.ShowDialog();
        }

        private void bbiLoteamento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_Loteamento v_empreendimento = new v_Loteamento(_usuario, _permissao);
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
            toastNotificationsManager1.ShowNotification("4da965cc-d3fb-47a6-8e2f-5c63d4a066ed");
        }

        private void bbiVerificarAtualizacao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_atualizarSistema.ShowDialog();
        }

        private void bbiFTP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_ftpConfig.ShowDialog();
        }

        private void bbiVisitaStand_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_VisitasStand v_visitasStand = new v_VisitasStand(_permissao,_usuario);
            v_visitasStand.ShowDialog();
        }

        private void bbiContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_DistContrato v_disContrato = new v_DistContrato(_permissao, _usuario);
            v_disContrato.ShowDialog();
        }

        private void bbiFolhaAvulso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_DistFolhaAvulso v_distFolhaAvulso = new v_DistFolhaAvulso(_permissao, _usuario);
            v_distFolhaAvulso.ShowDialog();
        }

        private void bbiEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            v_EmailConfig v_emailConfig = new v_EmailConfig();
            v_emailConfig.ShowDialog();
        }

        private void bbiAreceber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiAPagar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiFechamentoCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiFluxoCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiContato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Email:italo@primeempreendimentos.net.br\nContato:(91)-99338-9501", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bbiAcessoRemoto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"C:\SGS\TeamViewerQS11.exe");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Não foi possível encontrar o execultavel do TeamViewer na pasta do sistema SGS!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bbiInserirComissoes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_InserirComissao v_inserirComissao = new v_InserirComissao(_usuario);
            v_inserirComissao.ShowDialog();
        }

        private void bbiControleGeral_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_ControleGeralComissoes v_GeralComissoes = new v_ControleGeralComissoes(_usuario);
            v_GeralComissoes.ShowDialog();
        }

        private void bbiEstruturasComissoes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_EstruturasComissoes v_estruturasComissoes = new v_EstruturasComissoes(_usuario);
            v_estruturasComissoes.ShowDialog();
        }

        private void bbiEstoqueGeral_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiControlePlantao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_ControlePlatao v_controlePlatao = new v_ControlePlatao(_usuario);
            v_controlePlatao.Show();
        }

        private void bbiContaCaixa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiCentroCusto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bbiTemas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Em Desenvolvimento", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
