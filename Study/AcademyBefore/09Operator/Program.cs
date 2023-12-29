using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // [ 연산자 ]
            // 오른쪽 " + " 부터 실행된 후 결과 " = " 가 생성됨.
            // 0으로 나누거나 나머지를 구하는 식은 오류가 납니다. 사용XX
            int Result = 0;
            Result = 7 + 3;

            // [ bool 논리 연산자 ]
            bool BResult = true;
            // 조건부 논리 AND 연산자 && _ 모두 참이면 참
            BResult = true && true;  // T
            BResult = true && false; // F

            // 조건부 논리 OR 연산자 ||  _ 하나가 참이면 참
            BResult = true || false;  // T
            BResult = false || false; // F

            // 논리 배타적 OR 연산자 ^ [XOR]_ 양쪽이 다르다면 참, 같다면 거짓
            BResult = true ^ false;

            // 논리 부정(!) _ 참이면 거짓, 거짓이면 참
            BResult = !true;
            BResult = !false;

            // [ 축약 연산자 ]
            // += -= *= /=
        }
    }
}
