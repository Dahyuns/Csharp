using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 1 배경제작
        // 2 딜레이
        // 3 움직이는 블록 생성 ■
        // 4 여러 블록 종류별로 생성

        TetrisScreen SC = new TetrisScreen(10, 15);
        Block Block1 = new Block(SC); //랜덤하게?
        SC.SetBlock(3, 3, TBLOCK.BLBL);

        while (true)
        {
            Console.Clear();

            Block1.Move();
            SC.Render();
        }
    }
}

// 덮어씌우기  Console.CursorTop