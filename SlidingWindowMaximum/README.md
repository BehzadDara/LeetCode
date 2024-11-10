# Sliding Window Maximum

## Problem Description

You are given an array of integers `nums`, and a sliding window of size `k` that moves from the leftmost to the rightmost side of the array. At each position, you can only see the `k` numbers in the window. After each move, the window shifts one position to the right. Your task is to return the maximum value in each sliding window.

### Example 1:
**Input:**  
`nums = [1,3,-1,-3,5,3,6,7]`, `k = 3`

**Output:**  
`[3,3,5,5,6,7]`

**Explanation:**

| Window Position           | Max  |
|---------------------------|------|
| [1 3 -1] -3 5 3 6 7       | 3    |
| 1 [3 -1 -3] 5 3 6 7       | 3    |
| 1 3 [-1 -3 5] 3 6 7       | 5    |
| 1 3 -1 [-3 5 3] 6 7       | 5    |
| 1 3 -1 -3 [5 3 6] 7       | 6    |
| 1 3 -1 -3 5 [3 6 7]       | 7    |

### Example 2:
**Input:**  
`nums = [1]`, `k = 1`

**Output:**  
`[1]`

---

## Solution

The solution uses a sliding window approach and a custom linked list to efficiently keep track of the maximum values in each window.

### Approach:

1. **Sliding Window:** The algorithm slides a window of size `k` over the array, maintaining the current maximum at each window position.
2. **Custom Linked List:** A custom `MyLinkedList` class is used to keep track of the indices of elements in the current window. The list is maintained in a way that ensures the largest value is always at the front.
3. **Efficient Removal:** As the window slides, elements that are no longer part of the window are removed. Additionally, smaller elements in the list are removed to ensure that the largest element remains at the front.
