using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGS.Modelo;
using SGS.Controle;


namespace SGS.Visao
{
    public partial class v_Pendencias : DevExpress.XtraBars.TabForm
    {

        c_Pendencias c_pendencias;
        m_Pendencias m_pendendcias;
        c_Loteamento c_loteamento;
        m_Loteamento m_loteamento;
        c_Corretor c_corretor;
        m_Corretor m_corretor;

        public v_Pendencias()
        {
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendendcias = new m_Pendencias();
            InitializeComponent();
        }
        public v_Pendencias(string Usuario,int Permissao)
        {
            this.c_loteamento = new c_Loteamento();
            this.m_loteamento = new m_Loteamento();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
            this.c_pendencias = new c_Pendencias();
            this.m_pendendcias = new m_Pendencias();
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void v_Pendencias_Load(object sender, EventArgs e)
        {
           


        }

        private void tabFormContentContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
