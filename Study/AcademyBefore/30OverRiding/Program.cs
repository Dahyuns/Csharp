using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class FightUnit
{
    protected string Name = "Name";
    protected int At = 10;
    protected int Hp = 100;

    // 업캐스팅
    public void Damage(FightUnit _Other)
    {
        Console.WriteLine(Name+ "에게 " + _Other.At + "만큼의 데미지를 입었습니다.");
        Hp -= _Other.At;
    }
}

class Player : FightUnit 
{
    int ItemAt;

    public Player(string _Name)
    {
        Name = _Name;
    }

}

class Monster : FightUnit
{

    public Monster(string _Name)
    {
        Name = _Name;
    }

}

namespace _30OverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player("다현");
            Monster Newmonster = new Monster("트롤");
            Newplayer.Damage(Newmonster); // << 업캐스팅
            Newmonster.Damage(Newplayer); // << 업캐스팅
            //위 코드에서 player 객체는 Player 클래스의 객체이지만,
            //FightUnit 타입의 변수 enemy에 대입되어 Damage() 메서드가 호출되었기 때문에,
            //player 객체가 FightUnit 클래스 타입으로 업캐스팅되어 Damage() 메서드가 호출된 것입니다.
        }
    }
}
