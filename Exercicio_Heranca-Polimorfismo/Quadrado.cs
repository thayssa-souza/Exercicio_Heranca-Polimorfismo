using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_Polimorfismo
{
    public class Quadrado : Forma
    {
        public double Lado {  get; set; }

        public override string CalcularArea()
        {
            return $"A área do quadrado é lado {Lado} * {Lado}";
        }
    }
}
