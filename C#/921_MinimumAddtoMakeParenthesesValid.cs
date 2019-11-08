public class Solution {
    public int MinAddToMakeValid(string S) {
        int count = 0;
        int answer = 0;
        for (int i = 0; i < S.Length; i++)
        {
            if(S[i] == '(')
            {
                if (i == 0)
                {
                    count ++;
                    continue;
                }
                else if (S[i-1] == ')' && count<1)
                {
                    answer += Math.Abs(count);
                    count = 1;
                }
                else
                    count++;

            }
            else
            {
                count--;
            }
        }
        answer += Math.Abs(count);
        return answer;
    }
}
