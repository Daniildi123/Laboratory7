using System;

namespace Laboratory7
{
    internal class Task1
    {
        public delegate int arithmetic(int x, int y);

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            arithmetic arithmetic = (x, y) => x + y;
            Console.WriteLine(arithmetic(t, p));
            arithmetic += (x, y) => x - y;
            Console.WriteLine(arithmetic(t, p));
            arithmetic += (x, y) => x * y;
            Console.WriteLine(arithmetic(t, p));
            arithmetic += (x, y) =>
            {
               int g = 0;
               try
               {
                  g = x / y;
               }
               catch(DivideByZeroException e)
               {
                  Console.WriteLine(e.Message);
               }
               return g;
            };
            Console.WriteLine(arithmetic(t, p));
        }
    }
}
