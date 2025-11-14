# Remove Duplicates from Sorted Array

## Description
Given an integer array `nums` *sorted in **non-decreasing** order*, remove the duplicates in-place such that *each unique element appears only once*. The relative order of the elements should be kept the same. Then return the **number of unique elements** in `nums`.

Consider the **number of unique elements** of `nums` to be `k`, to get accepted, you need to do the following things:

1. Change the array `nums` such that the first `k` elements of `nums` *contain the unique elements in the order they were present in `nums` initially*. 
2. The remaining elements of `nums` are not important as well as the size of nums.
3. Return `k`.

### Custom Judge:  
***The judge will test your solution with the following code:***

int[] `nums` = [...]; *// Input array*  
int[] `expectedNums` = [...]; *// The expected answer with correct length*

int `k` = removeDuplicates(`nums`); *// Calls your implementation*

assert `k` == `expectedNums.length`;  
for (int i = 0; i < k; i++) {  
&emsp;assert `nums[i]` == `expectedNums[i]`;  
}

***If all assertions pass, then your solution will be accepted.***

### Example 1:
***Input:*** nums = [1,1,2]  
***Output:*** 2, `nums` = [1,2,_]  
***Explanation:*** 
- Your function should return `k` = 2, with the first two elements of `nums` being 1 and 2 respectively.
- It does not matter what you leave beyond the returned `k` (hence they are underscores).

### Example 2:
***Input:*** `nums` = [0,0,1,1,1,2,2,3,3,4]  
***Output:*** 5, `nums` = [0,1,2,3,4, _, _, _, _, _]  
***Explanation:*** 
- Your function should return `k` = 5, with the first five elements of `nums` being 0, 1, 2, 3, and 4 respectively.
- It does not matter what you leave beyond the returned `k` (hence they are underscores).

### Constraints:
- 1 <= `nums.length` <= 3 * 10^4  
- -100 <= `nums[i]` <= 100  
- `nums` is sorted in non-decreasing order.

## Strategy
Iterate throught `nums`. Use a pointer to uniquely set the position of the elements. Make the pointer increase only if the element differs from the previous one. 

End the loop when reaching a number that is the same as last one. This means reaching the largest number in the array. It would be pointless to go through copies of the largest number.

## Time Complexity - O(n)
The code involves iterating through the array once. No complex operations are involved in the loop. 

## Space Complexity - O(1)
The code updates the array in-place. No extra space is used.
