using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate int CalcDelegate(int x, int y);

        static int Plus(int x, int y) { return x + y; }
        static int Minus(int x, int y) { return x - y; }

        static void Main(string[] args)
        {
            CalcDelegate del1 = new CalcDelegate(Plus);
            int result = del1(20, 10); // Plus() 호출
            Console.WriteLine("result = " + result);

            CalcDelegate del2 = new CalcDelegate(Minus);
            result = del2(20, 10); // Minus() 호출
            Console.WriteLine("result = " + result);
        }
    }
}
