from typing import List


class Solution:
	def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
		groups: dict[tuple, List[str]] = {}
		for s in strs:
			freq = [0]*26
			for c in s:
				freq[ord(c) - ord('a')] += 1
			
			key = tuple(freq)
			groups[key] = groups.get(key, []) + [s]
			
		return list(groups.values())
