using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DelegateMulti
{
    class Program
    {
        // 델리게이트 CalcDelegate 타입은 2개의 정수를 전달하고, 반환값이 void인 메소드를 가리키는 타입을 정의
        delegate void CalcDelegate(int x, int y);

        void Plus(int x, int y) { Console.WriteLine("x + y ==>" + (x + y)); }
        void Minus(int x, int y) { Console.WriteLine("x - y ==>" + (x - y)); }
        void Multiple(int x, int y) { Console.WriteLine("x * y ==>" + (x * y)); }
        void Divide(int x, int y) { Console.WriteLine("x / y ==>" + (x / y)); }

        static void Main(string[] args)
        {
            Program program = new Program();
            // CalcDelegate 타입의 객체를 선언하고, 각각의 메소드를 델리게이트의 간단한 사용형식으로 연결
            CalcDelegate del1 = program.Plus;
            CalcDelegate del2 = program.Minus;
            CalcDelegate del3 = program.Multiple;
            CalcDelegate del4 = program.Divide;

            // 델리게이트 객체 del1에 del2, del3, del4를 차례로 추가
            del1 += del2;
            del1 += del3;
            del1 += del4;

            // 델리게이트 del1 객체에 (20, 10)을 넘겨주면
            // 누적 추가된 del2, del3, del4 객체에 동일하게 적용되어 각각 연결된 메소드를 호출
            del1(20, 10);

            // 누적된 del1 객체에서 del3, del4 객체를 차례로 삭제
            del1 -= del3;
            del1 -= del4;

            // 델리게이트 del1 객체에 (20, 10)을 넘겨주면
            // 누적 추가된 del3, del4 객체는 삭제되어 del1과 del2 객체만 적용
            del1(20, 10);

        }
    }
}
