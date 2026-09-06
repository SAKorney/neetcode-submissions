public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, uint> sd = new(26);
        Dictionary<char, uint> td = new(26);
        for (int i = 0; i < s.Length; i++)
        {
            sd.TryAdd(s[i], 0);
            td.TryAdd(t[i], 0);
            sd[s[i]]++;
            td[t[i]]++;            
        }   
        return sd.Count == td.Count && !sd.Except(td).Any();     
    }
}
