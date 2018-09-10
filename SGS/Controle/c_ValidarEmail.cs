using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGS.Controle
{
    public static class c_ValidarEmail
    {

        public static void ValidarEmail(DevExpress.XtraEditors.TextEdit TextBoxEmail)
        {
            string email = TextBoxEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {

            }
            else
            {
                MessageBox.Show("Email Inválido!", "SGS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TextBoxEmail.Text = string.Empty;
            }
        }
        

}

}
