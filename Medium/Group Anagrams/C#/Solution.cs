namespace Group_Anagrams;


public class Solution {
    private string HashFunction(string s) {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);

        return new(chars);
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramsMap = [];

        foreach (string s in strs) {
            string key = HashFunction(s);
            if (anagramsMap.TryGetValue(key, out List<string>? val)) {
                val.Add(s);
            } else anagramsMap.Add(key, [s]);
        }

        return [..anagramsMap.Values];
    }
}
