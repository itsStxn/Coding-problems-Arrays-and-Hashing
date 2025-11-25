from typing import List


class Solution:
	def productExceptSelf(self, nums: List[int]) -> List[int]:
		product = []

		prev = 1
		for i in range(len(nums)):
			product.append(prev)
			prev *= nums[i]
		
		prev = 1
		for i in range(len(nums) - 1, -1, -1):
			product[i] *= prev
			prev *= nums[i]

		return product
