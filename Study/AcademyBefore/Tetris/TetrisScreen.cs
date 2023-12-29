using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum TBLOCK
{
    VOID,// □
    WALL,// ▣
    BLBL // ■
}
//리스트 쓴거
class TetrisScreen
{
    List<List<TBLOCK>> BlockList = new List<List<TBLOCK>>();

    public TetrisScreen(int _X, int _Y)
    {
        for (int y = 0; y < _Y; ++y)
        {
            BlockList.Add(new List<TBLOCK>());
            for (int x = 0; x < _X; ++x)
            {
                BlockList[y].Add(TBLOCK.VOID);
            }
        }
        for (int i = 0; i < BlockList[0].Count; ++i)
        {
            BlockList[0][i] = TBLOCK.WALL;
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; ++i)
        {
            BlockList[BlockList.Count - 1][i] = TBLOCK.WALL;
        }
    }

    public void Render()
    {
        Console.WriteLine("");
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                switch (BlockList[y][x])
                {
                    case TBLOCK.WALL:
                        Console.Write("▣");
                        break;
                    case TBLOCK.VOID:
                        Console.Write("□");
                        break;
                    case TBLOCK.BLBL:
                        Console.Write("■");
                        break;
                    default:
                        break;
                }
                //Console.Write(BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }

    public void SetBlock(int _x, int _y, TBLOCK _Type)
    {
        BlockList[_y][_x] = _Type;
    }
}
