namespace Exercicio_Heranca_Polimorfismo
{

    class Program
    {
        static void Main(string[] args)
        {
            var quadrado = new Quadrado();
            quadrado.Lado = 6;
            var resultadoQuadrado = quadrado.Lado * quadrado.Lado;
            Console.WriteLine(quadrado.CalcularArea());
            Console.WriteLine(resultadoQuadrado);

            Console.WriteLine("--------------------------");

            var retangulo = new Retangulo();
            retangulo.Largura = 9;
            retangulo.Altura = 4;
            var resultadoRetangulo = retangulo.Largura * retangulo.Altura;
            Console.WriteLine(retangulo.CalcularArea());
            Console.WriteLine(resultadoRetangulo);

            Console.WriteLine("--------------------------");

            var circulo = new Circulo();
            circulo.Raio = 9;
            var resultadoCirculo = Math.Pow(circulo.Raio, 2) * Math.PI;
            Console.WriteLine(circulo.CalcularArea());
            Console.WriteLine(resultadoCirculo);

            Console.WriteLine("--------------------------");

            var triangulo = new Triangulo();
            triangulo.Base = 7;
            triangulo.Altura = 4;
            var resultadoTriangulo = (triangulo.Base * triangulo.Altura) / 2;
            Console.WriteLine(triangulo.CalcularArea());
            Console.WriteLine(resultadoTriangulo);
        }
    }
}