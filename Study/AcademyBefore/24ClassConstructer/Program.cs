using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    protected int AT;

    public FightUnit()
    {
        int a = 0;
    }
}

class Player
{

    // 생성자라고 합니다.
    // 특징 : 리턴값이 없어요.
    // 생성자란 만들어질때 한번 실행되어주는 함수

    public Player()
    {
        int AT;
        int a = 0;
    }
}


namespace _24ClassConstructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
        }
    }
}
