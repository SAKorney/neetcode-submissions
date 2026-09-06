public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        if (words.Length == 1) return true;
        var p = new int[26];
        for (int i = 0; i < order.Length; i++){
            p[order[i] - 'a'] = i;            
        }        

        for (int i = 0; i < words.Length-1; i++)
        {
            var fw = words[i];
            var sw = words[i+1];
            
            for (int j = 0; j < fw.Length; j ++) {
                if (j == sw.Length) return false;
                if (fw[j] != sw[j]) {
                    if (p[fw[j] - 'a'] > p[sw[j] - 'a']) return false;
                    break;
                }
            }
        }

        return true;
    }
}