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
    public partial class v_NovoPlantao : DevExpress.XtraEditors.XtraForm
    {

        c_Corretor c_corretor;
        m_Corretor m_corretor;

        public v_NovoPlantao()
        {
            InitializeComponent();
            this.c_corretor = new c_Corretor();
            this.m_corretor = new m_Corretor();
        }

        private void v_NovoPlantao_Load(object sender, EventArgs e)
        {

        }
    }
}
