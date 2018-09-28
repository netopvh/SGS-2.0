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
    public partial class v_StatusContrato : DevExpress.XtraEditors.XtraForm
    {
        string _Usuario;
        public v_StatusContrato()
        {
            InitializeComponent();
        }
        public v_StatusContrato(string Usuario)
        {
            InitializeComponent();
            _Usuario = Usuario;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void v_StatusContrato_Load(object sender, EventArgs e)
        {

        }
    }
}
