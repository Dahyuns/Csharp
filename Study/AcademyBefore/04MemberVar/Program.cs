using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 한글은 보통 사용하지 않음

// 멤버변수의 선언은 -> int(자료형) 이름(식별자) 형식,
// 초기값(리터럴 값)을 넣어줄 수 있다. 
// _리터럴(Literal)이란? 데이터(값) 그 자체를 뜻한다.
// 선언을 함과 동시에 값을 넣어주는 것을 
// "리터럴 초기화"라고 한다.

/*예시
 bool b = true;              _리터럴 : true
 int num1 = 100;             _리터럴 : 100
 int num2 = 0x11;            _리터럴 : 0x11
 int num3 = null;            _리터럴 : null
 float num4 = 1.2f           _리터럴 : 1.2f
 double num5 = 0.11111;      _리터럴 : 0.11111
 string str = "BlockDMask";  _리터럴 : "BlockDMask"*/

// exe파일을 실행하면 이 프로그램은
// 램에 올라가게(복사)된다.
// 공짜가 없다. 여러분들은 무언가를 만들기 위해 공간을 차지해야함.
// 메모리를 지불해서 자리를 만든다.

// int Att : 램 30번지에 4바이트만큼의 공간을 만들어라.
// = 300 : 30번지에 300이라는 값을 채워넣어라.

// 자료형의 종류
// 크기 : 4바이트
// 형태 : 정수
// 이름의 의미
// 위치 : (Gold => 램 45621345 위치/ 요런식)
// 내가 사용하기 위한 별명


// 개념 : 플레이어가 있다.
class Player
{
    // 개념 : 플레이어는 골드를 가진다.
    int Gold = 10 ;
    int Exp = 1000 ;
    int Att = 300 ;
    int Def = 100 ;
    int Hp = 20 ;
    // 개념 : 플레이어는 싸울 수 있는가?
    bool IsFight;
}

