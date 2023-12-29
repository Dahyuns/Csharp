using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 사용자 정의 자료형 
// class / struct / enum

        // enum
        // 다른 언어에서는 정수형 상수라고 불리나 
        // C#에선 열거형이라고 불린다.
        // 보통 어떤 상태를 표현하는 것 중
        // 나만의 것을 가지고 싶을 때 사용한다.
        // 명찰에 가까움
enum Itemtype
{
    // 장점 : 값의 범위를 지정한 새로운 자료형을 만들어낼 수 있다.
    // Switch와 궁합이 좋다
    EQUIP,
    POTION,
    QUEST
}


class Item
{
    public Itemtype ITEMTYPE = Itemtype.EQUIP;

    public void PotionTypeSetting()
    {
        ITEMTYPE = Itemtype.POTION;
    }
}


namespace _22Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item Newitem = new Item();
            Newitem.ITEMTYPE = Itemtype.POTION;
            Newitem.PotionTypeSetting();

            // 값형이면서 사용자 정의 자료형
            // 사용방법 제외하곤 그냥 int다!

            // switch랑 자주씀
            Itemtype Type = Itemtype.QUEST;
            switch (Type)
            {
                case Itemtype.EQUIP:
                    break;
                case Itemtype.POTION:
                    break;
                case Itemtype.QUEST:
                    break;
                default:
                    break;
            }



        }
    }
}
