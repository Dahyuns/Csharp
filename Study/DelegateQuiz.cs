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
        go += () => Debug.Log("����");
        go += delegate () { Debug.Log("����"); };

        go.Invoke();
    }

}

static class CarDriver
{
    public static void GoForward()
    {
        Debug.Log("�����մϴ�.");
    }
    public static void GoRight()
    {
        Debug.Log("��ȸ���մϴ�.");
    }
    public static void GoLeft()
    {
        Debug.Log("��ȸ���մϴ�.");
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