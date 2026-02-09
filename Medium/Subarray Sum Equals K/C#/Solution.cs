using System;

namespace Subarray_Sum_Equals_K;

public class Solution {
	public int SubarraySum(int[] nums, int k) {
		int n = nums.Length;
		
		int count = 0;
		var prefix = new int[n + 1];
		var sumFreq = new Dictionary<int, int> {
			{ 0, 1 }
		};

		for (int i = 0; i < n; i++) {
			prefix[i + 1] = prefix[i] + nums[i];
			int sum = prefix[i + 1];

			if (sumFreq.TryGetValue(sum - k, out int freq))
				count += freq;
			
			if (!sumFreq.TryAdd(sum, 1))
				sumFreq[sum]++;
		}

		return count;
	}
}
