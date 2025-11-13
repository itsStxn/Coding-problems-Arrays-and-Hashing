namespace Longest_Consecutive_Sequence;


public class Solution {
	public int LongestConsecutive(int[] nums) {
		if (nums.Length == 0) return 0;
		
		HashSet<int> numsSet = new(nums);
		int longestSequence = 0;

		for (int i = 0; i < nums.Length; i++) {
			int num = nums[i];
			if (numsSet.Remove(num)) {
				bool foundPrev = true;
				bool foundNext = true;
				int prev = num - 1;
				int next = num + 1;
				int streak = 1;

				while (foundPrev || foundNext) {
					foundPrev = foundPrev && numsSet.Remove(prev--);
					foundNext = foundNext && numsSet.Remove(next++);
					if (foundPrev) streak++;
					if (foundNext) streak++;
				}
				longestSequence = Math.Max(longestSequence, streak);
				if (numsSet.Count == 0) break;
			}
		}

		return longestSequence;
	}
}
