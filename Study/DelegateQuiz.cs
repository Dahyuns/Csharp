using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1
public class DelegateQuiz : MonoBehaviour
{
    delegate void GoHome();
    GoHome go;

    void Start()
    {
        go = CarDriver.GoForward;
        go += CarDriver.GoRight;
        go += CarDriver.GoLeft;
        go += () => Debug.Log("후진");
        go += delegate () { Debug.Log("주차"); };

        go.Invoke();
    }

}

static class CarDriver
{
    public static void GoForward()
    {
        Debug.Log("직진합니다.");
    }
    public static void GoRight()
    {
        Debug.Log("우회전합니다.");
    }
    public static void GoLeft()
    {
        Debug.Log("좌회전합니다.");
    }
}

//2
public class DelegateGetArea : MonoBehaviour
{
    delegate double GetCircleArea(int r);

    void Start()
    {
        GetCircleArea GCA = GetArea;

        Debug.Log(GCA(7));
        Debug.Log(GCA.Invoke(7));
    }

    private double GetArea(int r)
    {
        return r * r * 3.14;
    }
}