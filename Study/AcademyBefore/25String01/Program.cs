using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int At = 10;
    
    int GetAt()
    {
        return At;
    }

    void SetAt(int _Value)
    {
        if (_Value > 999) // 이렇게 써서 함수 내에서 오류발생을 예방할 수 있음 
        {
            Console.WriteLine("최대 수정치를 넘겼습니다.");
            while (true) { Console.ReadKey(); }
        }

        At = _Value;
    }
}


namespace _26Property25String01
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
