using System;

namespace Two_Sum;

public class Solution {
	public int[] TwoSum(int[] nums, int target) {        
		Dictionary<int, int> seen = [];
		
		for (int i = 0; i < nums.Length; i++) {
			int n = nums[i];
			if (seen.TryGetValue(n, out int idx))
				return [idx, i];
			
			seen[target - n] = i;
		}
		
		return [];
	}
}
