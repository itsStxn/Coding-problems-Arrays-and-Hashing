using Number_of_Good_Pairs;

var task = new Solution();
Console.WriteLine(task.NumIdenticalPairs(nums: [1,2,3,1,1,3]));
Console.WriteLine(task.NumIdenticalPairs(nums: [1,1,1,1]));
Console.WriteLine(task.NumIdenticalPairs(nums: [1,2,3]));

task = new AlternativeSolution();
Console.WriteLine(task.NumIdenticalPairs(nums: [1,2,3,1,1,3]));
Console.WriteLine(task.NumIdenticalPairs(nums: [1,1,1,1]));
Console.WriteLine(task.NumIdenticalPairs(nums: [1,2,3]));
