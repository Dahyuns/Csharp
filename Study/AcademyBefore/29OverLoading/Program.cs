using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Hp = 100;

    //물리방어력
    int AttDef = 5;
    //마법방어력
    int MagDef = 5;
    //관통방어력
    int DrsDef = 5;

    // 함수 오버 로딩 _ 함수의 이름이 같아도 된다!?
    // 사실 이 함수의 이름은 Damageint 이다.
    public void Damage(int _Damage)
    {
        Hp -= _Damage;
    }


    // 사실 이 함수의 이름은 Damagefloatint 이다.
    public void Damage(float _dddd, int _Type)
    {

    }


    // 사실 이 함수의 이름은 Damageintint 이다.
    public void Damage(int _Damage, int _defType) //여기서 _defType은 int가 아닌 enum을 쓰는것이 좋다!
    {
        switch (_defType)
        {
            case 1:
                _Damage -= AttDef;
                break;
            case 2:
                _Damage -= MagDef;
                break;
            case 3:
                _Damage -= DrsDef;
                break;
            default:
                break;
        }

    Damage(_Damage);
    }
}




namespace _29OverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();
            Newplayer.Damage(30, 2);
        }
    }
}
