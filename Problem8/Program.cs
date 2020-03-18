using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个半径r");
            double r = float.Parse(Console.ReadLine());
            double Pai = 3.1415926D;
            double perimeter = 2 * Pai * r;
            double area = Pai * r * r;
            Console.WriteLine("周长为：{0,0:f2}", perimeter);
            Console.WriteLine("半径为：{0,0:f2}", area);
            Console.ReadKey();
        }
    }
}
