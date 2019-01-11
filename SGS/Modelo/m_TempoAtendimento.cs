using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_TempoAtendimento
    {
        public int idtempoatendimento { get; set; }
        
        public DateTime atendimentohorainicial { get; set; }
        public DateTime atendimentohorafinal { get; set; }
        public int fk_plantao_tempoatendimento { get; set; }
        public int fk_corretorplantao_tempoatendimento { get; set; }

    }
}
