using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("인벤토리를 엽니다.");

        int nSelect = 0;

        Inven NewInven = new Inven(3, 5); // 15칸인벤
        NewInven.ArrRender(nSelect);
        Item NewItem1 = new Item(1600, "편스토랑라면");
        Item NewItem2 = new Item(4000, "짱구소바");
        Console.Clear(); //지워
        Console.WriteLine("인벤토리에 추가");
        NewInven.AddItem(NewItem1, 1);
        NewInven.AddItem(NewItem2, 0);
        NewInven.ArrRender(nSelect);

        while (true)
        {
            Console.Clear();
            NewInven.ArrRender(nSelect);
            ConsoleKeyInfo CKI = Console.ReadKey();
            
            switch (CKI.Key)
            {
                case ConsoleKey.W:
                    nSelect = nSelect - 5;
                    break;
                case ConsoleKey.A:
                    nSelect = nSelect - 1;
                    break;
                case ConsoleKey.S:
                    nSelect = nSelect + 5;
                    break;
                case ConsoleKey.D:
                    nSelect = nSelect + 1;
                    break;
                default: break;
            }

            if (nSelect < 0)
            {
                nSelect = 0;
            }
            else if (nSelect > NewInven.GetXY())
            {
                nSelect = NewInven.GetXY();
            }
        }
    }
}

// 출력 예시 
/* ▣■■□□
 * □□□■□
 * □□□□□
 * 현재 선택한 아이템
 * 이름 : 철검
 * 가격 : 100 */