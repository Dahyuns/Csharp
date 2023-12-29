using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

internal class Program
{
    static void Main(string[] args)
    {
        Inven NewInven = new Inven(5, 3);
        NewInven.Render();

    }
}

// 퉁퉁특공대
// 머지게임
// 디펜스 게임