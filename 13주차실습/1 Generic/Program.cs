using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Generic
{
    class Generic<T>
    {
        public Generic()
        {
            
        }
        public void PrintArray(int[] a)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 12; j > 0; j--)
                {
                    Console.Write(" ");
                    if (a[i].ToString().Length == j)
                    {
                        Console.Write("{0}", a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        public void PrintArray(double[] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 12; j > 0; j--)
                {
                    Console.Write(" ");
                    if (a[i].ToString().Length == j)
                    {
                        Console.Write("{0}", a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
        public void PrintArray(string[] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 12; j > 0; j--)
                {
                    Console.Write(" ");
                    if (a[i].ToString().Length == j)
                    {
                        Console.Write("{0}", a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
/*            
            Generic<Int32> intnumber = new Generic<Int32>(3);
            Generic<Double> doublenumber = new Generic<Double>(3);
            Generic<String> stringstr = new Generic<String>(3);
*/
/*
            intnumber.add(1, 2, 3);
            doublenumber.add(0.1, 0.2, 0.3);
            stringstr.add("tiger", "lion", "zebra");
*/
            Console.WriteLine("제네릭을 이용하여 int ,double, string 배열의 값 출력하기");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();

            Generic<Object> generic = new Generic<Object>();
            generic.PrintArray(new int[3] { 1, 2, 3 });
            generic.PrintArray(new double[3] { 0.1, 0.2, 0.3 });
            generic.PrintArray(new string[3] { "tiger", "lion", "zebra" });

        }
    }
}
