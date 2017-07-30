using System;

namespace CursoDesignPatterns.StrategyPattern
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double result = imposto.Calcula(orcamento);
            Console.WriteLine(result);
        }
    }
}
