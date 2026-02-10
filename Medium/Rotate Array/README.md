# Rotate Array

## Description
Given an integer array `nums`, rotate the array to the right by `k` steps, where `k` is non-negative.

### Example 1
***Input***: `nums` = [1,2,3,4,5,6,7], `k` = 3  
***Output***: [5,6,7,1,2,3,4]  
***Explanation***:  
- rotate 1 steps to the right: [7,1,2,3,4,5,6]
- rotate 2 steps to the right: [6,7,1,2,3,4,5]
- rotate 3 steps to the right: [5,6,7,1,2,3,4]

### Example 2
***Input***: `nums` = [-1,-100,3,99], `k` = 2  
***Output***: [3,99,-1,-100]  

### Constraints
- 1 <= `nums.length` <= 10^5
- -2^31 <= `nums[i]` <= 2^31 - 1
- 0 <= `k` <= 10^5

## Strategy

### Method 1
Create an extra array to store the result. For each number in the original array of `n` numbers, add `k` to its index `k` and mod it by `n` (to keep it bound to the array's length). The value of this index is used to store the number to the result array.

### Method 2
Reverse the array, then reverse the array up to `k`, and then reverse it from `k` onwards.

### Method 3
Juggle a value starting at an index. The jubbling happens from an index to index + `k`, index + 2k... until reaching the start index (meaning that a cycle is completed). 

If the value of `n` and `k` are coprime (= their greatest common divisor is 1), all it takes is 1 juggling cycle. If not coprime, there will be different cycles starting at different indexes up to `n`.

Each time that a juggle is complete, it should be tracked in a count variable. The operation is completed when count reaches `n`. Basically, if `n` and `k` are coprime, all it takes is 1 cycle that has `n` juggles. If not, there will be multiple cycles that sum up to `n` juggles. 

## Time Complexity - O(1)
All methods visit each index once on average.

## Space Complexity

### Method 1 - O(n)
An extra array is created to store the result.

### Method 2 and 3 - O(1)
No data structures of size `n` are used.
