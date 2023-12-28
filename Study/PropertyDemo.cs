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
            // �Ӽ��� ��������
            dev.Name = "�¸��";
            Debug.Log($"�ȳ� {dev.Name}");

            Person person = new Person();
            // �ż����̿� ����
            person.SetName("������ħ");
            Debug.Log(person.GetName());

            person.Name = "���Ƹ�";
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

        // �޼����̿� ��ȯ
        public string GetName()
        { return myname; }
        // �޼����̿� ����
        public void SetName(string name)
        { this.myname = name; }

        // �Ӽ��̿� ��ȯ�� ����
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
Property(�Ӽ�) : �ʵ尪�� �аų� ���ų� �����ϴ� ����� �����ϴ� Ŭ���� ���
     �Ӽ��� ������ ������ �ʵ带 �ܺο��� �аų����Ⱑ �����ϵ��� ���ش�.
     �Ӽ��� ����ó�� ����Ѵ�(������ �ƴϴ�?)
     �Ӽ����� value Ű���带 ���� �Ű�����ó�� �ԷµǴ� ���� �޾� �´�.

 property ���̹� : ù ���ĺ��� �빮�ڷ� ����.
 
 
 */