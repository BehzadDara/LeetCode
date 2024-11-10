# Candy

## Problem Description

There are `n` children standing in a line. Each child is assigned a rating value given in the integer array `ratings`.

You are distributing candies to these children under the following requirements:

- Each child must have at least one candy.
- Children with a higher rating get more candies than their neighbors.

Return the minimum number of candies you need to have to distribute the candies to the children.

### Example 1:
**Input:**  
`ratings = [1, 0, 2]`

**Output:**  
`5`

**Explanation:**  
You can allocate to the first, second, and third child with 2, 1, 2 candies respectively.

### Example 2:
**Input:**  
`ratings = [1, 2, 2]`

**Output:**  
`4`

**Explanation:**  
You can allocate to the first, second, and third child with 1, 2, and 1 candies respectively.  
The third child gets 1 candy because it satisfies the above two conditions.

---

## Solution

### Approach:

We solve this problem using a greedy approach:

1. **Initialization:** Create an array `result[]` where each element represents the number of candies assigned to each child.
2. **First Pass (Left to Right):** Traverse through the `ratings` array. If a child has a higher rating than the child before them, they get more candies. Otherwise, reset their candy count.
3. **Second Pass (Right to Left):** Traverse through the array from right to left. If a child has a higher rating than the child after them, we ensure they have more candies than the child after them by updating the candy count.
4. **Final Result:** The sum of all candies in the `result[]` array gives the minimum number of candies required.
