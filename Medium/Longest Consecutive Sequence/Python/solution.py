from typing import List


class Solution:
	def longestConsecutive(self, nums: List[int]) -> int:
		seen = set(nums)
		max_streak = 0

		for num in seen:
			streak = 0
			if num - 1 not in seen:
				while num in seen:
					streak += 1
					num += 1
				max_streak = max(streak, max_streak)
		
		return max_streak
