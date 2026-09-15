public class Solution {
    public int LengthOfLongestSubstring(string s) {            
        int l = 0, ans = 0;
        Dictionary<char, int> chars = new();        
        for (int r = 0; r < s.Length; r++) {
            if (chars.ContainsKey(s[r])) {
                l = Math.Max(chars[s[r]]+1, l);
            }
            chars[s[r]] = r;
            ans = Math.Max(ans, r-l+1);
        }
        return ans;
    }
}
