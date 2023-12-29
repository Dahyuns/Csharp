using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// 한쪽이 죽을때까지 싸우기
// 한쪽이 죽으면 나간다/ 마을로 나간다

class FightUnit 
{
    protected string Name;
    protected int Hp = 50;
    protected int MaxHp = 100;
    protected int Att = 10;

    public int GetHp()
    {
        return Hp;
    }

    public void SetName(string _Name)
    {
        Name = _Name;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAtt()
    {
        return Att;
    }

    public void StatusRender()
    {
        Console.WriteLine(" -----------------" + Name + "------------------ ");
        Console.Write(" 공격력 : "); // Write - WriteLine (한줄띄우기 차이)
        Console.WriteLine(Att);
        Console.Write(" 체력 : ");
        Console.WriteLine(Hp + "/" + MaxHp);
        Console.WriteLine(" ------------------------------------------- ");
    }

    public virtual int Dmg(FightUnit _OtherUnit)
    {
        return Hp;
    }
    
    /*public bool IsDeath()
    {
        return Hp <= 0 ;
    }*/
}

class Player : FightUnit
{
    int RfCount = 0; // 강화횟수

    public int MaxHeal()
    {
        if (Hp < MaxHp)
        {
            Hp = MaxHp;
            Console.WriteLine(" Hp 를 회복했습니다.  ");
            return Hp;
        }
        else if (Hp >= MaxHp)
            Console.WriteLine(" 더 이상 회복 할 수 없습니다. ");

        return 0;
    }

    public void Heal()
    {
        if (Hp < MaxHp)
        {
            Hp += 10;
            Console.WriteLine(" Hp ( +10 ) 를 회복했습니다.  ");
        }
        else if (Hp >= MaxHp)
            Console.WriteLine(" 더 이상 회복 할 수 없습니다. ");
    } // 사용안함

    public void Reinforce()
    {
        if (RfCount < 5)
        {
            Console.WriteLine(" 공격력 ( +1 ) 이 올랐습니다. \n ");
            Att += 5;
            RfCount += 1;
            Console.WriteLine(" 현재강화횟수 " + RfCount + "번");
        }

        else if (RfCount >= 5)
            Console.WriteLine(" 현재강화횟수 " + RfCount + "번, 더 이상 강화 할 수 없습니다. ");
    }

    public Player()
    {
        Name = "플레이어";
    }

    public override int Dmg(FightUnit _OtherUnit)
    {
        Console.WriteLine(" [ " + Name + "가 " + _OtherUnit.GetAtt() + "의 피해를 입었습니다.]");
        Hp -= _OtherUnit.GetAtt();
        return Hp;
    }

    public void ResetPl()
    {
        Hp = 50;
        Att = 10;
        RfCount = 0;
    }
}

class Monster : FightUnit
{
    // 인자값을 만들어 줄 수도 있다.
    public Monster(string _Name) 
    {
        Name = _Name;
    }

    public override int Dmg(FightUnit _OtherUnit)
    {
        Console.WriteLine(" [ "+ Name + "가 " + _OtherUnit.GetAtt() + "의 피해를 입었습니다.]");
        Hp -= _OtherUnit.GetAtt();
        return Hp;
    }
}

enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    SELECTLOGOUT,
    SELECTNONE
}

// ConsoleKeyInfo KeyInfo = Console.ReadKey();

namespace TextRPG001
{
    internal class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine(" 게임을 시작합니다. (아무키나눌러주세용) ");
            Console.ReadKey();
            Console.WriteLine(" \n어디로 가시겠습니까?\n");
            Console.WriteLine(" 1. 마을로 간다. ");
            Console.WriteLine(" 2. 사냥터로 간다. ");
            Console.WriteLine(" 3. 종료한다. \n");
            ConsoleKeyInfo CKI = Console.ReadKey();
            Console.WriteLine(" 번을 선택하셨습니다.\n");
            switch (CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine(" 마을로 이동합니다.\n");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;

                case ConsoleKey.D2:
                    Console.WriteLine(" 배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;

                case ConsoleKey.D3:
                    Console.WriteLine(" 게임을 종료합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTLOGOUT;

                default:
                    Console.WriteLine(" 잘못된 선택입니다.1");
                    Console.ReadKey();
                    return STARTSELECT.SELECTNONE;
            }
        }

        static STARTSELECT Town(Player _player)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine(" 마을에 도착했습니다.\n\n 어떤일을 하시겠습니까? \n");
                Console.WriteLine(" 1. 여관에 들른다. ");
                Console.WriteLine(" 2. 무기를 강화한다. ");
                Console.WriteLine(" 3. 마을에서 나간다. \n");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // Hp = MaxHp
                        _player.MaxHeal();
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2: // 공격력 증가 +1
                        _player.Reinforce();
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" 마을에서 나갑니다... ");
                        Console.ReadKey();
                        return STARTSELECT.SELECTNONE; // While 문 종료시킴
                }
            }
        }

        static STARTSELECT Battle(Player _player, Monster _monster)
        {
            Console.Clear();
            Console.WriteLine(" \n\n  < 싸움터에 도착했습니다. > \n\n ");
            Console.ReadKey();

            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                _monster.StatusRender();
               
                Console.WriteLine("\n " + _monster.GetName() + "가 등장했다! ");
                Console.WriteLine(" \n 어떻게 하시겠습니까?\n ");
                Console.WriteLine(" 1. 공격한다. ");
                Console.WriteLine(" 2. 숨는다. ");
                Console.WriteLine(" 3. 도망친다. \n");

            
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        int Php = _player.Dmg(_monster);
                        int Mhp = _monster.Dmg(_player);
                        if (Php <= 0)
                        {
                            Console.WriteLine("\n " + _player.GetName() + "의 눈앞이 깜깜해졌습니다.");
                            Console.WriteLine("\n [ 실 패 ] 마을로 이동합니다.");
                            _player.ResetPl();
                            Console.ReadKey();
                            return STARTSELECT.SELECTTOWN;
                        }
                        else if (Mhp <= 0)
                        {
                            Console.WriteLine("\n " + _monster.GetName() + "을 해치웠습니다.");
                            Console.WriteLine("\n [ 성 공 ] 시작화면으로 이동합니다.");
                            Console.ReadKey();
                            return STARTSELECT.SELECTNONE;
                        }
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine(" 아무일도 없었습니다. ");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine(" 싸움터에서 도망칩니다... ");
                        Console.ReadKey();
                        return STARTSELECT.SELECTNONE; // While 문 종료시킴
                }                
            }
        }
       
        static void Main(string[] args)
        {
            // 마을과 싸움터 입장
            // 반복문 조건문
            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            Console.WriteLine(KeyInfo.Key);

            Player NewPlayer = new Player();
            Monster NewMonster = new Monster("오크");

            STARTSELECT SelectCheck = STARTSELECT.SELECTNONE;

            while (true)
            {
                /*STARTSELECT FirstSelect = StartSelect();*/
                switch (SelectCheck)
                {
                    case STARTSELECT.SELECTNONE:
                        SelectCheck = StartSelect();
                        break;

                    case STARTSELECT.SELECTTOWN:
                        Town(NewPlayer);
                        break;

                    case STARTSELECT.SELECTBATTLE:
                        Battle(NewPlayer, NewMonster);
                        break;

                    case STARTSELECT.SELECTLOGOUT:
                        break;
                }
            }
        }
    }
}

/* switch 탭탭 적고 엔터
// 초기선택 
1. 마을로 간다.
2. 싸움터로 간다.

[ 마을 ]
" 마을에 도착했습니다. "
1. 여관에 들른다.
2. 공격력을 강화한다.
3. 나간다.

[ 싸움터 ]
" 싸움터에 도착했습니다. "
" 몬스터가 등장했다! "

1. 데미지를 입혔다. xx는 2의 Hp가 남았다.
2. 데미지를 입었다.
*/