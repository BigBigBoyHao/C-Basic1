using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            char? c = null;
            for(int i = 0; i < 255; i++)
            {
                c = (char)i;
                Console.Write("{0,3}:{1,-3}",i,c);
                if (i % 8 == 0 && i != 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
