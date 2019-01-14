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
    public partial class v_ControleVisaoAtendimentoPlantao : DevExpress.XtraEditors.XtraForm
    {
        public v_ControleVisaoAtendimentoPlantao()
        {
            InitializeComponent();
            MessageBox.Show("Este controle só funciona na maquina que estar com a tela visão de controle de atendimento do plantão aberta!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVoltarCorretorDaVez_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em Breve sai essa função aguardem!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProximoCorretorDaVez_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja passar o atendimento para o próximo corretor da lista? isso não vai pode ser disfeito!","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PassarVez();
            }
        }

        private void btnPauseSlider_Click(object sender, EventArgs e)
        {
            PauseSlider();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PassarVez()
        {
            v_VisaoAtendimentoPlantao v = Application.OpenForms["v_VisaoAtendimentoPlantao"] as v_VisaoAtendimentoPlantao;
            if (v != null)
            {
                v.PassarVez();
            }
        }
        private void PauseSlider()
        {
            v_VisaoAtendimentoPlantao v = Application.OpenForms["v_VisaoAtendimentoPlantao"] as v_VisaoAtendimentoPlantao;
            if (v != null)
            {
                v.StopSlider();
            }
        }
    }
}
