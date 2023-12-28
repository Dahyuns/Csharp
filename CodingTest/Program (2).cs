using System;

public class Solution
{
    public int[] solution(int l, int r)
    {
        int[] answer = new int[] { };
        
        int count = 0;

        // 정수, r이하
        // 1부터 하나씩 돌려보기
        for (int i = 1; i <= r; i++)
        {
            bool isOk = true;
            // 이게 true면 추가, 아니면 넘어가기.
            

            if (i % 5 != 0) continue; // <코드줄이기용>
            // 이번 숫자가 5의 배수아니면 넘어가기  

            if (l > i) continue;  // i가 l이상이 아니면 (l이하면) 또 넘어가
            
            string num = i.ToString();
            //i 한자씩 검수를 위해 str로 변형


            for (int j = 0;  j < num.Length; j++)// 한자씩 돌리는 검수함수
            {
                if (num[j] == '0' || num[j] == '5')
                    // 이번 숫자의 j번째가 0 또는 5이냐?
                {
                    continue; //맞다면 break 넘기기
                }
                isOk = false; break; //아니면 이거 안괜찮다하고, for문깨기
            }
            
            if (isOk) //이번 수 맞다 가져가
            {
                Array.Resize(ref answer, (answer.Length + 1));
                answer[(answer.Length - 1)] = i;
                count++; //숫자가 몇개 들었는지 카운트 +1
            }
            //안가져가는건 넘어가기
        }

        // l<=i<=r 다 돌렸을떄, count가 0이면 answer에 -1추가
        if (count == 0)
        {
            Array.Resize(ref answer, 1);
            answer[0] = -1;
        }

        return answer;
    }
}
