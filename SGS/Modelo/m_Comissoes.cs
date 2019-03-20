using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_Comissoes
    {
        public long idcomissoes { get; set; }
        public string NomeCliente { get; set; }
        public string empresa { get; set; }
        public string venda { get; set; }
        public string obra { get; set; }
        public string quadra { get; set; }
        public string lote { get; set; }
        public DateTime DataVenda { get; set; }
        public string corretor_pf { get; set; }
        public DateTime datacadvenda { get; set; }
        public decimal valorvenda { get; set; }
        public string statusvenda { get; set; }
        public string tipoparcela { get; set; }
        public int parcelacomissao { get; set; }
        public int totalparcelacomissao { get; set; }
        public DateTime vencimentoparcela { get; set; }
        public DateTime recebimentoparcela { get; set; }
        public decimal valorparcela { get; set; }
        public decimal porcentagemimob { get; set; }
        public decimal comissaoimob { get; set; }
        public decimal porcentagemcorretor { get; set; }
        public decimal comissaocorretor { get; set; }
        public int statuscomissao { get; set; }
        public DateTime datapagamentocomissao { get; set; }
        public string descricaocomissao { get; set; }
        public string usuariocad { get; set; }
        public DateTime datacadcomissao { get; set; }
        public int fk_empresacorretor_comissoes { get; set; }
        public int fk_notafiscalcomissao_comissoes { get; set; }

    }
}
