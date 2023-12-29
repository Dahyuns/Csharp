using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*
enum SelectItem
{
    SltNull,
    SltItem
}*/
internal class Inven
{
    int _X;
    int _Y;
    Item[] ArrItem;
    public Inven(int X, int Y)
    {

        if (X < 1)
        {
            X = 1;
        }
        if (Y < 1)
        {
            Y = 1;
        }
        ArrItem = new Item[(X * Y)];
        _X = X;
        _Y = Y;

    }
    public int GetXY()
    {
        int _XY;
        _XY = _X * _Y;
        return _XY - 1;
    }
    public void ArrRender(int _select)
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (i != 0 && i % 5 == 0)
            {
                Console.WriteLine("");
            }

            if (_select == i)
            {
                Console.Write("▣");
            }
            else
            {
                if (ArrItem[i] == null)
                {
                    Console.Write("□");
                }
                else
                    Console.Write("■");
            }
        }
        Console.WriteLine("");
        if (ArrItem[_select] != null)
        {
            Console.WriteLine("[ 현재 선택한 아이템 ]");
            Console.WriteLine(" 이름 : " + ArrItem[_select].GetName());
            Console.WriteLine(" 가격 : " + ArrItem[_select].GetGold());
        }
    }
    public void AddItem(Item _item, int A)
    {
        ArrItem[A] = _item;
    }
}