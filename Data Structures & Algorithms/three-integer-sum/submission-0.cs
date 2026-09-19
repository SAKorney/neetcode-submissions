public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);        
        List<List<int>> res = new ();        
        if (nums[0] > 0) return res;

        for (int i = 0; i < nums.Length; i++) {
            if (i > 0 && nums[i] == nums[i-1]) continue;
            foreach (var item in TwoSum(nums, i+1, -nums[i]))
            {
                res.Add([..item, nums[i]]);
            }
        }
        return res;
    }

    private List<List<int>> TwoSum(int[] nums, int start, int target) {
        int l = start, r = nums.Length - 1;
        List<List<int>> res = new();
        while (l < r) {
            int sum = nums[l] + nums[r];
            if (sum < target)
            {
                l++;
            }
            else if (sum > target)
            {
                r--;
            }
            else
            {
                res.Add([nums[l] , nums[r]]);
                l++;
                r--;
                while (l < r && nums[l] == nums[l-1]) { l++; }
            }
        }
        return res;
    }
}
