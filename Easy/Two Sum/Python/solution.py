from typing import List


class Solution:
	def twoSum(self, nums: List[int], target: int) -> List[int]:
		searching = {}
		for index, num in enumerate(nums):
			if num in searching:
				return [searching[num], index]
			searching[target - num] = index

		return []
