using Top_K_Frequent_Elements;


var task = new Solution();
Console.WriteLine(string.Join(", ", task.TopKFrequent([1,1,1,2,2,3], 2)));
Console.WriteLine(string.Join(", ", task.TopKFrequent([1], 1)));

task = new AlternativeSolution1();
Console.WriteLine(string.Join(", ", task.TopKFrequent([1,1,1,2,2,3], 2)));
Console.WriteLine(string.Join(", ", task.TopKFrequent([1], 1)));

task = new AlternativeSolution2();
Console.WriteLine(string.Join(", ", task.TopKFrequent([1,1,1,2,2,3], 2)));
Console.WriteLine(string.Join(", ", task.TopKFrequent([1], 1)));
