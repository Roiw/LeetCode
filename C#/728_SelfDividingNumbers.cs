public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> answer = new List<int>();
        for (int i = left; i <= right; i++){
            string str = i.ToString();
            if (str.Contains('0')) { continue; }
            bool isSelfDividing = true;
            foreach(char c in str){
                if (i % ((int)c - 48) != 0) {
                    isSelfDividing = false;
                    break;
                }
            }
            if (isSelfDividing) answer.Add(i);
        }
        return answer;
    }
}
