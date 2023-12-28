using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Delegate(�븮��) : �Ű����� �� ��ȯ ������ �ִ� �޼��� ��Ͽ� ���� ������ ��Ÿ���� ����
: (�Լ���) ��� ������ : ���(������) �޼���(��)�� ��� ��������ִ�.

< ���� >
delegate void (�̸�) () : ��ȯ���� ����, �Ű����� ����
delegate (��ȯ ������ Ÿ��) (�븮�� �̸�) (������Ÿ�� �����̸�)
                        : ��ȯ�� �ְ�, �Ű����� ���� ����
*/

public class DelegateDemo : MonoBehaviour
{
    //��ȯ��, �Ű����� ����
    private void Hi()
    {
        Debug.Log("��𰡼���?");
    }

    //��������Ʈ, Hi�� �븮��
    // ��ȯ���� ����, �Ű����� �������� �޼��带 ������ִ� ��
    private delegate void SayDelegate();

    void Start()
    {
        Hi();

        //�븮�� �������� �� �븮�� ������ �޼��� ���
        SayDelegate sd = Hi;
        //�븮�� ȣ��(���1)
        sd();

        //�븮�� �������� �� �븮�� ������ �޼��� ���
        SayDelegate whereUgo = new SayDelegate(sd);
        //�븮�� ȣ��(���2) : �����̸�();
        whereUgo();

        //�븮�� �������� �� �븮�� ������ �޼��� ���
        SayDelegate whatUdo = new SayDelegate(sd);
        //�븮�� ȣ��(���3) : �����̸�.Invoke();
        whatUdo.Invoke();
    }
}

