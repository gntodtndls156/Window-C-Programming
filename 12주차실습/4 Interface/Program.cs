using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface
{ 
    interface ICamera
    {
        void Picture();
        void Vide();

    }
    interface ICallPhone
    {
        void Call();
    }
    interface INetwork
    {
        void Wifi();
    }

    class SmartPhone : ICamera, ICallPhone, INetwork
    {
        public void Picture()
        {
            Console.WriteLine("사진 찍기");
        }
        public void Vide()
        {
            Console.WriteLine("동영상 촬영하기");
        }
        public void Call()
        {
            Console.WriteLine("전화 걸기");
        }
        public void Wifi()
        {
            Console.WriteLine("와이파이 연결하기");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone();
            smartPhone.Picture();
            smartPhone.Vide();
            smartPhone.Call();
            smartPhone.Wifi();
        }
    }
}
