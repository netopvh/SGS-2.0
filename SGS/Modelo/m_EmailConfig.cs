using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_EmailConfig
    {
        public int idemailconfig { get; set; }
        public string smtphost { get; set; }
        public int smtpporta { get; set; }
        public bool smtpssl { get; set; }
        public bool smtpcredencialpadrao { get; set; }
        public string smtpemail { get; set; }
        public string smtpsenhaemail { get; set; }
        
    }
}
