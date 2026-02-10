using Next_Permutation;

var task = new Solution();
int[] test1 = [1,2,3];
int[] test2 = [3,2,1];
int[] test3 = [1,1,5];

task.NextPermutation(test1);
task.NextPermutation(test2);
task.NextPermutation(test3);

Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));
Console.WriteLine(string.Join(", ", test3));
