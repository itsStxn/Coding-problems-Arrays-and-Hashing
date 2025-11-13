using Group_Anagrams;

Solution task = new();

IList<IList<string>> case1 = task.GroupAnagrams(["eat","tea","tan","ate","nat","bat"]);
IList<IList<string>> case2 = task.GroupAnagrams(["", ""]);
IList<IList<string>> case3 = task.GroupAnagrams(["a"]);

foreach (IList<string> redord in case1) {
    Console.WriteLine(string.Join(", ", redord));
}
foreach (IList<string> redord in case2) {
    Console.WriteLine(string.Join(", ", redord));
}
foreach (IList<string> redord in case3) {
    Console.WriteLine(string.Join(", ", redord));
}
