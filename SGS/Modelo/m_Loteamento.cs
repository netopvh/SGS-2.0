using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public struct m_Loteamento
    {
        public int idloteamento { get; set; }
        public string nome { get; set; }
        public string obra { get; set; }
        public string empresa { get; set; }
        public int status { get; set; }
        public DateTime datacad { get; set; }
        public string usuariocad { get; set; }


    }
}
