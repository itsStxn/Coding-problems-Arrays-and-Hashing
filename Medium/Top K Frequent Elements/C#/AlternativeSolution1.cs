using System;

namespace Top_K_Frequent_Elements;

public class AlternativeSolution1 : Solution {
	override public int[] TopKFrequent(int[] nums, int k) {
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
}
