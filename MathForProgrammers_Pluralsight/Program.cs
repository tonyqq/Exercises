using System;

namespace MathForProgrammers_Pluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 1.4;
            double d2 = 1.25;

            Console.WriteLine("1.4 is stored as {0}", d1);
            Console.WriteLine("1.25 is stored as {0}", d2);

            // 1.4 can't be represented exactly in binray, so cumputer stores the closest number as it can
            Console.WriteLine("1.4 is stored as {0:G20}", d1);
            Console.WriteLine("1.25 is stored as {0:G20}", d2);

            Console.ReadKey();
        }
    }
}
