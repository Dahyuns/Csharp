using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스의 공통되는 부분을 반복하지 않고 간편하게 사용하기 위해 (코드재활용성을 향상)
// 상속을 사용한다.
// FightUnit => Player, Monster
// class FightUnit
// class Player (전) => (후) class Player : FightUnit
// class Monster (전) => (후) class Monster : FightUnit

class FightUnit //부모(옮길베이스
{
    //       public  protected  private(디폴트)
    // 범위  외부까지 자식까지    나까지
    protected int AT = 10;
    protected int HP = 100;

    public void Damage(/*FightUnit this*/ FightUnit _OtherUnit)
    {
        // 나는 fightUnit이지만
        // 이 안에서 플레이어의 기능을 쓰고싶다
        // : 다운캐스팅 (하지만 최대한 지양하자,피하자)
        // 플레이어를 실수로 몬스터로 변경할수도 있다.

        this.HP -= _OtherUnit.AT;
    }
}

// 상속시킨다 라고 말함
// C#에서 클래스 상속은 오직 하나만 가능하다.
class Player : FightUnit //자식(옮겨지는곳
{
    // 각자 가지고 있어야 하는건 여기에 써준다!
    int Lv = 1;

    void Heal()
    {
        HP = 100;
    }
}

class Monster : FightUnit
{
    
}

namespace _23inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
            Monster NewMonster = new Monster();
            Newplayer.Damage(NewMonster);
            NewMonster.Damage(Newplayer);
        }
    }
}
