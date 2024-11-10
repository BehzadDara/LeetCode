## Reverse Integer

### Problem Description

Given a signed 32-bit integer `x`, return `x` with its digits reversed. If reversing `x` causes the value to go outside the signed 32-bit integer range `[-231, 231 - 1]`, then return `0`.

### Example 1:

Input: `x = 123`  
Output: `321`

### Example 2:

Input: `x = -123`  
Output: `-321`

### Example 3:

Input: `x = 120`  
Output: `21`

### Example 4:

Input: `x = -2147483648`  
Output: `0`  
Explanation: The reversed integer overflows, so we return `0`.

### Solution

The solution reverses the digits of the given integer, ensuring that the reversed value does not exceed the limits of a 32-bit signed integer. 
The approach involves converting the integer to a string, reversing the string, and then converting it back to an integer. 
If any overflow occurs during the conversion, the function returns `0`.
