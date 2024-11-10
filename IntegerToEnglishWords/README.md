# Integer to English Words

## Problem

Given a non-negative integer `num`, convert it to its English words representation.

### Example 1:
**Input:** `num = 123`  
**Output:** `"One Hundred Twenty Three"`

### Example 2:
**Input:** `num = 12345`  
**Output:** `"Twelve Thousand Three Hundred Forty Five"`

### Example 3:
**Input:** `num = 1234567`  
**Output:** `"One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"`

## Solution

The solution uses a recursive approach to break down the number by its magnitude (Billion, Million, Thousand, etc.) and convert each part into English words. We handle special cases for numbers between 1 and 19 and the tens, while larger numbers are recursively processed for their appropriate scale.
