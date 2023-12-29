using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i] ;
        }
        // TODO: 리스트에 있는 모든 요소들의 합을 계산하는 코드 작성

        Console.WriteLine($"리스트의 합: {sum}");
    }
}
