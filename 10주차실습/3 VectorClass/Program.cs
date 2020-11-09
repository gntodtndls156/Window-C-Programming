using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _3_VectorClass
{
    class Vector
    {
        private int[] v;

        public Vector(int size)
        {
            v = new int[size];
        }
        public int this[int index]
        {
            get { return v[index]; }
            set { v[index] = value; }
        }
        
        public static Vector operator ++(Vector vec)
        {
            for (int i = 0; i < vec.v.Length; i++)
                vec[i]++;
            return vec;
        }
        public static Vector operator --(Vector vec)
        {
            for (int i = 0; i < vec.v.Length; i++)
                vec[i]--;
            return vec;
        }

        static void Main(string[] args)
        {
            Vector vector = new Vector(5);

            for (int i = 0; i < 5; i++)
                vector[i] = 10 + i;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(vector[i] + " ");
            Console.WriteLine();

            vector++;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(vector[i] + " ");
            Console.WriteLine();

            vector--;
            for (int i = 0; i < 5; i++)
                Console.WriteLine(vector[i] + " ");
            Console.WriteLine();
        }
    }
}
