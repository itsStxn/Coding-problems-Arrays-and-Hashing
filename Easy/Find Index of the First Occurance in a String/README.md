# Find Index of the First Occurance in a String

## Description
Given two strings needle and haystack, return the `index` of the **first occurrence** of needle in haystack, or **-1** if needle is not part of haystack.

### Example 1:
***Input:*** `haystack` = "sadbutsad", `needle` = "sad"  
***Output:*** 0  
***Explanation:***
- "sad" occurs at `index` 0 and 6. The first occurrence is at `index` 0, so we return 0.

### Example 2:
***Input:*** `haystack` = "leetcode", `needle` = "leeto"  
***Output:*** -1  
***Explanation:*** 
- "leeto" did not occur in "leetcode", so we return -1.

### Constraints:
- 1 <= `haystack.length`, `needle.length` <= 104
- `haystack` and `needle` consist of only lowercase English characters.

## Strategy
Iterate through the haystack and compare each character with the needle. When characters match, run a while loop that checks characters until the length of the needle. If the length is reached, return the start index of the while loop.  

## Time Complexity - O(n)
The runtime depends on the length of the haystack and the length of the needle at a linear level.

## Space Complexity - O(1)
No data structure variables with `n` size are used.
