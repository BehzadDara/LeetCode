# Number of Digit One

## Problem Description

Given an integer `n`, count the total number of times the digit `1` appears in all non-negative integers less than or equal to `n`.

### Example 1:
**Input:**  
`n = 13`

**Output:**  
`6`

**Explanation:**  
The numbers less than or equal to 13 that contain at least one `1` are: `1, 10, 11, 12, 13`. So the total count is 6.

### Example 2:
**Input:**  
`n = 0`

**Output:**  
`0`

**Explanation:**  
There are no numbers less than or equal to 0 that contain the digit `1`.

For more details, check out the [LeetCode problem page](https://leetcode.com/problems/number-of-digit-one/).

---

## Solution

The solution involves iterating over the digits of the number `n` and counting how many times the digit `1` appears in each place (ones, tens, hundreds, etc.).

### Approach:

1. **Digit Analysis:** For each place (ones, tens, hundreds), we calculate how many times `1` appears in that place.
2. **Counting `1` in Each Digit Place:** Based on the current digit, we update the count of `1` appearances.
   - If the digit is 0, it contributes no additional `1` to that place.
   - If the digit is 1, we count all numbers formed by the digits before and after it.
   - If the digit is greater than 1, all the numbers in that place contribute a `1`.
