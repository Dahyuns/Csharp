using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    // 1. static을 붙히면 '정적 멤버변수'라고 한다.
    // 일반적인 멤버변수와 다르게 객체화를 하지 않고도 사용이 가능하다.
    // 클래스의 이름만으로 사용이 가능하다.
    // 메모리 중 "데이터"영역에 들어감.
    // 클래스 자체에 귀속 
    public static int PlayerCount = 0;

    // (일반)멤버변수, 객체 하나하나가 자신의 것을 갖는다.
    public int Hp;
    public int At;

    public void Setting(int _At, int _Hp)
    {
        At = _At;
        Hp = _Hp;
    }
}


// 3. static
      // 몬스터가 100마리 죽으면 뭔가 하기로 했을 때
class Monster
{
    int MonsterdeathConut = 0;
    static int MonsterdeathConutStatic = 0;

    public void MDC() //일반멤버변수사용
    {
        MonsterdeathConut += 1;
    }

    public void MDCS() //정적멤버변수사용
    {
        MonsterdeathConutStatic += 1;
    }

}

namespace _13StaticVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Player 3번 new를 하면 3개의 플레이어가 생긴 것.
            // 그 3개의 플레이어는 각각의 hp 를 가지고 있다.
            Player Newplayer1 = new Player();
            Player Newplayer2 = new Player();
            Player Newplayer3 = new Player();

            Player.PlayerCount = 1;
            Player.PlayerCount = 2;
            Player.PlayerCount = 3;
            // 2. '정적 멤버변수' 이런식으로 객체화를 하지 않고 사용할 수 있다.
            // + Newplayer3.PlayerCount 객체화된 클래스로 [사용 불가능] - 클래스 내부에선 사용가능
            // 객체 내부에서 사용할 수 있을 뿐, 객체의 개수만큼 만들어지는 것이 아닌 함수.
            // 즉, 모든 객체가 공유하는 하나의 변수



            // 4. 일반 멤버변수
            Monster Newmonster1 = new Monster();
            Monster Newmonster2 = new Monster();
            Monster Newmonster3 = new Monster();

            Newmonster1.MDC(); // MonsterdeathConut = 1 (Newmonster1.MonsterdeathConut = 1)
            Newmonster2.MDC(); // MonsterdeathConut = 1 (Newmonster2.MonsterdeathConut = 1)
            Newmonster3.MDC(); // MonsterdeathConut = 1 (Newmonster3.MonsterdeathConut = 1)
            // 몬스터 세마리를 죽였지만 세 몬스터의 세개로 객체화된 클래스 내부에서 각자 따로 계산됨.

            // 6. 정적 멤버변수 : 모든 클래스 공유됨
            Newmonster1.MDCS(); // MonsterdeathConutStatic = 1 (Newmonster1.MonsterdeathConutStatic = 1)
            Newmonster2.MDCS(); // MonsterdeathConutStatic = 2 (Newmonster2.MonsterdeathConutStatic = 2)
            Newmonster3.MDCS(); // MonsterdeathConutStatic = 3 (Newmonster3.MonsterdeathConutStatic = 3)

            // 멤버변수라고 하는 녀석은 각각 존재한다.


        }
    }
}
