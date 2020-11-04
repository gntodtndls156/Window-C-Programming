using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ConTest_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] name = { "Mouse", "Cow", "Tiger", "Rabiit", "Dragon", "Snake", "Horse" };
            PrintArray("Before Sort: ", name); // PrintArray() 메소드를 호출하여 출력

            Array.Reverse(name); // 배열 요소들의 순서를 뒤집고 배열의 내용을 출력
            PrintArray("After Reverse: ", name);

            Array.Sort(name); // 배열을 오름차순으로 정렬하고 배열의 내용을 출력
            PrintArray("After Sort: ", name);

            Array.Reverse(name);
            PrintArray("After Reverse: ", name);


        }

        private static void PrintArray(String s, string[] name)
        {
            Console.WriteLine(s);
            foreach (var n in name)
                Console.WriteLine("{0} ", n);
            Console.WriteLine();
        }
    }
}
