using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int switchTest = 100;
            // 비교해서 맞는 조건으로 실행
            // switch는 == 연산밖에못함
            // 변수는 안됨
            switch (switchTest)
            {
                case 0:
                    Console.WriteLine("SwitchTest는 0입니다.");
                    break;
                case 1:
                    Console.WriteLine("SwitchTest는 1입니다.");
                    break;
                case 100:
                    Console.WriteLine("SwitchTest는 100입니다.");
                    break;
                case 1000:
                case 10000: // 겹쳐서 사용가능
                    Console.WriteLine("SwitchTest는 천 또는 만 입니다.");
                    break;
                default: // else의 역할을 한다.
                    Console.WriteLine("SwitchTest는 아무 조건도 안맞습니다.");
                    break;
            }
        }
    }
}
