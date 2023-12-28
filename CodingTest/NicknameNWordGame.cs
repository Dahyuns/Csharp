

using System.Globalization;
using System.Xml.Linq;

while (true) 
{
    // 닉네임 생성후 삭제
    Console.Write($"안녕하세요 닉네임을 알려주세용\n" );
    var ncname = Console.ReadLine();
    Console.Clear();

    Console.Write($"네 반갑습니다 {ncname}님! \n 키워드를 맞춰보세요! (창닫기) \n ==> ");

    // 채팅입력
    var talk = Console.ReadLine( );
    Console.Clear();

    // 종료명령어(클리어)
    if (talk == "esc" || talk == "ESC") 
    {
        Console.WriteLine("Clear!!!! \n Winner is "+ ncname);
        return; 
    }

    Console.WriteLine($@" 
----------------------------------------------
[{talk}]........ 틀렸습니다! 
---------------------------------------------

시작화면으로..
" );
    Console.WriteLine(123 + 123 + "234" + 245);

    Console.ReadLine();
    Console.Clear() ;

}
