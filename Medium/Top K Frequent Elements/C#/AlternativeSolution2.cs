using System;

namespace Top_K_Frequent_Elements;

public class AlternativeSolution2 : Solution {
	public int[] TopKFrequent_Queue(int[] nums, int k) {
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
