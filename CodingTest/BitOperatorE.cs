using UnityEngine;

public class BitOperatorE : MonoBehaviour
{
    void Start()
    {

        const int poison =    0b0000_0001; //독 상태   //1
        const int confusion = 0b0000_0010; //혼란 상태 //2
        const int silence =   0b0000_0100; //침묵 상태 //4
        const int burn =      0b0000_1000; //화상 상태 //8

        int myStatus = 0; //    0000_0000

        //초기상태
        /* int myFirstState = 0; */
        Debug.Log($"{System.Convert.ToString(myStatus, 2).PadLeft(8, '0')}");
        
        //상태넣기
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

        //상태빼기
        // XOR의 주의점 : 내가 뺄 상태에 걸려있으면 문제 없으나
        // 뺄 상태에 걸려있지않으면 버그 발생 1110(독x) ^ 0001(독o) = 1111 (독o)
        // > 상태 체크후 뺀다.
        // 1011(현상태) & 1101(!confusion) = 1001

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
            Debug.Log("상태이상!");
    }
}
