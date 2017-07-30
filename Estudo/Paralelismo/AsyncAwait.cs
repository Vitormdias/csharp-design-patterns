using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paralelismo
{
    class AsyncAwait
    {
        public static async Task<double> CalculaRaiz(double num)
        {
            return await Task.Run(() => Math.Sqrt(num));
        }

        public async static void ImprimeRaiz(double n)
        {
            Console.WriteLine(await CalculaRaiz(n));
        }
    }
}
