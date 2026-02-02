using System;

namespace Longest_Consecutive_Sequence;

public class Solution {
	public int LongestConsecutive(int[] nums) {
		int n = nums.Length;
		if (n == 0) return 0;
		
		HashSet<int> set = [..nums];
		int ans = 0;

		foreach (int num in set.ToArray()) {
			if (set.Contains(num - 1))
				continue;

			int seq = 1;
			int search = num;
			while (set.Remove(++search)) seq++;

			ans = Math.Max(ans, seq);
			if (ans == n) break;
		}

		return ans;
	}
}

