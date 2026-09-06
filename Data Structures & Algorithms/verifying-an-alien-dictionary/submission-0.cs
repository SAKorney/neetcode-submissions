public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var p = order
            .Select((c, i) => (c,i))
            .ToDictionary(x => x.Item1, x => x.Item2);

        int Compare(string fw, string sw)
        {
            int minLen = Math.Min(fw.Length, sw.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (p[fw[i]] < p[sw[i]]) { return  -1; }
                if (p[fw[i]] > p[sw[i]]) { return 1; }
            }
            if (fw.Length == sw.Length) return 0;
            return (fw.Length < sw.Length) ? -1 : 1;               
        }

        for (int i = 0; i < words.Length-1; i++)
        {
            var fw = words[i];
            var sw = words[i+1];
            
            if (Compare(fw, sw) == 1) return false;            
        }

        return true;
    }
}