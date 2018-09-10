using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public struct m_EmpresaLicenca
    {
        public int idempresalicenca { get; set; }
        public string nomeEmpresa { get; set; }
        public byte[] logomarca { get; set; }
        public string keyMD5 { get; set; }
        public string key1 { get; set; }
        public string key2 { get; set; }


    }
}
