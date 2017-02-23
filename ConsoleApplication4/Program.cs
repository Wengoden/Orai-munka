using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class A
    {
        public void S1(string[] args)
        {
            Console.WriteLine("A::S1");
            V1();
        }

        protected void V1()
        {
            Console.WriteLine("A::V1");
            S3();
        }

        public void S2()
        {
            Console.WriteLine("A::S2");
            S1();
        }

        public void S3()
        {
            Console.WriteLine("A::S3");
        }
    }
}
