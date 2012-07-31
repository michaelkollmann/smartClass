using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynctest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1");
            TestAsync();
            Console.WriteLine("3");
            Console.ReadKey();
        }

        private static void TestAsync()
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {

                Console.WriteLine("2");
                }
            });
        }
    }
}
