using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class Math
        {
            public static int abs(int i) { return 0; }
        }

        static void Main(string[] args)
        {
            Math.abs(-3);

            OtherClass oc = new OtherClass();

            Console.WriteLine("Hello World!");
        }

        class ThirdClass
        {

        }
    }

    class SecondClass
    {

    }
}