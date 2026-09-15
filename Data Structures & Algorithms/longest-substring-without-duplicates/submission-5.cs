public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0, l = 0, emptyIdx = -1;        
        int[] charsIdx = Enumerable.Range(0, 256)
            .Select(_ => emptyIdx)
            .ToArray();
        for (int r = 0; r < s.Length; r++) {
            int idx = s[r];
            if (charsIdx[idx] != emptyIdx) {
                l = Math.Max(charsIdx[idx]+1, l);
            }
            charsIdx[idx] = r;
            ans = Math.Max(ans, r-l+1);
        }
        return ans;
    }
}
