using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            object o = i;
            // object o = object(i); // explicit boxing
            i = 43;
            Console.WriteLine("Value typed int i: " + i);
            Console.WriteLine("Object typed object o: " + o);

            A a = new A();
            a.MyProperty = 42;
            var b = a;
            b.MyProperty = 99;
            Console.WriteLine(a.MyProperty);

            int myInt = 42;
            int myInt2 = myInt;
            myInt2 = 99;
            Console.WriteLine(myInt);

            string str = "str";
            string str2 = str;
            str2 = "hohohaha";
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }

    class A { public int MyProperty { get; set; }}
}
