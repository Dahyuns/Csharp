using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Array
{
    internal class Program
    {
        class Item
        {
            //클래스(class)로 배열을 만들려면,
            // [1.클래스를 정의] 한 후, 해당 클래스의 배열을 선언하면 됩니다.
            // 배열선언 예|| MyClass[] myClassArray = new MyClass[3];
            public string Name;
            public int At;
            public int a;
        }

        static void Main(string[] args)
        {
            // 배열은 자료형중 하나이다.
            // 선언 방식은 어떤자료형[] //int[]
            // 모든 자료형은 구조체 아니면 클래스로 구성되어있음 int는 구조체

            //[0][0][0][0][0][0][0][0][0][0]
            //정수가 10개 생겼다.= 배열의 Length
            int[] ArrInt = new int[1];
            // ArrInt는 int의 배열형(int의 집합)
            // ArrInt[0]는 무슨 자료형인가? - 정수형
            // C#에서 배열을 선언하면 기본적으로 모든 요소가 해당 타입의 기본값으로 초기화됩니다.
            // [  int 타입의 기본값은 0 ]
            Console.WriteLine(ArrInt[0]);// 출력 1
            for (int i = 0; i  < ArrInt.Length; i ++)
            {
                Console.WriteLine(ArrInt[i]); 
            }

            // [2.해당 클래스의 배열을 선언]=
            // 아이템이라는 메모리를 가리킬 수 있는 참조형이 10개
            Item[] ArrItem = new Item[10];

            for (int i = 0; i < ArrItem.Length; i ++)
            {
                ArrItem[i] = new Item();
            }

            ArrItem[0].Name = "사랑의검";
            ArrItem[1].Name = "죽음의검";
            ArrItem[2].Name = "전설의검";
            ArrItem[3].Name = "매화의검";
            Console.WriteLine(ArrItem[2].Name);
            Console.ReadKey();
        }

    }
}
