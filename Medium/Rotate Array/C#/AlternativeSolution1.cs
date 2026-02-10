using System;

namespace Rotate_Array;

public class AlternativeSolution1 : Solution {
	override public void Rotate(int[] nums, int k) {
		void reverse(int left, int right) {
			while (left < right) {
				(nums[left], nums[right]) = (nums[right], nums[left]);
				left++;
				right--;
			}
		}

		int n = nums.Length;
		k %= n;
		reverse(0, n - 1);
		reverse(0, k - 1);
		reverse(k, n - 1);
	}
}
