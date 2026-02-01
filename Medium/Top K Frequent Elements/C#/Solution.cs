using System;

namespace Top_K_Frequent_Elements;

public class Solution {
	public int[] TopKFrequent(int[] nums, int k) {
		//? Bucket approach #1
		Dictionary<int, int> freq = [];
		List<HashSet<int>> freqGroups = [];

		foreach (int n in nums) {
			if (freq.TryGetValue(n, out int count)) {
				freqGroups[count - 1].Remove(n);
				freq[n] = ++count;
			}
			else {
				count = 1;
				freq.Add(n, count);
			}

			if (count <= freqGroups.Count) 
				freqGroups[count - 1].Add(n);
			else
				freqGroups.Add(new([n]));
		}

		var ans = new int[k]; 
		int idx = 0;

		for (int i = 1; i <= nums.Length; i++) {
			foreach (int n in freqGroups[^i]) {
				ans[idx++] = n;

				if (idx == k)
					return ans;
			}
		}

		return ans;
	}

	public int[] TopKFrequent_Buckets(int[] nums, int k) {
		//? Bucket approach #2
		int n = nums.Length;
		Dictionary<int, int> countMap = [];
		List<int>[] rows = new List<int>[n + 1];

		foreach (int num in nums) {
				if (countMap.TryGetValue(num, out int count)) {
					countMap[num] = ++count;
				}
				else countMap[num] = 1;
		}

		foreach ((int num, int count) in countMap) {
				if (rows[count] == null) rows[count] = [num];
				else rows[count].Add(num);
		}
	
		List<int> topK = [];
		for (int i = n; i >= 0 && topK.Count < k; i--) {
				if (rows[i] != null) topK.AddRange(rows[i]);
		}

		return [..topK];
	}

	public int[] TopKFrequent_Queue(int[] nums, int k) {
		//? Priority queue approach
		PriorityQueue<int, int> freq = new();
		Dictionary<int, int> countMap = [];

		foreach (int num in nums) {
				if (countMap.TryGetValue(num, out int count))
					countMap[num] = ++count;
				else 
					countMap.Add(num, 1);
		}

		foreach ((int num, int count) in countMap) {
				freq.Enqueue(num, count);
				if (freq.Count > k) 
					freq.Dequeue();
		}

		var topK = new int[k];
		for (int i = k - 1; i >= 0; i--)
				topK[i] = freq.Dequeue();

		return topK;
	}

}
