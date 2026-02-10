using System;

namespace Next_Permutation;

public class Solution {
	public void NextPermutation(int[] nums) {
		int n = nums.Length;
		int pivot = -1;
		
		for (int i = n - 2; i >= 0; i--) {
			if (nums[i] < nums[i + 1]) {
				pivot = i;
				break;
			}
		}

		if (pivot == -1) {
			Reverse(nums, 0, n - 1);
			return;
		}

		int r = n - 1;
		int l = pivot + 1;
		Reverse(nums, l, r);

		int search = nums[pivot];
		int swapIdx = BinarySearch(nums, search, l, r);
		Swap(nums, pivot, swapIdx);
	}

	private static void Swap(int[] arr, int i, int j) {
		(arr[i], arr[j]) = (arr[j], arr[i]);
	}

	private static void Reverse(int[] arr, int left, int right) {
		while (left < right) {
			Swap(arr, left, right);
			left++;
			right--;
		}
	}

	private static int BinarySearch(int[] nums, int target, int left, int right) {
		int result = -1;
		
		while (left <= right) {
			int mid = left + (right - left) / 2;
			if (nums[mid] > target) {
				result = mid;
				right = mid - 1;
			}
			else
				left = mid + 1;
		}

		return result;
	}
}
