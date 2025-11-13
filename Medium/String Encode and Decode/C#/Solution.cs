namespace String_Encode_and_Decode;

public class Solution {
	public string Encode(IList<string> strs) {
		string result = string.Empty;
		foreach (var str in strs) {
			result += $"{str.Length}#{str}";
		}

		return result;
	}

	public List<string> Decode(string s) {
		List<string> result = [];
		
		string length = string.Empty;
		for (int i = 0; i < s.Length; i++) {
			if (s[i] != '#') length += s[i];
			else {
				result.Add(string.Empty);
				int stop = i + int.Parse(length);
				length = string.Empty;
				while (i < stop) {
					result[^1] += s[++i];
				}
			}
		}

		return result;
	}
}
