using UnityEngine;

public class BitOperator : MonoBehaviour
{
    void Start()
    {
        byte x = 0b1010;  //10
        byte y = 0b1100;  //12;

        Debug.Log($"{System.Convert.ToString(x, 2).PadLeft(8, '0')} => {x}");
        Debug.Log($"{System.Convert.ToString(y, 2).PadLeft(8, '0')} => {y}");

        //&
        Debug.Log($"{System.Convert.ToString(x & y, 2).PadLeft(8, '0')} => {x&y}");

    }
}

/*
BitOperator: ��Ʈ ������, ������ ����� 0,1 
&, |, ^, ~

& (����) : ��Ʈ���� �Ѵ� 1�϶��� 1, �ƴϸ� 0
| 
^
~

*/