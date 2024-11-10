# Largest Rectangle in Histogram

## Problem Description

Given an array of integers `heights` representing the histogram's bar height, where the width of each bar is 1, return the area of the largest rectangle in the histogram.

### Example 1:
**Input:** `heights = [2,1,5,6,2,3]`  
**Output:** `10`  
Explanation: The largest rectangle is formed by the bars at heights `5` and `6`, and has an area of `10` units.

### Example 2:
**Input:** `heights = [2,4]`  
**Output:** `4`

## Solution

The algorithm calculates the largest rectangle area in a histogram using a two-pass approach:

1. **First Pass:** It calculates the furthest left index (`furthestHigherLeftNeighbor`) for each bar where the height of the bar is less than the current bar.
2. **Second Pass:** It calculates the furthest right index (`furthestHigherRightNeighbor`) for each bar where the height of the bar is less than the current bar.
3. **Final Step:** Using the left and right bounds, it calculates the area for each bar and returns the maximum area found.
