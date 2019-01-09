using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_Plantao
    {
        public int idplantao { get; set; }
        public string equipe { get; set; }
        public DateTime dataplantao { get; set; }
        public DateTime horainicial { get; set; }
        public DateTime horafinal { get; set; }
        public DateTime tempoporpessoa { get; set; }
        public string usuariocad { get; set; }
    }
}
