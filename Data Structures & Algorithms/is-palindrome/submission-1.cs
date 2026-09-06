public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            while (
                !char.IsLetterOrDigit(s[i]) && i < j
            )
            {
                i++;
            }

            while (
                !char.IsLetterOrDigit(s[j]) && j > i
            )
            {
                j--;
            }
            if (char.ToUpper(s[i]) != char.ToUpper(s[j])) return false;
            i++;
            j--;
        }
        return true;
    }
}
