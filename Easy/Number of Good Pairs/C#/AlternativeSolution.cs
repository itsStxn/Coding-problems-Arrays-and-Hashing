using System;

namespace Number_of_Good_Pairs;

public class AlternativeSolution : Solution {
	override public int NumIdenticalPairs(int[] nums) {
		var freq = new Dictionary<int, int> ();
		int count = 0;

		foreach (int n in nums) {
			if (freq.TryAdd(n, 1))
				continue;

			count += freq[n];
			freq[n]++;
		}

		return count;
	}
}
