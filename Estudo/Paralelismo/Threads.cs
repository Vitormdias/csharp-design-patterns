using System;
using System.Threading;

namespace Paralelismo
{
    class Threads
    {
        public static long FatorialEmParalelo(int valor)
        {
            long resultado = 0;

            var t_calculo = new Thread(() => resultado = Fatorial(valor));
            t_calculo.Start();

            while(t_calculo.IsAlive)
            {
                Thread.Sleep(250);
            }

            return resultado;
        }

        public static void WriteList()
        {
            for (int i = 0; i < 100; i++)
            {
                var msg = "Thread número " + i;
                var thread = new Thread(() => Console.WriteLine(msg));
                thread.Start();
            }
        }

        private static long Fatorial(int valor)
        {
            var resultado = 1L;
            for (int i = valor; i >= 2; i--)
                resultado *= i;
            return resultado;
        }
    }
}