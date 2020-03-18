using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数a:");
            int a = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2);
            int a2 = int.Parse(binary);
            Console.WriteLine("请输入一个浮点数b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个浮点数c:");
            double c = double.Parse(Console.ReadLine());
            
            Console.Write("|");
            Console.Write("{0,-10:X}", a);
            Console.Write("|");
            Console.Write("{0:d10}", a2);
            Console.Write("|");
            Console.Write("{0,10:0.##}", b);
            Console.Write("|");
            Console.Write("{0,10:0.000}", c);
            Console.Write("|");
            Console.ReadKey();

        }
    }
}
