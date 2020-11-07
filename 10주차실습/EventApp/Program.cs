using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Program
    {
        // 델리게이트 ButtonEvent 타입을 선언
        public delegate void ButtonEvent();
        //이벤트 델리게이트 ButtonEvent를 사용하여 선언
        public static event ButtonEvent evtClick;

        //onClick() 메소드 정의, 버튼 클릭 기능을 수행하기 위한 메소드
        public static void onClick()
        {
            evtClick(); // 델리게이트 객체 evtClick를 통해 연결된 메소드를 호출
        }

        // MyHandler() 메소드 정의, 버튼 클릭 이벤트 발생시 연결한 이벤트 처리기
        public static void MyHandler()
        {
            Console.WriteLine("버튼 클릭 처리기 수행");
        }

        static void Main(string[] args)
        {
            // 델리게이트 ButtonEvent 를 통해 이벤트 처리기 MyHandler를 evtClick이벤트에 등록
            evtClick += new ButtonEvent(MyHandler);
            onClick(); // 버튼을 실제로 클릭할 수 없었으므로 버튼이 클릭되었다고 가정하고 onClick() 메소드를 호출

        }
    }
}
