using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOCKTYPE
{
    BT_I, //1'ㅣ'
    BT_L, //2'ㄱ'
    BT_J, //3'ㄱ' 거꾸로
    BT_Z, //4'ㄹ'
    BT_S, //5'ㄹ' 거꾸로
    BT_T, //6'ㅗ'
    BT_O  //7'ㅁ'
}

class Block
{
    int X;
    int Y;

    TBLOCK BlockType = TBLOCK.BLBL;

    TetrisScreen Screen = null;

    public Block(TetrisScreen _Screen)
    {
        Screen = _Screen;
        int[][] block = new int[4][];
        for (int i = 0; i < 4; i++)
        {
            block[i] = new int[4];
        }
    }
    public void Move()
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.W:
                Y -= 1;
                break;
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            default:
                break;
        }
        Screen.SetBlock(X, Y, BlockType);
    }



    public void BRender(BLOCKTYPE BTYPE)
    {
        switch (BTYPE)
        {
            case BLOCKTYPE.BT_I:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_L:
                {
                    for (int x = 0; x < 4; x++)
                    {
                        if (x == 2 || x == 3)
                        {
                            Console.Write("■");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine("");
                    for (int y = 0; y < 2; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_J:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_Z:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_S:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_T:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            case BLOCKTYPE.BT_O:
                {
                    for (int y = 0; y < 4; y++)
                    {
                        for (int x = 0; x < 4; x++)
                        {
                            if (x == 3)
                            {
                                Console.Write("■");
                            }
                            else
                            {
                                Console.Write("  ");
                            }
                        }
                        Console.WriteLine("");
                    }
                }
                break;
            default:
                break;
        }
    }
    
}
