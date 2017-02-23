using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    public class B : A
    {
        protected void S4()
        {
            Console.WriteLine("B::V1");
            V1();
        }

        public void S5()
        {
            Console.WriteLine("B::S3");
            S3();
        }

        protected void S3()
        {
            Console.WriteLine("B::S3");
        }

        public void V2()
        {
            Console.WriteLine("B::V2");
            V1();
        }

        private void V1()
        {
            Console.WriteLine("B::V1");
            S5();
        }
    }
}