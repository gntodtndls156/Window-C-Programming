using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _2_ThreadCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("주 스레드 시작 ");
            ThreadStart ts = new ThreadStart(ThreadFunction);

            Thread t = new Thread(ts);

            t.Start();
            Console.WriteLine("스레드 우선순위 " + t.Priority);
            Console.WriteLine("스레드 시작 " + t.ThreadState + " " + t.GetHashCode());
            Console.WriteLine("주 스레드 종료 ");
            Thread.Sleep(1000);
            // t.Abort(); // 스레드 강제종료
            Thread.Sleep(3000);
            t.Resume();
            Console.WriteLine("스레드 다시 시작 ");
            t.Join(); // 스레드가 다 실행될때까지 기다렸다가 종료시키므로 매우 안정적    
        }

        public static void ThreadFunction()
        {
            try
            {
                int count = 0;
                while(count < 500)
                {
                    count++;
                    Console.WriteLine("스레드 동작 중 ...." + count);
                }
                Console.WriteLine("정상종료");
            } catch (ThreadAbortException e)
            {
                Console.WriteLine("Abort 예외 발생 " + e);
            } finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("스레드 식별 : " + Thread.CurrentThread.GetHashCode());
        }
    }
}
