# Longest Consecutive Sequence

## Description
Given an unsorted array of integers nums, return the length of the *longest consecutive elements sequence*.

You must write an algorithm that runs in **O(n)** time.

### Example 1:
***Input:*** `nums` = [100,4,200,1,3,2]  
***Output:*** 4  
***Explanation:*** 
- The longest consecutive elements sequence is [1, 2, 3, 4]. 
- Therefore its length is 4.

### Example 2:
***Input:*** `nums` = [0,3,7,2,5,8,4,6,0,1]  
***Output:*** 9

### Constraints:
- 0 <= `nums.length` <= 10^5
- -10^9 <= `nums[i]` <= 10^9

## Strategy
Iterate through the an hashset generated from input array. Process only the numbers that do not have a previous one in the set. Keep removing those number's next values from the hashset. Return the longest removal streak.

## Time Complexity - O(n)
Generating a hashset from the input array takes `n` time. Also, the loop detects sequence starters and tries to remove the sequence from the hashset. 

## Space Complexity - O(n)
The hashset is generated from the input array.
