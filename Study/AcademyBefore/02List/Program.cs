using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program // 이중 리스트
{
    static void Main(string[] args)
    {
        List<List<int>> scores = new List<List<int>>
        {
            new List<int>{ 90, 85, 75 },
            new List<int>{ 85, 80, 90 },
            new List<int>{ 95, 95, 95 },
            new List<int>{ 75, 70, 80 },
            new List<int>{ 80, 75, 85 }
        };


        int[] ScArr = new int[scores.Count];
        for (int i = 0; i < scores.Count; i++) //평균출력
        {
            ScArr[i] = (scores[i][0] + scores[i][1] + scores[i][2]) / 3;
            Console.WriteLine((i + 1) + "번째 학생 평균 :" + ScArr[i]);
        }
        // 가장 높은 학생 출력
        Console.WriteLine("평균이 가장 높은 학생 :" + Array.IndexOf(ScArr, ScArr.Max()) + "점수 :" + ScArr.Max());
        Console.ReadKey();
    }

}
