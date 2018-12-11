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
    public partial class v_ControlePlatao : DevExpress.XtraBars.TabForm
    {
        string _UsuarioCad;
        public v_ControlePlatao()
        {
            InitializeComponent();
        }
        public v_ControlePlatao(string UsuarioCad)
        {
            InitializeComponent();
            _UsuarioCad = UsuarioCad;
        }
    }
}
