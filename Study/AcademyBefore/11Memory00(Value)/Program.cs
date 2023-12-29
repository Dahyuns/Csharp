using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

class Player
{
    public int Test(int A)
    {
        A = 1000;

        return A;
    }
}
namespace _11Memory01_Value_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player(); 
            int Value = 0;
            Newplayer.Test(Value);

            // Value의 출력값은?
            // 0이다 / 1000이다
            Console.WriteLine(Value); // Value = 0이 나온다.
                                      // 왜일까? 이것을 이해하려면 값과 위치에 대해 이해해야한다.(첨부_램사진)  

            // 그렇다면 함수에서 나온 값이 밖에 영향을 주고 싶다면?
            // 지금까지 배운 걸론 불가능함.

            // 함수에서 나온 값을 '리턴'한 후, 밖에서 한번 더 적용시켜야한다
            Value = Newplayer.Test(Value); 
            Console.WriteLine(Value); // Value = 1000
        }
    }
}
