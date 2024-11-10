# First Missing Positive

## Problem

Given an unsorted integer array `nums`, return the smallest missing positive integer.

You must implement an algorithm that runs in O(n) time and uses constant extra space.

### Example 1:
**Input**: `nums = [1,2,0]`  
**Output**: `3`  
**Explanation**: The numbers in the range [1, 2] are all in the array, so the next smallest positive integer is 3.

### Example 2:
**Input**: `nums = [3,4,-1,1]`  
**Output**: `2`  
**Explanation**: 1 is in the array but 2 is missing.

### Example 3:
**Input**: `nums = [7,8,9,11,12]`  
**Output**: `1`  
**Explanation**: The smallest positive integer 1 is missing.

## Approach

The algorithm works by first marking all valid positive integers that lie within the range of the array length in a boolean array. Then it scans the boolean array to find the first index that is not marked, indicating the smallest missing positive integer.

### Solution Steps:
1. Create a boolean array to track the presence of numbers in the valid range (1 to `nums.Length`).
2. Iterate through the input array and mark the corresponding indices in the boolean array.
3. Check the boolean array for the first `false` value, and return the corresponding index + 1.
4. If all numbers in the range are present, return `nums.Length + 1`.
