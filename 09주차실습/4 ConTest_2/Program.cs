using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConTest_2
{
    class Product
    {
        public String name;
        public int price;
    }

    class MyMath
    {
        public static double PI = 3.14; // PI 변수는 static로 클래스 필드
    }

    class MyCalendar
    {
        //상수는 값이 컴파일 시간에 설정되며 변경할 수 없는 필드나 속성
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price); // price는 토화포맷(C)로 출력

            // PI는 static 이므로 객체생성하지 않고 바로 사용
            Console.WriteLine("원주율 : {0}", MyMath.PI);

            /*
             * MyCalendar 클래스에 정의된 상수 months 출력, 상수는 static 키워드가 없지만 객체 생성하지 않고 클래스 이름으로 사용할 수 있음.
             */
            Console.WriteLine("한달은 평균 {0:F3}일", MyCalendar.daysPerMonth);
        }
    }
}
