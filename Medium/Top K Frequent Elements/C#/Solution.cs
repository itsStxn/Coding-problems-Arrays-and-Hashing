using System;

namespace Top_K_Frequent_Elements;

public class Solution {
	virtual public int[] TopKFrequent(int[] nums, int k) {
		Dictionary<int, int> freq = [];
		List<HashSet<int>> freqGroups = [];

		foreach (int n in nums) {
			if (freq.TryGetValue(n, out int count)) {
				freqGroups[count - 1].Remove(n);
				freq[n] = ++count;
			}
			else {
				count = 1;
				freq.Add(n, count);
			}

			if (count <= freqGroups.Count) 
				freqGroups[count - 1].Add(n);
			else
				freqGroups.Add(new([n]));
		}

		var ans = new int[k]; 
		int idx = 0;

		for (int i = 1; i <= nums.Length; i++) {
			foreach (int n in freqGroups[^i]) {
				ans[idx++] = n;

				if (idx == k)
					return ans;
			}
		}

		return ans;
	}
}
