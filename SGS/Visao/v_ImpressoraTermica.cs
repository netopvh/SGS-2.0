using SGS.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao
{
    public partial class v_ImpressoraTermica : DevExpress.XtraEditors.XtraForm
    {
        string Modelo = (ConfigurationManager.AppSettings["Modelo"]);
        string Porta = (ConfigurationManager.AppSettings["Porta"]);
        string Ip = (ConfigurationManager.AppSettings["Ip"]);
        int iRetorno = 0; //Variável para retorno das chamadas
        public v_ImpressoraTermica()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja salvar as configurações para a impressora térmica nesta maquina?","SGS",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    Porta = cbxPortas.SelectedItem.ToString(); //pega a seleção da combo
                    Modelo = cbxModelos.SelectedItem.ToString(); //Pega a seleção do Combo
                    Ip = txtIP.Text.ToString();//Pega o ip do campo IP da impressora
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings.Add("Porta", Porta);
                    config.AppSettings.Settings.Add("Modelo", Modelo);
                    config.AppSettings.Settings.Add("Ip", Ip);
                    config.AppSettings.Settings["Porta"].Value = Porta;
                    config.AppSettings.Settings["Modelo"].Value = Modelo;
                    config.AppSettings.Settings["Ip"].Value = Ip;
                    /*Config.Save motodos:
                     Modified – Salva apenas as propriedades modificadas mesmo que o valor seja o mesmo contido no arquivo de configuração.
                     Minimal – Salva apenas as propriedades modificadas desde que os valores sejam diferentes dos valores contidos no arquivo de configuração.
                     Full – Salva todas as propriedades. 
                    */
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Configurações da impressora Térmica salvas com sucesso!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message, "SGS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnImprimirTextoSimples_Click(object sender, EventArgs e)
        {
             // \n - quebra de linha e \r retorno de impressão (comandos da impressora)
            iRetorno = MP2064.BematechTX(txtTextoSimples.Text + "\r\n\r\n");//ao ser clicado, imprime o texto da Text Box
        }

        private void btnTextoSimples_Click(object sender, EventArgs e)
        {
            txtTextoSimples.Text = "Exemplo de texto simples"; //ao ser clicado no botão altera o texto na Text Box
        }

        private void btnCaracterAcentuado_Click(object sender, EventArgs e)
        {
            txtTextoSimples.Text = "ãâéè?;:/{}[]ª|\','.<>!@#$%¨&*()_+=";//ao ser clicado no botão altera o texto na Text Box
        }

        private void btnCortarPapel_Click(object sender, EventArgs e)
        {
            //botão para cortar o papel
            if (radioButtonCorteTotal.Checked == true)//faz o teste através dos RadioButton para identificar se é corte total ou parcial
            {
                iRetorno = MP2064.AcionaGuilhotina(1);//chama a função da DLL(Corte Total)
            }
            else if (radioButtonCorteParcial.Checked == true)
            {
                iRetorno = MP2064.AcionaGuilhotina(0); //chama a função da DLL (Corte Parcial)
            }
            else
            {
                MessageBox.Show("Seleciona uma opção de corte!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {

            string porta = cbxPortas.SelectedItem.ToString(); //pega a seleção da combo 
            if (porta == "ETHERNET")
            {
                iRetorno = MP2064.IniciaPorta(txtIP.Text); //inicia a porta com o IP digitado
            }
            else
            {
                iRetorno = MP2064.IniciaPorta(cbxPortas.SelectedItem.ToString());//inicia a porta com o valor da combo (exceto ethernet)
            }

            if (iRetorno <= 0) //testa se a conexão da porta foi bem sucedido
            {
                MessageBox.Show("Não foi possível conectar com a impressora!","SGS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                gbxCortarPapel.Enabled = false;
                gbxImpressao.Enabled = false;
                btnImprimirTextoSimples.Enabled = false;
                btnSalvar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Impressora conectada!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbxCortarPapel.Enabled = true;
                gbxImpressao.Enabled = true;
                btnImprimirTextoSimples.Enabled = true;
                btnSalvar.Enabled = true;
            }
            //this.Close(); //após clicar em OK, fecha o formulário dpara configuração de porta e impressora
        }

        private void v_ImpressoraTermica_Load(object sender, EventArgs e)
        {
            CancelButton = btnSair;
            gbxCortarPapel.Enabled = false;
            gbxImpressao.Enabled = false;
            btnTeste.Enabled = false;
            txtIP.Enabled = false;
            btnImprimirTextoSimples.Enabled = false;
            btnSalvar.Enabled = false;
            // LOAD do Formulário para configuração de portas e Modelos de impressoras
            // carrega o combo com os modelos das impressoras
            cbxModelos.Items.Add("MP 20 CI");
            cbxModelos.Items.Add("MP 20 MI");
            cbxModelos.Items.Add("MP 20 TH");
            cbxModelos.Items.Add("MP 2000 CI");
            cbxModelos.Items.Add("MP 2000 TH");
            cbxModelos.Items.Add("MP 2100 TH");
            cbxModelos.Items.Add("MP 2500 TH");
            cbxModelos.Items.Add("MP 4000 TH");
            cbxModelos.Items.Add("MP 4200 TH");

            //carrega o combo com as portas
            cbxPortas.Items.Add("USB");
            cbxPortas.Items.Add("COM1");
            cbxPortas.Items.Add("COM2");
            cbxPortas.Items.Add("COM3");
            cbxPortas.Items.Add("COM4");
            cbxPortas.Items.Add("LPT1");
            cbxPortas.Items.Add("LPT2");
            cbxPortas.Items.Add("ETHERNET");
        }

        private void cbxModelos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modeloImp = cbxModelos.SelectedItem.ToString(); //Pega a seleção do Combo

            //testes para definir o código do modelo da impressora
            if (modeloImp == "MP 20 CI")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(1);
            }
            else if (modeloImp == "MP 20 MI")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(1);
            }
            else if (modeloImp == "MP 20 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(0);
            }
            else if (modeloImp == "MP 2000 CI")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(0);
            }
            else if (modeloImp == "MP 2000 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(0);
            }
            else if (modeloImp == "MP 2100 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(0);
            }
            else if (modeloImp == "MP 2500 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(8);
            }
            else if (modeloImp == "MP 4000 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(5);
            }
            else if (modeloImp == "MP 4200 TH")
            {
                iRetorno = MP2064.ConfiguraModeloImpressora(7);
            }


            cbxPortas.Enabled = true; //habilita a COMBO para seleção da porta

        }

        private void cbxPortas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPortas.SelectedItem.ToString() == "ETHERNET")
            {
                txtIP.Enabled = true;
            }
            btnTeste.Enabled = true;
        }
    }
}
