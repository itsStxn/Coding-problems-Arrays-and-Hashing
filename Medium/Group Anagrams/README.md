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
Anagrams share the same frequency map of their characters.

For each word, get a frequency map. Use that map as a dictionary key that points to value lists that store anagrams.  

## Time Complexity - O(n x m)  
The a frequency map is generated `n` times. In order to carry out the frequency, `m` characters for each word need to be read.

## Space Complexity - O(n)
A dictionary stores `n` keys and values. 
