public class Solution {
    // 08
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> destinationCandidates = new HashSet<string>();
        HashSet<string> outgoingCities = new HashSet<string>();
        
        foreach (List<string> p in paths){
            outgoingCities.Add(p[0]);
            destinationCandidates.Add(p[1]);
        }
        
        foreach (string city in outgoingCities){
            destinationCandidates.Remove(city);
        }
        
        return destinationCandidates.ToList()[0];
    }
}
