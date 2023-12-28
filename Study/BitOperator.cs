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
BitOperator: 비트 연산자, 연산의 결과는 0,1 
&, |, ^, ~

& (논리곱) : 비트값이 둘다 1일때만 1, 아니면 0
| 
^
~

*/