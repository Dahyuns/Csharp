using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 함수가 너무 많아져용
// => 정리해결법 : partial

namespace _28Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Newplayer = new Player();

            Newplayer.Func();
            Newplayer.Atk();
            Newplayer.EventStart();
        }
    }
}
