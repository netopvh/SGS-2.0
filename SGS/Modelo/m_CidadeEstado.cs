using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_CidadeEstado
    {
        public int idestado { get; set; }
        public string nomeEstado { get; set; }
        public string uf { get; set; }

        public int idcidade { get; set; }
        public string nomeCidade { get; set; }
        public int fk_cidadeEstado { get; set; }



    }
}
