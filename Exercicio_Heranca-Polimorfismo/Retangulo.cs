using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Heranca_Polimorfismo
{
    public class Retangulo : Forma
    {
        public double Largura { get; set; }

        public double Altura { get; set; }

        public override string CalcularArea()
        {
            return $"A area do triângulo é: {Altura} * {Largura}";
        }
    }
}
