public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        
        Dictionary<string, int> visits = new Dictionary<string,int>();
        
        foreach (string s in cpdomains) {
            string[] splitted = s.Split(' ');
            int v = Int32.Parse(splitted[0]);
            string[] domains = splitted[1].Split('.');
            string c = "";
            for (int j = (domains.Length - 1) ; j >= 0; j--) {
                string curr = domains[j] + c;
                if (visits.ContainsKey(curr)) {visits[curr] += v;}
                else {visits.Add(curr, v);}
                c = "." + curr;
            }
        }
        IList<string> rtn = new List<string>();
        foreach(KeyValuePair<string,int> kvp in visits) {
            rtn.Add(kvp.Value.ToString() + " " + kvp.Key);
        }
        
        return rtn;
    }
}
