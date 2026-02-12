# Number of Good Pairs

## Description
Given an array of integers nums, return the number of good pairs.

A pair `(i, j)` is called good if `nums[i] == nums[j]` and `i < j`.

### Example 1
***Input***: `nums = [1,2,3,1,1,3]`  
***Output***: 4  
***Explanation***: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.

### Example 2
***Input***: `nums = [1,1,1,1]`  
***Output***: 6  
***Explanation***: Each pair in the array are good.

### Example 3
***Input***: `nums = [1,2,3]`  
***Output***: 0  

### Constraints
- `1 <= nums.length <= 100`
- `1 <= nums[i] <= 100`

## Strategy
Count each number's frequency.

When counting the frequency, you are also counting the possible couples. For example, let's say that number 3 was found twice and it has just been found again. It's current count is 2, but is is also the number of couples the newly found 3 can form with the others.

## Time Complexity - O(n)
Each number is processed once.

## Space Complexity - O(n)
A dictionary of `n` size is used.
