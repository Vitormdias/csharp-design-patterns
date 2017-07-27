using System;
using System.Threading.Tasks;

namespace Paralelismo
{
    class Tasks
    {
        public static long FatorialEmParalelo(int valor)
        {
            long resultado = 0;

            var task_calculo = Task.Factory.StartNew(() => resultado = Fatorial(valor));

            //Task.WaitAll(task_calculo);

            Task.WhenAll(task_calculo).ContinueWith(t =>
            {
                Console.WriteLine("Acabou o processamento");
            });

            return resultado;
        }

        public static void WriteList ()
        {
            for (int i = 0; i < 100; i++)
            {
                var msg = "Task número " + i;
                Task.Factory.StartNew(() => Console.WriteLine(msg));
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