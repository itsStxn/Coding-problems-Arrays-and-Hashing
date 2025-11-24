from typing import List


class Solution:
	def topKFrequent(self, nums: List[int], k: int) -> List[int]:
		freq = {}
		for n in nums:
			freq[n] = freq.get(n, 0) + 1

		buckets = [[] for _ in range(len(nums))]
		for n, count in freq.items():
			buckets[count - 1].append(n)
		
		k_elements = []
		for i in range(len(buckets) - 1, -1, -1):
			for n in buckets[i]:
				k_elements.append(n)
				if len(k_elements) == k:
					return k_elements

		return []
