using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Peticion
    {
        public Peticion(string codigo, string color)
        {
            Codigo = codigo;
            Color = color;
        }

        public string Codigo { get; set; }
        public string Color { get; set; }

    }
}
