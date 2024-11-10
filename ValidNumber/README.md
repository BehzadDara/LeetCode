# Valid Number

## Problem

A valid number can be split up into these components (in order):

- A decimal number or an integer.
- (Optional) An 'e' or 'E', followed by an integer.

A decimal number can be split into these components (in order):

- (Optional) A sign character (either '+' or '-').
- One of the following formats:
  - One or more digits, followed by a dot `.`.
  - One or more digits, followed by a dot `.`, followed by one or more digits.
  - A dot `.`, followed by one or more digits.

An integer can be split into these components (in order):

- (Optional) A sign character (either '+' or '-').
- One or more digits.

For example, the following are valid numbers:

- "2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789"

While the following are not valid numbers:

- "abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53".

Given a string `s`, return `true` if `s` is a valid number.

### Example 1:
**Input:** `s = "-12.34e78"`  
**Output:** `true`

### Example 2:
**Input:** `s = "abc"`  
**Output:** `false`

## Solution

The solution uses a loop to iterate through the string `s`, validating each character based on the rules for valid numbers. The function tracks whether an 'e' or '.' has appeared and ensures that the number conforms to the valid formats.
