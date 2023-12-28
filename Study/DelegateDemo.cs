using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Delegate(대리자) : 매개변수 및 반환 형식이 있는 메서드 목록에 대한 참조를 나타내는 형식
: (함수를) 대신 실행자 : 등록(지정한) 메서드(들)을 대신 실행시켜주는.

< 형식 >
delegate void (이름) () : 반환값이 없음, 매개변수 없음
delegate (반환 데이터 타입) (대리자 이름) (데이터타입 변수이름)
                        : 반환값 있고, 매개변수 값도 있음
*/

public class DelegateDemo : MonoBehaviour
{
    //반환값, 매개변수 없음
    private void Hi()
    {
        Debug.Log("어디가세요?");
    }

    //델리게이트, Hi의 대리자
    // 반환값이 없음, 매개변수 변수없는 메서드를 대신해주는 것
    private delegate void SayDelegate();

    void Start()
    {
        Hi();

        //대리자 변수선언 및 대리자 변수에 메서드 등록
        SayDelegate sd = Hi;
        //대리자 호출(방법1)
        sd();

        //대리자 변수선언 및 대리자 변수에 메서드 등록
        SayDelegate whereUgo = new SayDelegate(sd);
        //대리자 호출(방법2) : 변수이름();
        whereUgo();

        //대리자 변수선언 및 대리자 변수에 메서드 등록
        SayDelegate whatUdo = new SayDelegate(sd);
        //대리자 호출(방법3) : 변수이름.Invoke();
        whatUdo.Invoke();
    }
}

