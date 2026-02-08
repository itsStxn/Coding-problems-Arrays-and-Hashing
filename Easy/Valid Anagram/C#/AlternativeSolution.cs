using System;

namespace Valid_Anagram;

public class AlternativeSolution : Solution {
	override public bool IsAnagram(string s, string t) {
		if (s.Length != t.Length) return false;
		else if (s == t) return true;

		Dictionary<char, int> charCount = [];
		foreach (char c in s) {
				if (charCount.TryGetValue(c, out int val)) {
					charCount[c] = ++val;
				} else charCount.Add(c, 1);
		}
		foreach (char c in t) {
				if (charCount.TryGetValue(c, out int val) && val > 0) {
					charCount[c] = --val;
				} else return false;
		}

		return true;
	}
}
