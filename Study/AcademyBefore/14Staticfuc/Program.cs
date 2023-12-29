using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player
{
    static public void PVP(Player _Left, Player _Right)
    {
        _Left.Dmg(_Right);
        _Right.Dmg(_Left);
    }

    private int Hp = 100;
    private int At = 10;

    public void Dmg(Player _player)
    {
        Hp -= _player.At;
    }
}

namespace _14Staticfuc
{
    internal class Program
    {
        // 이녀석도 클래스에 속한 정적 함수이다.
        static void Main(string[] args)
        {
            // 요녀석도 클래스의 정적 멤버함수, Console 클래스의 writeline 정적함수
            Console.WriteLine("Console.WriteLine은 정적 멤버 함수에용");

            Player Newplayer1 = new Player();
            Player Newplayer2 = new Player();
            // Player.Dmg(); < 멤버변수는 public이나 클래스 자체로는 호출이 안되고 객체화된 클래스로만 가능하다.
            Newplayer1.Dmg(Newplayer1); // <- 객체화된 클래스
            // 멤버변수가 public이더라도 
            // 사용하기 위해서는 new로 새로운 객체를 만들어줘야한다. 

            // 정적멤버변수와 마찬가지로 클래스에 속하지만 
            // 객체를 굳이 만들지 않아도 사용할 수 있는 함수
            // 정적 멤버 함수
            Player.PVP(Newplayer1, Newplayer2);

        }
    }
}

// 15 StaticClass
//      정적 클래스란 정적멤버변수와 정적멤버함수만을 가질 수 있는 클래스
static class StClass
{
    // 일반 멤버변수는 선언만 해도 오류가 남
    // int Test = 100;
}