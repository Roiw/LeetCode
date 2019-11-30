public class Solution {
    public string ToLowerCase(string str) {
        for (int i = 0; i < str.Length; i++)
        {
            int val = (int)str[i];
            if ( val >= 65 && val <= 90)
            {
                val = val + 32;
                str = str.Insert(i, ((char)val).ToString());
                str = str.Remove(i+1, 1);
            }
        }
        return str;
    }
}
