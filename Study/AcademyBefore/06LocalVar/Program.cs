using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 멤버변수 -> '클래스 내부에 있다' , 밖에서 사용가능
    int Att;
    int Hp;

    void Fight()
    {
        Console.WriteLine("플레이어가 싸워요");
    }
}// 게임에서 사용하기 위해서 여기까지 설계했다~

namespace _06LocalVar
{
    // c#은 고지식한 객체지향 언어. 클래스밖에 모르는 바보!!
    // 프로그램의 시작조차도 클래스 안에 묶어놓음
    class Program
    {
        // 시작용 함수
        static void Main(string[] args)
        {
            // 지역변수 -> '함수 안에' 있는 녀석들 
            //  ㄴ 규칙:함수 내부에서만 사용가능,사용되는순간 메모리화됨, 함수가 끝난 후 사라짐
            int ATT = 0 ;
            ATT = 50 ;

            // (아래)객체화라고 하는 굉장히 중요한 작업.
            // 클래스는? 설계도이다. 위쪽에 만들어둔 class Player.(설계도)
            // (class)Player의 설계대로 다른 여러 플레이어를 만들 수 있다.
            // 이름 Newplayer1으로 만듬
            Player Newplayer1 = new Player();
            // 이름 Newplayer2으로 만듬
            Player Newplayer2 = new Player(); /*-> 설계도로 여러개를 만들 수 있음*/
            

            // (출력예시였던것)Console.WriteLine("지역변수를 공부해봅시다.");
        }
    }
}
