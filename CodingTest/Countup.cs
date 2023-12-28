using System;

public class Solution
{
    public int[] solution(int start_num, int end_num)
    {
        int count = end_num - start_num + 1; //총숫자개수
        int[] answer = new int[count]; //총개수만큼의 크기

        for (int i = end_num;  i >= start_num ;  i--) 
            // 끝에서 시작, 시작이상일때만, 1씩감소
        {
            answer[count-1] = i;
            count--;
        }
        return answer;
    }
}