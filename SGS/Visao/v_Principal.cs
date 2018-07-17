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
        public v_Principal()
        {
            InitializeComponent();
        }

        private void bbiCorretor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            v_Corretor v_corretor = new v_Corretor();
            v_corretor.ShowDialog();
        }
    }
}
