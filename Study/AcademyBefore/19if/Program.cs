using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Test = 1;

            // 위부터 순서대로 셋중 하나만 실행됨!!
            if (Test < 10)
            {
                Console.WriteLine("Test는 10보다 작다");
            }

            else if (Test<= 10)
            {
                Console.WriteLine("Test는 10이다");
            }

            else 
            {
                Console.WriteLine("Test는 보다 크다");
            }


        }
    }
}
