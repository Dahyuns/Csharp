using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for (초기화문; 조건문; 증감문)
            //{
            //    실행코드
            //}
            // 함수 안에서만 사용가능, 함수 밖에서는 불가능
            // for문 필요없다. 
            // for문의 장점은 접근성

            // 한반에 변수를 선언후 초기화,
            // 그걸로 조건을 비교하고
            // 그 변수를 변화시키는 코드를 한줄에 다 담았다.
            for (int i = 0; i < 1; i++)
            { // 초기화문 -> 조건문 -> 실행코드 -> 증감문
                Console.WriteLine(i);
            }

            // 밖으로 빼는것도 된다~
            int x = 0;
            for (; x < 1; x++)
            { 
                Console.WriteLine(x);
            }


            // While문과 동일
            for ( ; ; ) // = for ( ; true ; )
            {
                Console.WriteLine(2);
            }
        }
    }
}
