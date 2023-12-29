using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Hp = 100;

    public void Heal(/* [생략된것] newPlayer1, */int _heal)
    {
        // 멤버함수에서 멤버변수를 쓸때
        // 눈에 보이지는 않지만 
        // this가 생략된 것이다.
        // this.Hp => Hp
        Hp += _heal;
    }

    public static void Hurt1(int _dmg)
    {
        // 정적함수에서 Hp 호출이 안되는 이유
        // : this로 불러올 객체가 없음!!
        // Hp -= _dmg;
    }

    // 정적함수는 객체를 따로 불러줘야함, 자신이라는 개념이 없는 함수
    public static void Hurt2(Player _this,int _dmg)
    {
        _this.Hp -= _dmg;
    }
}

namespace _16This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            newPlayer.Heal(20);

        }
    }
}
