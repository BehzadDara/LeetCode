# Trapping Rain Water

## Problem Description

Given an array of non-negative integers representing an elevation map where the width of each bar is 1, the task is to compute how much water can be trapped after raining.

### Example 1:
**Input:**  
`height = [0,1,0,2,1,0,1,3,2,1,2,1]`

**Output:**  
`6`

**Explanation:**  
In this case, 6 units of rainwater (the blue section) are being trapped between the bars.

### Example 2:
**Input:**  
`height = [4,2,0,3,2,5]`

**Output:**  
`9`

**Explanation:**  
9 units of rainwater are trapped between the bars.

---

## Solution

The solution involves iterating through the elevation map to calculate how much water can be trapped at each index. The strategy is to look for valleys between higher elevations and calculate the trapped water between them.

### Approach:

1. **Find Peaks and Valleys:** Traverse the array to identify peaks and valleys where water can accumulate.
2. **Calculate Water Trapped:** For each valley, calculate the water trapped by comparing the current height with the minimum of the two surrounding peaks.
3. **Accumulate the Water:** Add the trapped water to the result if the calculated water is positive.
