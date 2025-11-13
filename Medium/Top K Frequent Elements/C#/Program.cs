using Top_K_Frequent_Elements;

Solution task = new();
Console.WriteLine(string.Join(", ", task.TopKFrequent([1,1,1,2,2,3], 2)));
Console.WriteLine(string.Join(", ", task.TopKFrequent([1], 1)));
Console.WriteLine(string.Join(", ", task.TopKFrequent_Buckets([1,1,1,2,2,3], 2)));
Console.WriteLine(string.Join(", ", task.TopKFrequent_Buckets([1], 1)));
