# Add Two Numbers

## Problem Description

You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list, also in reverse order.

### Example 1:
**Input:**  
l1 = [2,4,3], l2 = [5,6,4]

**Output:**  
[7,0,8]

**Explanation:**  
342 + 465 = 807, so the output is [7,0,8].

---

### Example 2:
**Input:**  
l1 = [0], l2 = [0]

**Output:**  
[0]

---

### Example 3:
**Input:**  
l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]

**Output:**  
[8,9,9,9,0,0,0,1]

---

## Solution

The solution solves the problem by recursively adding the two numbers represented by linked lists, accounting for the carry-over at each step.

### Approach:

1. **Initialize a carry variable:** Start with a carry of 0.
2. **Traverse both linked lists:** Add corresponding digits from both lists along with any carry from the previous step.
3. **Handle uneven list lengths:** If one list is exhausted, continue with the remaining list and the carry.
4. **Create a new node for each sum:** For each iteration, create a new node with the sum modulo 10 (to store the single digit).
5. **Update the carry:** Carry over any value greater than or equal to 10 to the next iteration.
6. **Handle the final carry:** After processing both lists, if there's any carry left, create a new node with the carry value.
