# Contains Duplicate

## Description
Given an integer array `nums`, return `true` if any value appears **at least twice** in the array, and return `false` if every element is **distinct**.

### Example 1:  
***Input:*** `nums` = [1,2,3,1]  
***Output:*** true

### Example 2:  
***Input:*** `nums` = [1,2,3,4]  
***Output:*** false

### Example 3:  
***Input:*** `nums` = [1,1,1,3,3,4,3,2,4,2]  
***Output:*** true

### Constraints:
- 1 <= `nums.length` <= 10^5  
- -10^9 <= `nums[i]` <= 10^9

## Strategy
Use a hashset to add values to it. If the add operation fails, return true.

## Time Complexity - O(n)
The code involves a for loop and an add operation.

## Space Complexity - O(n)
The hashset is used to store n the values.
