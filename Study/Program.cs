using System;
using System.Threading;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int sync = 0;

            int ret = Interlocked.CompareExchange(ref sync, 1, 0);
            ret = Interlocked.CompareExchange(ref sync, 1, 0);



            float a = 0.0f;
            for(int i=0;i<10;++i)
                a += 0.1f;

            Console.WriteLine("Hello World!");
        }
    }
}
