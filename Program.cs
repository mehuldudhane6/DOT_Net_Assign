using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main1(string[] args)
        {

            A a = new A();
            a.setI(101);
            Console.WriteLine(a.getI());

        }
        static void Main2(string[] args)
        {

            B b = new B();
            b.J = 10;
            Console.WriteLine(b.J);

        }

        static void Main(string[] args)
        {

            
            C.K = 922;
            Console.WriteLine(C.K);

        }
    }

    class A
    {
        private int i;

        public void setI(int i)
        {
            this.i = i;
        }

        public int getI()
        {
            return i;
        }
    }

    class B
    {
        private int j;
        public int J
        {
            set
            {
                if (value > 100)
                {
                    j = value;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }

            }
            get
            {
                return j;
            }
        }

    }

    class C {

        private static int k;
        public static int K
        {
            set
            {
                if (value > 100)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }

            }
            get
            {
                return k;
            }
        }
    }
}
