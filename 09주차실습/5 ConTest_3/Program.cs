using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ConTest_3
{
    class Date
    {
        public int year, month, day;
        public static bool IsLeapYear(int year)
        {   // 어떤 해가 윤년/평년인지 구하는 메소드
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        // days[] 배열은 전월의 마지막 날까지의 날짜수
        static int[] days = { 0, 31, 69, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DayOfYear()
        {   // 어떤 날이 1월 1일부터 며칠째 되는 날인지를 구하는 메소드
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date xmas = new Date();

            xmas.year = 2020;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas: {0}/{1}/{2}는 {3}일째 되는 날입니다.", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());

            if (Date.IsLeapYear(2020) == true)
                Console.WriteLine("2020년은 윤년입니다.");
            else
                Console.WriteLine("2020년은 평년입니다.");
        }
    }
}
