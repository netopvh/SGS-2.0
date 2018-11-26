using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_EstruturaComissao
    {
        public int idestruturacomissao { get; set; }
        public string descricao { get; set; }
        public decimal porcentagemimob { get; set; }
        public decimal porcentagemcorretor { get; set; }
        public int status { get; set; }
        public string usuariocad { get; set; }

    }
}
