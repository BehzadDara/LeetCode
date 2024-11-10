# Earliest Possible Day of Full Bloom

## Problem Description

You have `n` flower seeds, and each seed requires planting time and growth time before it blooms. The planting process can happen in any order, but the goal is to determine the earliest day when all seeds are blooming.

You are given two arrays:
- `plantTime[i]` - The number of days it takes to plant the `i`-th seed.
- `growTime[i]` - The number of days it takes the `i`-th seed to grow after it has been planted.

You can plant seeds in any order, but the goal is to find the earliest day when all seeds are blooming.

### Example 1:
**Input:**  
`plantTime = [1, 4, 3]`, `growTime = [2, 3, 1]`

**Output:**  
`9`

**Explanation:**  
One optimal way is:
- On day 0, plant the 0th seed (it blooms on day 3).
- On days 1, 2, 3, and 4, plant the 1st seed (it blooms on day 8).
- On days 5, 6, and 7, plant the 2nd seed (it blooms on day 9).
Thus, on day 9, all seeds are blooming.

### Example 2:
**Input:**  
`plantTime = [1, 2, 3, 2]`, `growTime = [2, 1, 2, 1]`

**Output:**  
`9`

**Explanation:**  
One optimal way is:
- On day 1, plant the 0th seed (it blooms on day 4).
- On days 0 and 3, plant the 1st seed (it blooms on day 5).
- On days 2, 4, and 5, plant the 2nd seed (it blooms on day 8).
- On days 6 and 7, plant the 3rd seed (it blooms on day 9).
Thus, on day 9, all seeds are blooming.

### Example 3:
**Input:**  
`plantTime = [1]`, `growTime = [1]`

**Output:**  
`2`

**Explanation:**  
On day 0, plant the 0th seed (it blooms on day 2).

---

## Solution

The solution involves sorting the seeds by their growth time in descending order. This ensures that seeds that take longer to grow are planted first, maximizing the chance of earlier blooming.

### Approach:

1. **Sorting:** Sort the seeds in descending order by their `growTime` to prioritize seeds that take longer to grow.
2. **Planting and Growing:** For each seed, we incrementally add its `plantTime` to the total days and calculate the bloom day by adding the `growTime`.
3. **Maximizing Bloom Day:** Track the latest bloom day and return the result.
