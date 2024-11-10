## 3Sum

### Problem Description

Given an integer array `nums`, return all the triplets `[nums[i], nums[j], nums[k]]` such that:

- `i != j`, `i != k`, and `j != k`
- `nums[i] + nums[j] + nums[k] == 0`

### Example 1:

Input: `nums = [-1,0,1,2,-1,-4]`

Output: `[[-1,-1,2],[-1,0,1]]`

Explanation:  
- `nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0`
- `nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0`
- `nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0`

The distinct triplets are `[-1,0,1]` and `[-1,-1,2]`.  
Note: The order of the output does not matter.

### Example 2:

Input: `nums = [0,1,1]`

Output: `[]`

Explanation: The only possible triplet does not sum up to 0.

### Example 3:

Input: `nums = [0,0,0]`

Output: `[[0,0,0]]`

Explanation: The only possible triplet sums up to 0.

### Solution

The solution involves finding all unique triplets that sum up to zero using the following steps:

1. Sort the input array `nums`.
2. Iterate through the array, using each element as the first element of a potential triplet.
3. Use two nested loops to find pairs that sum with the current element to 0.
4. Skip duplicates to ensure all triplets are unique.
