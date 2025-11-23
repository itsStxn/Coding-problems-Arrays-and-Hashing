using System;

namespace Group_Anagrams;


public class Solution {
	public IList<IList<string>> GroupAnagrams(string[] strs) {
		Dictionary<string, List<string>> groups = [];

		foreach (string s in strs) {
			int[] freq = new int[26];
			foreach (char c in s)
				freq[c - 'a']++;

			string key = string.Join(',', freq);
			if (!groups.TryGetValue(key, out var group)) {
				group = [];
				groups.Add(key, group);
			}

			group.Add(s);
		}

		return [..groups.Values];
	}
}
