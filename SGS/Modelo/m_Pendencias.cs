using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_Pendencias
    {
        public int idpendencias { get; set; }
        public string quadra { get; set; }
        public string lote { get; set; }
        public string nomecliente { get; set; }
        public int venda { get; set; }
        public string numerocontrato { get; set; }
        public string pendencia { get; set; }
        public int status { get; set; }
        public DateTime datavenda { get; set; }
        public DateTime datacadastro { get; set; }
        public DateTime datacadpendencia { get; set; }
        public DateTime datadevolucao { get; set; }
        public string usuariocad { get; set; }
        public int fk_corretor_pendencias { get; set; }
        public int fk_loteamento_pendencias { get; set; }

        public m_Pendencias()
        {

        }

    }
}
