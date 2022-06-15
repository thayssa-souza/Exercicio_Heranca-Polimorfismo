using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_Polimorfismo
{
    public class Triangulo : Forma
    {
        public decimal Base { get; set; }
        public decimal Altura { get; set; }

        public override string CalcularArea()
        {
            return $"A area do triangulo é: ({Altura} * {Base}) / 2";
        }
    }
}
