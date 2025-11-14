# Top K Frequent Elements

## Description
Given an integer array `nums` and an integer `k`, return the `k` most frequent elements. You may return the answer in any order.

### Example 1:
***Input:*** `nums` = [1,1,1,2,2,3], `k` = 2  
***Output:*** [1,2]

### Example 2:
***Input:*** `nums` = [1], `k` = 1  
***Output:*** [1]

### Constraints:
- 1 <= `nums.length` <= 10^5
- -10^4 <= `nums[i]` <= 10^4
- `k` is in the range [*1, the number of unique elements in the array*].
- It is guaranteed that the answer is unique.

***Follow up:*** Your algorithm's time complexity must be better than O(n log n), where n is the array's size.

## Strategy
Use a hash table to count the number of times each element appears in the array.
Use either a priority queue or a bucket list to store the top `k` elements.

### Priority Queue
It allows you to enqueue a number and its count while also dequeue the number with the smallest count. Dequeu when the queue length is longer than `k`.

### Bucket List
Group numbers by their count. Then iterate through the list from the highest count possible, which is n. Run the loop until finding the top `k` numbers.

## Time Complexity - O(n)
The loops on each approach iterate n times and do not inplement more time complex operations.

## Space Complexity - O(n)
The dynamic data structures on each approach use n space.
