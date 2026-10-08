public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var subsets = new List<List<int>>();
        subsets.Add(new List<int>());

        for (int i = 0; i < nums.Length; i++) {
            int size = subsets.Count;
            for (int j = 0; j < size; j++) {
                var curr = new List<int>(subsets[j]);
                curr.Add(nums[i]);
                subsets.Add(curr);
            }
        }
        return subsets;    
    }
}
