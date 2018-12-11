using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_DistribuicaoFolhasAvulsas
    {
        public int iddistribuicaofolhasavulsas { get; set; }
        public string folhapagina { get; set; }
        public int status { get; set; }
        public DateTime datadistribuicao { get; set; }
        public DateTime datacancelado { get; set; }
        public DateTime datadevolucao { get; set; }
        public string formapagamento { get; set; }
        public decimal valorfolha { get; set; }
        public string usuariocad { get; set; }
        public int fk_corretor_distribuicaofolhasavulsas { get; set; }
        public int fk_loteamento_distribuicaofolhasavulsas { get; set; }


    }
}
