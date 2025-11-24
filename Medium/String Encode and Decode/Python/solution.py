from typing import List


class Solution:
	def encode(self, strs: List[str]) -> str:
		return ''.join(str(len(s)) + ':' + s for s in strs)

	def decode(self, s: str) -> List[str]:
		output = []

		n = len(s)
		i = 0
		while i < n:
			num = ""
			while s[i].isnumeric():
				num += s[i]
				i += 1

			count = int(num)
			
			decoded = ""
			while count > 0:
				decoded += s[i + 1]
				count -= 1
				i += 1
			
			output.append(decoded)
			i += 1
			
		return output
