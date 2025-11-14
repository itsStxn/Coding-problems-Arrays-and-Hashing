# Group Anagrams

## Description
Given an array of strings `strs`, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

### Example 1:
***Input:*** `strs` = ["eat","tea","tan","ate","nat","bat"]
***Output:*** [["bat"],["nat","tan"],["ate","eat","tea"]]

### Example 2:
***Input:*** `strs` = [""]
***Output:*** [[""]]

### Example 3:
***Input:*** `strs` = ["a"]
***Output:*** [["a"]]

### Constraints:
- 1 <= `strs.length` <= 10^4
- 0 <= `strs[i].length` <= 100
- `strs[i]` consists of lowercase English letters.

## Strategy
Loop through `strs` and sort each string's characters. Store the sorted key and a list of strings with that string in a hash map. Return the values of the hash map as the output.

## Time Complexity - O(n x mlog(m))  
Each `strs` iteration involves a hash function that:
1. Takes *O(m)* time to convert the string input into an array of characters
2. Takes *O(nlog(m))* time to sort the array of characters
3. Takes *O(m)* time to convert the sorted array of characters into a string

Since the `strs` array is traversed once, the total time complexity is **O(n x mlog(m))**

## Space Complexity - O(n x m)
A string is an array of characters. 

### Hash function - O(m)
The generated sorted string takes the same length m as the input string. 

### Hash map keys - O(n x m)
The keys can be n at most. Those keys consume each *O(m)* space. 

### Hash map values - O(n x m)
The lists can hold up to n strings. Each string takes *O(m)* space.
