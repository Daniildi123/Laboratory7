using System;

namespace Task3
{
    internal class Task3
    {
        public delegate int Delegation(int x, int y, int o);
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Delegation delegation = (x, y, o) => x * y * o / 3;
            Console.WriteLine(delegation(t, p, y));
        }
    }
}
