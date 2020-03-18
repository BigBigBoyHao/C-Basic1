using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            DateTime beforDT = System.DateTime.Now;


            if (n < 5 || n > 39 || n % 2 == 0)
                Console.WriteLine("您快坐下吧，不合适吧！");
            else
            {
                int N = 3 * n + 2;
                char dot = '.';
                char asterisk = '*';
                string dotstr = null;
                string aststr = null;
                for (int i = 0; i < n; i++)
                {
                    dotstr = dotstr + dot;
                    aststr = aststr + asterisk;
                }
                aststr = aststr + "**";

                //第一部分
                for (int i = 0; i < (n + 1) / 2 + 1; i++)
                {
                    for (int j = 0; j < (N - 1) / 2 - i; j++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = 0; j < 2 * i - 1; j++)
                        Console.Write(dot);
                    if (i > 0)
                        Console.Write(asterisk);
                    for (int j = 0; j < (N - 1) / 2 - i; j++)
                        Console.Write(dot);
                    Console.WriteLine();
                }

                //第二部分
                for (int i = 0; i < n; i++)
                    Console.Write(asterisk);
                for (int i = 0; i < N - 2 * n; i++)
                    Console.Write(dot);
                for (int i = 0; i < n; i++)
                    Console.Write(asterisk);
                Console.WriteLine();

                //第三部分
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = -1; j < i; j++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int k = 0; k < N - 2 * (i + 1) - 2; k++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = -1; j < i; j++)
                        Console.Write(dot);
                    Console.WriteLine();
                }

                //第四部分
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = i; j < n / 2 - 1; j++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = 0; j < n / 2; j++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = i; j > 0; j--)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    Console.Write(dotstr);
                    Console.Write(asterisk);
                    for (int j = i; j > 0; j--)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = 0; j < n / 2; j++)
                        Console.Write(dot);
                    Console.Write(asterisk);
                    for (int j = i; j < n / 2 - 1; j++)
                        Console.Write(dot);
                    Console.WriteLine();
                }

                //第五部分

                for (int i = 0; i < n / 2 + 1; i++)
                    Console.Write(asterisk);
                for (int i = 0; i < n / 2; i++)
                    Console.Write(dot);
                Console.Write(asterisk);
                Console.Write(dotstr);
                Console.Write(asterisk);
                for (int i = 0; i < n / 2; i++)
                    Console.Write(dot);
                for (int i = 0; i < n / 2 + 1; i++)
                    Console.Write(asterisk);
                Console.WriteLine();

                //第六部分
                for (int i = 0; i < n; i++)
                {
                    Console.Write(dotstr);
                    Console.Write(asterisk);
                    Console.Write(dotstr);
                    Console.Write(asterisk);
                    Console.Write(dotstr);
                    Console.WriteLine();
                }
                Console.Write(dotstr);
                Console.Write(aststr);
                Console.Write(dotstr);
                Console.WriteLine();
            }

            //计时
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("总共花费{0}ms.", ts.TotalMilliseconds);

            Console.ReadKey();


        }
    }
}
