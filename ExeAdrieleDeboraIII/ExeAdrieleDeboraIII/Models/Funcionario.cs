using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExeAdrieleDeboraIII.Models
{
    public class Funcionario
    {
        public int IdFunc { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }

        public Funcionario SelectFunc() 
        { 
            Funcionario func = new Funcionario();
            return func;
        }
    }
}