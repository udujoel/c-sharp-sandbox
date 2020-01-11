using System;

namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter x: ");
            string x = Console.ReadLine();

            Console.WriteLine("Enter y: ");
            string y = Console.ReadLine();

            string value = IsEqual(x, y) ? "Equal" : "Not Equal";

            Console.WriteLine(value);
           // Console.WriteLine();

        }

        static bool IsEqual<T>(T x, T y)
        {
            Console.WriteLine(typeof(T));
            return x.Equals(y);
        }
    }
}
