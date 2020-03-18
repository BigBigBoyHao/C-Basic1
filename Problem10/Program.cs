using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a0 = 0;
            int a1 = 1;
            int a2 = 1;
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.Write(0);
            for (int i = 0; i<n ; i++)
            {
                Console.Write("{0,-4}",a0);
                a2 = a0 + a1;
                a0 = a1;
                a1 = a2;
                

            }
            Console.ReadKey();
        }
    }
}
