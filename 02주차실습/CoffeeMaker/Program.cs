using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    class CoffeeMakeApp
    {
        public bool onState;
        public void StartCoffeeMaker()
        {
            if (onState == true)
            {
                Console.WriteLine("The coffeeMake is already on");
            }
            else
            {
                onState = true;
                Console.WriteLine("The coffeeMake is noew on");
            }
        }

        static void Main(string[] args)
        {
            CoffeeMakeApp st = new CoffeeMakeApp();
            st.onState = true;
            st.StartCoffeeMaker();
        }
    }
}
