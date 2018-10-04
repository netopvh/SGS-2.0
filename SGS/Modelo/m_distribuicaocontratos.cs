using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public struct m_Distribuicaocontratos
    {
        public int iddistribuicaocontratos { get; set; }
        public int numerocontrato { get; set; }
        public int status { get; set; }
        public DateTime datadistribuicao { get; set; }
        public DateTime dataextravio { get; set; }
        public DateTime datacancelado { get; set; }
        public DateTime datadevolucao { get; set; }
        public DateTime datavenda { get; set; }
        public string usuariocad { get; set; }
        public int fk_corretor_distribuicaocontratos { get; set; }
        public int fk_loteamento_distribuicaocontratos { get; set; }



    }
}
