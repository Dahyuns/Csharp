using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct StructData
{
    // 클래스와 비슷한데 리터럴 초기화가 안된다.
    // = 100 같은거 (리터럴 초기화)
    public int a;
    public int b;

    public void Func()
    {
        // 리터럴 초기화가 안되기 때문에 이렇게 해줘야함
        // = 0 이 기본이다.
        a = 100;
        b = 100;
    }
}

namespace _21Struct
{
    internal class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }

        static void TestNumber(int _Number)
        {
            _Number = 1000;
        }

        static void Main(string[] args)
        {
            StructData Newdata = new StructData();

            Newdata.a = 10;
            Newdata.b = 10;

            Test(Newdata); // 레퍼런스형 _안바뀜 

            int TestNewNumber = 100;
            TestNumber(TestNewNumber); // 값형 _안바뀜

            // 왜 둘다 안바뀌냐? struct는 구조체.
            // 구조체는 값형이다.
        
        }
    }
}
