using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자
    //'필요한것만 공개/공유한다'
    /*  int Att;
        int Hp;
        int Def; */

    // 이렇게 세가지 접근제한 지정자가 존재한다.
    public int Att; // 공개
    public int Hp; // 자식에게만 공개
    protected int Mp; // 자식에게만 공개
    private int Def; // 내부에만 공개

    void Fight()
    {
        Console.WriteLine("싸운다.");
    }

    // 접근제한 지정자!! 함수도 마찬가지로 설정해준다.
    public void Run()
    {
        Console.WriteLine("달린다!");
    }

}

namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름+ . 을 사용한다.
            // 클래스 내부의 함수가 안나오는 이유 : 접근제한 지정라는 문법을 사용하지 않아서
            // 외부에 공개하지 않기로 함
            //NewPlayer.Fight();

            // 공개로 설정한 접근제한 지정자
            NewPlayer.Att = 1000; // 잘 나옴!

            // 하지만 공개되면 다른 사람도 쓰게될수 있다.(버그가날수있음)
            // 고로. '잘못쓰기도 힘들게 만들어라'
            NewPlayer.Hp = 0;

            // 접근제한 지정자를 설정한 함수- 잘나옵니당
            NewPlayer.Run();

        }
    }
}
