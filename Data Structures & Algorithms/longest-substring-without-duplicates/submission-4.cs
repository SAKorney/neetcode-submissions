public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l=0, ans=0;
        int[] chars = new int[256];
        Array.Fill(chars, -1);
        for (int r = 0; r < s.Length; r++) {
            int i = s[r];
            if (chars[i] != -1) {
                l = Math.Max(chars[i]+1, l);
            }
            chars[i] = r;
            ans = Math.Max(ans, r-l+1);
        }
        return ans;
    }
}
