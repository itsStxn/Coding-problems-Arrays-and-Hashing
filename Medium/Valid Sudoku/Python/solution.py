from typing import List


class Solution:
	def isValidSudoku(self, board: List[List[str]]) -> bool:
		rows = [set() for _ in range(9)]
		cols = [set() for _ in range(9)]
		
		def valid_subboard(row: int, col: int) -> bool:
			subboard = set()
			for r in range(row, row + 3):
				for c in range(col, col + 3):
					n = board[r][c]
					if not n.isdigit():
						continue
					
					if n in subboard or n in rows[r] or n in cols[c]:
						return False
					subboard.add(n)
					rows[r].add(n)
					cols[c].add(n)
					
			return True
		
		for row in range(0, 9, 3):
			for col in range(0, 9, 3):
				if not valid_subboard(row, col):
					return False
		
		return True
