using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_Atendimento
    {
        public int idatendimento { get; set; }
        public string nomeCliente { get; set; }
        public string telefone { get; set; }
        public string atendimentoAnterior { get; set; }
        public string identificador { get; set; }
        public string localizou { get; set; }
        public string comprou { get; set; }
        public string cidadeUF { get; set; }
        public string corretorAtual { get; set; }
        public string empreendimento { get; set; }
        public string usuariocad { get; set; }
        public DateTime dataAtendimento { get; set; }
        public DateTime dataCompra { get; set; }



    }
}
