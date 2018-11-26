using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Visao.Relatorios
{
    public partial class v_PendenciasRelatorio : Form
    {
        public v_PendenciasRelatorio()
        {
            InitializeComponent();
        }

        private void v_Pendencias_Load(object sender, EventArgs e)
        {
            r_Pendencias report = new r_Pendencias();
            documentViewer1.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
    }
}
