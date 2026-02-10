using System;

namespace Rotate_Array;

public class AlternativeSolution2 : Solution {
	override public void Rotate(int[] nums, int k) {
		int n = nums.Length;
		int count = 0;
		k %= n;

		for (int start = 0; count < n; start++) {
			int curr = start;
			int prev = nums[start];
		
			do {
				int next = (curr + k) % n;
				(nums[next], prev) = (prev, nums[next]);
				curr = next;
				count++;
			}
			while (curr != start);
		}
	}
}
