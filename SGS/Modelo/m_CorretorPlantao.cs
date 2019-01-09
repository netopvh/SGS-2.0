using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_CorretorPlantao
    {
        public int idcorretorplantao { get; set; }
        public int posicao { get; set; }
        public string nomecorretor { get; set; }
        public int fk_plantao_corretorplantao { get; set; }


    }
}
