﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExeAdrieleDeboraIII.Models
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public string Categoria { get; set; }
    }
}