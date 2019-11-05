public class Solution {
    public IList<string> CommonChars(string[] A) {

        Dictionary<char,int> ans = CharactersOnString(A[0]);

        for (int i = 1; i < A.Length; i++)
        {
            Dictionary<char,int> it = CharactersOnString(A[i]);
            Dictionary<char,int> it2 = new Dictionary<char,int>();
            foreach(char key in ans.Keys)
            {
                if (it.ContainsKey(key))
                {
                    if (ans[key] > it[key])
                        it2.Add(key, it[key]);
                    else
                        it2.Add(key, ans[key]);
                }
            }
            ans = it2;
        }

        List<string> rtn = new List<string>();
        foreach(char key in ans.Keys)
        {
            for (int j = 0; j < ans[key]; j++)
            {
                rtn.Add(""+key);
                Console.WriteLine(key);
            }

        }
        return rtn;

    }

    public Dictionary<char,int> CharactersOnString(string str)
    {
        Dictionary<char,int> ans = new Dictionary<char,int>();
        foreach(char c in str)
        {
            if (ans.ContainsKey(c))
            {
                ans[c]++;
            }
            else
            {
                ans.Add(c,1);
            }
        }
        return ans;
    }
}
