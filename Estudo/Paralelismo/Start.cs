using System;

namespace Paralelismo
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 1");

            Console.WriteLine(Tasks.FatorialEmParalelo(5));
            
            Console.WriteLine("Aula 2");

            Console.WriteLine(Threads.FatorialEmParalelo(5));
            
            Console.Write("Press any key to end...");
            Console.ReadKey(true);
        }
    }
}
