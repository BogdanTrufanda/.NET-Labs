using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public int Prim1()
        {
            int numar = 5;
            for (int x = numar - 1; x > 0; x--)
            {
                int contor = 0;
                for (int y = 2; y <= x; y++ )
                {
                    if (x % y == 0)
                        contor++;
                }
                if (contor < 2)
                    return x;
            }
            return 2;
           
        }
        public int Prim2()
        {
            int maxim = 0, numar = 5;
            for (int x = 1; x < numar ; x++)
            {
                int contor = 0;
                for (int y = 2; y <= x; y++)
                {
                    if (x % y == 0)
                        contor++;
                }
                if (contor < 2)
                    maxim = x;
                    
            }
            return maxim;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int prim1 = obj.Prim1();
            int prim2 = obj.Prim2();

            Console.WriteLine(prim1);
            Console.WriteLine(prim2);
            //Thread thread1 = new Thread(new ThreadStart(obj.Prim1));
            //Thread thread2 = new Thread(new ThreadStart(obj.Prim2));
            //thread1.Start();



        }
    }
}
