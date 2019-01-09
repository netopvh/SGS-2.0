using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Controle;
using SGS.Modelo;


namespace SGS.Visao
{
    public partial class v_NovaComissao : DevExpress.XtraEditors.XtraForm
    {

        string _UsuarioCad;
        m_Comissoes m_comissoes;
        c_Comissoes c_comissoes;
        m_Loteamento m_loteamento;
        c_Loteamento c_loteamento;


        public v_NovaComissao()
        {
            InitializeComponent();
        }

        private void v_NovaComissao_Load(object sender, EventArgs e)
        {

        }
        private void CarregarCorretores()
        {

        }
        private void CarregarEmpreendimentos()
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
