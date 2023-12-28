using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 제네릭 클래스 : 형식 매개변수 T로 지정한 형식으로 클래스와 멤버의 성질을 결정
namespace GenericTest
{
    public class Person
    {
        public string Name { get; set; } = "";
        public int Number { get; set; }
    }


    class Class1
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "홍길동", Number = 1 },
                new Person() { Name = "백두산", Number = 2 },
                new Person() { Name = "임꺽정", Number = 3 }
            };

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} - {item.Number}");
            }

            //리스트에 요소 추가
            Person p = new Person() { Name = "김단비", Number = 4 };
            people.Add(p);
        }
        void PrintData(int data) { Console.WriteLine(data); }
        void PrintData(long data) { Console.WriteLine(data); }
        void PrintData(string data) { Console.WriteLine(data); }
        //대신 제네릭사용하면
        void PrintData<T>(T data) { Console.WriteLine(data); }

    }
}
