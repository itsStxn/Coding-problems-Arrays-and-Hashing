# Product of Array Except Self

## Description
Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in **O(n)** time and without using the division operation.

### Example 1:
***Input:*** `nums` = [1,2,3,4]  
***Output:*** [24,12,8,6]

### Example 2:
***Input:*** `nums` = [-1,1,0,-3,3]  
***Output:*** [0,0,9,0,0]

### Constraints:
- 2 <= `nums.length` <= 10^5
- -30 <= `nums[i]` <= 30
- The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

**Follow up:** Can you solve the problem in **O(1)** extra space complexity?  
*(The output array does not count as extra space for space complexity analysis.)*

## Strategy
Create the `answer` array. Iterate through `nums` contemporarily from left and right pointers. 

Use the pointers to insert the right and left accumulations to `answer`. Accumulate the current numbers from both directions.  

## Time Complexity - O(n)
The code runs a single loop that traverses the array once. The operations in the loop take constant time.

## Space Complexity
### Output array - O(n)
The `answer` array becomes the same size as the input array.

### Follow up - O(1)
If we ignore the space complexity of the `answer` array, the space complexity is costant, as the remaining variables are constant in size.
