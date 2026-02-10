using Rotate_Array;

var task = new Solution();
int[] test1 = [1,2,3,4,5,6,7];
int[] test2 = [-1,-100,3,99];
task.Rotate(nums: test1, k: 3);
task.Rotate(nums: test2, k: 3);
Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));

task = new AlternativeSolution1();
test1 = [1,2,3,4,5,6,7];
test2 = [-1,-100,3,99];
task.Rotate(nums: test1, k: 3);
task.Rotate(nums: test2, k: 3);
Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));

task = new AlternativeSolution2();
test1 = [1,2,3,4,5,6,7];
test2 = [-1,-100,3,99];
task.Rotate(nums: test1, k: 3);
task.Rotate(nums: test2, k: 3);
Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));
