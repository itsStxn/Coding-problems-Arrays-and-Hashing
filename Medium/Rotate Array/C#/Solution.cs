using System;

namespace Rotate_Array;

public class Solution {
	virtual public void Rotate(int[] nums, int k) {
		var rotated = new int[nums.Length];

		for (int i = 0; i < nums.Length; i++) {
			int pos = (i + k) % nums.Length;
			rotated[pos] = nums[i];
		}

		for (int i = 0; i < nums.Length; i++) {
			nums[i] = rotated[i];
		}
	}
}
