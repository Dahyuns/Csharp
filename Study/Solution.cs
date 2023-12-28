using System.Linq;
using System.Reflection.Metadata;

public class Solution
{
    public int solution(int a, int b, int c, int d)
    {
        int answer = 0;
        int sumNum = a + b + c + d;
        int[] num = { a, b, c, d };
        int[] countSix = new int[7];

        for (int i = 0; i < num.Length; i++)
        {
            countSix[num[i]] += 1;
        }

        for (int i = 1; i < countSix.Length; i++)
        {
            if (countSix[i] == 0) continue;

            else if (countSix[i] == 1)
            {
                if (countSix.Count(cn => cn == 1) == 4)
                {
                    answer = num.Min();
                    break;
                }
                else continue;
            }

            if (countSix[i] == 2)
            {
                int int_im = sumNum - (i * 2);
                int[] x = new int[2];
                int x_Length = 0;

                // 나머지 수 x에 담음
                for (int k = 0; k < 4; k++)
                {
                    if (num[k] != i)
                        x[x_Length++] = num[k];
                }

                if (x[0] == x[1])
                {
                    int im = i - x[0];
                    im = im > 0 ? im : -im;
                    answer = (i + x[0]) * im;
                    break;
                }
                else if (x[0] != x[1])
                {
                    answer = x[0] * x[1];
                    break;
                }
            }

            if (countSix[i] == 3)
            {
                int int_im = sumNum - (i * 3);
                int temp = (10 * i) + int_im;
                answer = temp * temp;
                break;
            }

            if (countSix[i] == 4)
            {
                answer = 1111 * i;
                break;
            }
        }
        return answer;
    }
}


