# Permutation Sequence

## Problem

The set `[1, 2, 3, ..., n]` contains a total of `n!` unique permutations. By listing and labeling all of the permutations in order, we get the following sequence for `n = 3`:
123, 132, 213, 231, 312, 321

Given `n` and `k`, return the `k`-th permutation sequence.

### Example 1:
**Input:** `n = 3, k = 3`  
**Output:** `"213"`

### Example 2:
**Input:** `n = 4, k = 9`  
**Output:** `"2314"`

### Example 3:
**Input:** `n = 3, k = 1`  
**Output:** `"123"

## Solution

The solution recursively calculates the `k`-th permutation by considering the factorial of the remaining digits. 
The idea is to compute the first digit, recursively solve for the remaining digits, and adjust the value of `k` accordingly.

