public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] stat = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            stat[s[i] - 'a']++;
            stat[t[i] - 'a']--;
        }   
        for (int i = 0; i < stat.Length; i ++)
        {
            if (stat[i] != 0) return false;
        }
        return true;
    }
}
