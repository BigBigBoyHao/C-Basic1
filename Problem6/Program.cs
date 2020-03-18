using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001d;
            Console.WriteLine("请输入第一个数：");
            double a =double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            double b =double.Parse(Console.ReadLine());
            
            bool Equal = false;
            if (Math.Abs(a - b) < eps)
                Equal = true;
            Console.WriteLine("两个数是否相等的结果为："+Equal);
            Console.ReadKey();
        }
    }
}
