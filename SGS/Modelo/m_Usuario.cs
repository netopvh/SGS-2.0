﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGS.Modelo
{
    public class m_Usuario
    {
        public int idusuario { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int status { get; set; }
        public int fk_permissao_usuario { get; set; }

        public m_Usuario()
        {

        }
    }
}
