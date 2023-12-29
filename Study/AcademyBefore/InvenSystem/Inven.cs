using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 나는 아이템을 담아두는 인벤토리를 만들고 싶다.

class Inven
{
    Item[] ArrItem;

    int ItemX;

    public Inven(int _X, int _Y)
    {
        // 방어코드 : 프로그램이 터지거나 오작동하지 않게 
        if (_X < 1) {_X = 1;}
        if (_Y < 1) {_Y = 1;}
        ItemX = _X;

        ArrItem = new Item[(_X * _Y)]; // 배열을 생성 (힙에) : 공간만 잡은거여!
    }

    public void Render() // 인벤토리를 콘솔에 출력
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            /*if (i != 0 || i % 5 = 0)
            {
                Console.WriteLine("");
            }*/
            // 15개의 아이템을 가질 수 있는 인벤토리
            // i번째에 아이템이 있다/ 없다
            if (ArrItem[i] == null)
            {
                Console.Write("☆");
            }
            else
            {
                Console.Write("★");
            }
        }
    }
}
// 인벤 2부부터 보삼