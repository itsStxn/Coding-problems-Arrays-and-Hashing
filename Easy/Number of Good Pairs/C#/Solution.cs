using System;

namespace Number_of_Good_Pairs;

public class Solution {
	virtual public int NumIdenticalPairs(int[] nums) {
		var freq = new Dictionary<int, int> ();
		int count = 0;

		foreach(int n in nums)
			if (!freq.TryAdd(n, 1))
				freq[n]++;
		
		foreach(int n in nums) {
			freq[n]--;
			count += freq[n];
		}

		return count;
	}
}
