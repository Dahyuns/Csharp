using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근제한 지정자를 입력하지 않으면
    // 디폴트로 private (= 밖에서 쓰고 싶으면 public을 달아줘야함!)
    // 디폴트가 private인 이유는? '다른 사람이 건들여서' 코드가 꼬이거나 할수있어서
    // 속성들은 외부에서 접근하지 못하게 하는게 일반적으로 좋기 때문
    int LV = 1;
    int Hp;

    // *** 플레이어의 레벨이 얼만지 알고싶을때 ***
    // 리턴 값 / 자신의 상태를 외부에 알려주는 용도로 사용
    // 알려주기 위함이므로 알려주는 순간 (그 아래의 코드는 무시) 함수는 종료된다.
    public int GetLV()
    {
        return LV;
        // return 아래 코드는 무시됨
        // Hp = 80000;
    }


    
    // '다른 사람이 건들이지 못하게' private으로 코딩할 수 있는 방법이 
    // 함수이다. 
    public void SetHP(int _HP)
    {
        // 장점 3. 이 안에서 내가 HP가 0이 되는 순간, 100이 되는 순간만 모두 체크할 수도 있고
        // 4. 가장 큰 핵심은 디버깅이 된다.
        Hp = _HP;
    }
    public int rtHp()
    {
        return Hp;
    }

    // 함수는 보통 선언과 내용으로 나뉘며 클래스 외부와의 소통을 위해서 만든다.
    // void[리턴값] Func[이름 혹은 식별자] ()[인자값]
    // 인자 값은 한개 또는 여러개를 넣을 수 있다.
    public void Damage1(int _dmg)
    {
        Hp = Hp - _dmg;
        LV += 1; //[다현]임의로 넣어봄 맞을때마다 레벨업하는ㅋㅋ
    }

    public void Damage3(int _dmg, int _subdmg, int _trdmg)
    {
        Hp = Hp - _dmg;
        Hp = Hp - _subdmg;
        Hp = Hp - _trdmg;
        LV += 2;
    }

    // < 위 함수 싹 합쳐부림> 데미지 + 입은 후의 체력을 리턴하는 함수!
    public int DmgToHpreturn(int _dmg)
    {
        Hp = Hp - _dmg;
        return Hp;
    }
}

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();

            Newplayer.SetHP(100);
            // Newplayer.HP = 10; 가 더 쉬운거 아닌가요?
            // ㄴ 장점이 몇가지 있는데 1. 클래스 함수에서 중단점을 이용할 수 있다.
            // 2. 들어온 값을 확인 할 수 있다. (현재 100)

            // 이런식으로 외부의 값(12,10,5,2)을 받아서 클래스 내부의 객체 상태를 
            // 변화시키기 위해서 함수를 선언하는 경우가 많다.
            Newplayer.Damage1(12);
            Newplayer.Damage1(40);
            Newplayer.Damage3(10, 5, 2);

            Console.WriteLine(Newplayer.rtHp());//Hp값리턴

            Console.WriteLine(Newplayer.GetLV()); //레벨리턴

            Console.WriteLine(Newplayer.DmgToHpreturn(5)); //데미지입히고Hp리턴

        }
    }
}
