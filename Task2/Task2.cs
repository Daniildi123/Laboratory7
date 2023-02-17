using System;

namespace Task2
{
    internal class Task2
    {
        public delegate int MyDel();

        public static int Methods(MyDel[] array)
        {
            int x = 1;
            foreach (MyDel del in array)
            {
                x *= del();
            }
            x /= array.Length;
            Console.WriteLine(x);
            return x;
        }

        public int ForArray()
        {
            Random rnd = new Random();
            int x = rnd.Next(1,10);
            Console.WriteLine(x);
            return x;
        }

        static void Main(string[] args)
        {
            Task2 task = new Task2();
            MyDel del = task.ForArray;
            MyDel del2 = task.ForArray;
            MyDel[] dels = new MyDel[2];
            dels[0] = del;
            dels[1] = del2;
            Methods(dels);
        }
    }
}
