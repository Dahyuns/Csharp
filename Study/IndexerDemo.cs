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
            cars[0] = "ȫ�浿";
            cars[1] = "��λ�";

            Ind ind = new Ind(3);
            ind[0] = "�ȳ�";
            ind[1] = "�մϴ�";
            ind[2] = "??";

            // �� �ٵ� �ѹ����� ���̳�? > for��?
            // �Ӽ����� ���� ���;��ϴ±�..
            for (int i = 0; i < ind.Leng; i++)
            {
                Debug.Log(ind[i]);
            }

            Ind ind2 = new Ind(3);
            ind2[0] = "�ݰ�";
            ind2[1] = "���ϴ�";
            ind2[2] = "!!";
            //�׷� foreach��? �ݺ��� �����!
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

        public Ind(int length) //������
        {
            this.length = length;
            names = new string[length];
        }

        public int Leng //�迭�� ����
        {
            get { return length; }
            set { Leng = this.length; }
        }

        public string this[int index] //�ε���
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        //�ݺ���
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++)
                yield return names[i];
        }
    }
    // �ε��� : �ν��Ͻ� �̸����� �迭ó�� ����ϰ� �ϴ°�
    // 
    public class Car
    {
        private string name;
        public string this[int index]
        {
            get { return name; } //[index] �ε��� ȣ��� name�� ��ȯ
            set { name = value; } // ȣ���Ͽ� ���� �����ϸ� �����
        }
        public Car(int num)
        {

        }
    }
}

/*
  Indexer(�ε���) : Ŭ������ ��ü(�ν��Ͻ�)�� �迭ó�� ([])�� �ٿ��� ����� �� �ֵ���
                    ���ִ� ����
                    Ŭ������ �ʵ�(�迭, �÷���)�� ���� �ε����� ȣ���ؼ�
                    ���(����, �б�)�� �����ϵ��� ���ش�.      */