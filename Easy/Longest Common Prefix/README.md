# Longest Common Prefix

## Description
Write a function to find the **longest common prefix** string amongst an array of strings. If there is no common prefix, return an empty string `""`.

### Example 1:  
***Input:*** `strs` = ["flower","flow","flight"]  
***Output:*** "fl"

### Example 2:  
***Input:*** `strs` = ["dog","racecar","car"]  
***Output:*** ""  
***Explanation:***  
- There is no common prefix among the input strings.

### Constraints: 
- 1 <= `strs.length` <= 200  
- 0 <= `strs[i].length` <= 200  
- `strs[i]` consists of only lowercase English letters.

## Strategy
Use the first string as a reference prefix. Compare the characters of the prefix to each word. Stop at the shortest word length. Check the amount of same characters, and cut the prefix to that length.

## Time Complexity: O(n x m)
Each iteration of n words in strs will iterate through a maximum of m characters of the prefix.

## Space Complexity: O(n)
The size of prefix depends on the input. It can only decrease in size throughout the iterations.
