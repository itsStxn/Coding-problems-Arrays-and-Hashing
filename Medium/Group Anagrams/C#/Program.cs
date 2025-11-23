using Group_Anagrams;

Solution task = new();

IList<IList<string>> groups1 = task.GroupAnagrams(["eat","tea","tan","ate","nat","bat"]);
IList<IList<string>> groups2 = task.GroupAnagrams(["", ""]);
IList<IList<string>> groups3 = task.GroupAnagrams(["a"]);

foreach (IList<string> group in groups1) {
	Console.Write($"[{string.Join(", ", group)}] ");
}
Console.WriteLine();
foreach (IList<string> group in groups2) {
	Console.Write($"[{string.Join(", ", group)}] ");
}
Console.WriteLine();
foreach (IList<string> group in groups3) {
	Console.Write($"[{string.Join(", ", group)}] ");
}
