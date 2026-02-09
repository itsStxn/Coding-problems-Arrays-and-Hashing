# Subarray Sum Equals K

## Description
Given an array of integers `nums` and an integer `k`, return the total number of subarrays whose sum equals to `k`.

A subarray is a contiguous non-empty sequence of elements within an array.

### Example 1
***Input***: nums = [1,1,1], k = 2  
***Output***: 2  

### Example 2
***Input***: nums = [1,2,3], k = 3  
***Output***: 2  

### Constraints
- 1 <= `nums.length` <= 2 * 10^4
- -1000 <= `nums[i]` <= 1000
- -10^7 <= `k` <= 10^7

## Strategy
All it takes is computing a prefix sum array. 

Build a dictionary to store frequencies of the sums seen so far. While computing, see if there is a stored sum that is equal to the current `sum - k`. If so, get the frequency and add it to a count variable. Basically you want to know if there are subarrays that we can cut off the current one in order to achieve the sum of `k`. The amount of times a subarray like this exists corresponds to different ways to achieve the sum of `k`.  

## Time Complexity - O(n)
Each element is processed once.

## Space Complexity - O(n)
A prefix sum array is created.
