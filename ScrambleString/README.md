# Scramble String

## Problem

We can scramble a string s to get a string t using the following algorithm:

If the length of the string is 1, stop.

If the length of the string is > 1, do the following:

Split the string into two non-empty substrings at a random index, i.e., 
if the string is s, divide it to x and y where s = x + y.

Randomly decide to swap the two substrings or to keep them in the same order. i.e., 
after this step, s may become s = x + y or s = y + x.

Apply step 1 recursively on each of the two substrings x and y.

Given two strings s1 and s2 of the same length, 
return true if s2 is a scrambled string of s1, 
otherwise, return false.

### Example 1:
**Input**: s1 = "great", s2 = "rgeat"
**Output**: true
**Explanation**: One possible scenario applied on s1 is:
"great" --> "gr/eat" // divide at random index.
"gr/eat" --> "gr/eat" // random decision is not to swap the two substrings and keep them in order.
"gr/eat" --> "g/r / e/at" // apply the same algorithm recursively on both substrings. divide at random index each of them.
"g/r / e/at" --> "r/g / e/at" // random decision was to swap the first substring and to keep the second substring in the same order.
"r/g / e/at" --> "r/g / e/ a/t" // again apply the algorithm recursively, divide "at" to "a/t".
"r/g / e/ a/t" --> "r/g / e/ a/t" // random decision is to keep both substrings in the same order.
The algorithm stops now, and the result string is "rgeat" which is s2.
As one possible scenario led s1 to be scrambled to s2, we return true.

### Example 2:
**Input**: s1 = "abcde", s2 = "caebd"
**Output**: false

### Example 3:
**Input**: s1 = "a", s2 = "a"
**Output**: true

## Approach

This problem is best solved using recursion with memoization. 
The idea is to recursively split the strings at every possible index and check whether the substrings match, either in the original order or after swapping.

Before diving into recursion, we do a pruning check:
If both strings don't have the same frequency of characters, return false immediately — they can't be scrambles of each other.

### Solution Steps:

1. Base Cases:

If s1 == s2, return true.
If s1.Length != s2.Length, return false.
If the characters in both strings don't match in count, return false.

2. Memoization:

Use a dictionary to cache results of (s1, s2) pairs.

3. Recursive Splitting:
For every index i from 1 to s1.Length - 1, split s1 and s2 into two parts.

Check two cases:
Without swapping: s1[0..i] vs s2[0..i] AND s1[i..] vs s2[i..]
With swapping: s1[0..i] vs s2[-i..] AND s1[i..] vs s2[0..-i]

If any combination returns true, memoize and return true.

4. If no valid split found, memoize and return false.

A. Time Complexity

O(N³) due to:
O(N²) different substring pairs
O(N) splits per pair

B. Space Complexity

O(N²) for memoization dictionary
O(N) recursion stack depth