using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("请输入汉诺塔碟数");
            int num = int.Parse(Console.ReadLine());
            program.hanoi(num, 'A', 'B', 'C');
            Console.Read();
            Console.Read();
        }
        void hanoi(int n, char a, char b, char c)
        {

            if (n > 0)
            {
                hanoi(n - 1, a, c, b);
                move(a, b);
                hanoi(n - 1, c, b, a);
            }
        }
        void move(char a, char b)
        {
            Console.WriteLine("{0}-->{1}", a, b);
        }
    }
}
