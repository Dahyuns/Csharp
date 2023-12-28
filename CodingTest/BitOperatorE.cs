using UnityEngine;

public class BitOperatorE : MonoBehaviour
{
    void Start()
    {

        const int poison =    0b0000_0001; //�� ����   //1
        const int confusion = 0b0000_0010; //ȥ�� ���� //2
        const int silence =   0b0000_0100; //ħ�� ���� //4
        const int burn =      0b0000_1000; //ȭ�� ���� //8

        int myStatus = 0; //    0000_0000

        //�ʱ����
        /* int myFirstState = 0; */
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        
        //���³ֱ�
        myStatus |= poison;
        Debug.Log($"{System.Convert.ToString(myStatus,2).PadLeft(8,'0')}");
        myStatus |= confusion;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        myStatus |= silence;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        myStatus |= burn;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");

        CheckStatus(myStatus, poison);
        CheckStatus(myStatus, confusion);
        CheckStatus(myStatus, silence);
        CheckStatus(myStatus, burn);

        //���»���
        // XOR�� ������ : ���� �� ���¿� �ɷ������� ���� ������
        // �� ���¿� �ɷ����������� ���� �߻� 1110(��x) ^ 0001(��o) = 1111 (��o)
        // > ���� üũ�� ����.
        // 1011(������) & 1101(!confusion) = 1001

        myStatus &= ~poison;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        myStatus &= ~confusion;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        myStatus &= ~silence;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        myStatus &= ~burn;
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
    }

    void CheckStatus(int a, int b)
    {
        if ((a & b) > 0)
            Debug.Log("�����̻�!");
    }
}
