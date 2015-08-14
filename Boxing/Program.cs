using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;

            object o = i;

            i = 43;

            Console.WriteLine("Value typed int i: " + i);
            Console.WriteLine("Object typed object o: " + o);
            Console.ReadKey();
        }
    }
}
