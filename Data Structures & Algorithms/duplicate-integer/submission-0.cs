public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> v = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (!v.Add(nums[i])) return true;
        }
        return false;
    }
}