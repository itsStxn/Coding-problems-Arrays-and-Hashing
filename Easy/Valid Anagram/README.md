# Valid Anagram

## Description
Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically *using all the original letters exactly once*.

### Example 1:
***Input:*** `s` = "anagram", `t` = "nagaram"  
***Output:*** `true`

### Example 2:
***Input:*** `s` = "rat", `t` = "car"  
***Output:*** `false`

### Constraints:
- 1 <= `s.length`, `t.length` <= 5 * 10^4
- `s` and `t` consist of lowercase English letters.

***Follow up:*** What if the inputs contain Unicode characters? How would you adapt your solution to such a case?

## Strategy
### Alphabet sized array
Create an array of size 26 to store the count of each character.
Go through the array and if the count is not 0, return false.

### Hashmap
Create a hash map to store the count of each character for the first word.

Return `false` if the second word:
- Has characters that are not keys in the hash map.
- Tries to set the count to a negative value, it means it has a different count than the first word.

## Time Complexity - O(n)
Both approaches run one or more separate loops for n length of the input strings, which must be the same in order to be considered an anagram. 

## Space Complexity
### Alphabet sized array - O(1)
All the variables have constant size.

### Hashmap - O(n)
The hash map dynamically grows based on the number of characters of the first word and the number of not shared characters in the second word.
