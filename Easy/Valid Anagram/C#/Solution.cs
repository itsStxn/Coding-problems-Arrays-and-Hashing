using System;

namespace Valid_Anagram;

public class Solution {
	virtual public bool IsAnagram(string s, string t) {
		if (s.Length != t.Length) return false;
		else if (s == t) return true;

		int[] charCount = new int[26];
		for (int i = 0; i < s.Length; i++) {
				charCount[s[i] - 'a']++;
				charCount[t[i] - 'a']--;
		}
		foreach (int count in charCount) {
				if (count != 0) return false;
		}

		return true;
	}
}
