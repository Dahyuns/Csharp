using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        void Start()
        {
            Developer dev = new Developer();
            // 속성에 직접접근
            dev.Name = "굿모닝";
            Debug.Log($"안녕 {dev.Name}");

            Person person = new Person();
            // 매서드이용 접근
            person.SetName("좋은아침");
            Debug.Log(person.GetName());

            person.Name = "병아리";
            Debug.Log(person.Name);
        }
    }


    public class Developer
    {
        public string Name { get; set; }
    }

    public class Person
    {
        private string myname;

        // 메서드이용 반환
        public string GetName()
        { return myname; }
        // 메서드이용 설정
        public void SetName(string name)
        { this.myname = name; }

        // 속성이용 반환및 설정
        public string Name 
        {
            get
            {
                return this.myname;
            }
            set
            {
                this.myname = value;

            }
        }

    }
}

/*
Property(속성) : 필드값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 멤버
     속성은 접근을 제한한 필드를 외부에서 읽거나쓰기가 가능하도록 해준다.
     속성은 변수처럼 사용한다(변수는 아니다?)
     속성에서 value 키워드를 통해 매개변수처럼 입력되는 값을 받아 온다.

 property 네이밍 : 첫 알파벳은 대문자로 쓴다.
 
 
 */