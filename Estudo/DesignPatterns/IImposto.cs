using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.StrategyPattern
{
    public interface IImposto
    {
        double Calcula(Orcamento orcamento);
    }
}
