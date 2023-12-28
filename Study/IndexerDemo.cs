using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace IndexerDemo
{
    public class Indexer : MonoBehaviour
    {
        void Start()
        {
            Car cars = new Car(3);
            cars[0] = "홍길동";
            cars[1] = "백두산";

            Ind ind = new Ind(3);
            ind[0] = "안녕";
            ind[1] = "합니다";
            ind[2] = "??";

            // 어 근데 한번에는 못뽑나? > for문?
            // 속성으로 따로 빼와야하는군..
            for (int i = 0; i < ind.Leng; i++)
            {
                Debug.Log(ind[i]);
            }

            Ind ind2 = new Ind(3);
            ind2[0] = "반갑";
            ind2[1] = "습니다";
            ind2[2] = "!!";
            //그럼 foreach는? 반복기 써야함!
            foreach (var str in ind2)
            {
                Debug.Log(str);
            }

        }
    }

    public class Ind
    {
        string[] names;
        int length;

        public Ind(int length) //생성자
        {
            this.length = length;
            names = new string[length];
        }

        public int Leng //배열의 길이
        {
            get { return length; }
            set { Leng = this.length; }
        }

        public string this[int index] //인덱서
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        //반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
                yield return names[i];
        }
    }
    // 인덱서 : 인스턴스 이름으로 배열처럼 사용하게 하는것
    // 
    public class Car
    {
        private string name;
        public string this[int index]
        {
            get { return name; } //[index] 인덱서 호출시 name값 반환
            set { name = value; } // 호출하여 값을 설정하면 저장됨
        }
        public Car(int num)
        {

        }
    }
}

/*
  Indexer(인덱서) : 클래스의 객체(인스턴스)를 배열처럼 ([])를 붙여서 사용할 수 있도록
                    해주는 구문
                    클래스의 필드(배열, 컬렉션)의 값을 인덱서로 호출해서
                    사용(쓰기, 읽기)이 가능하도록 해준다.      */