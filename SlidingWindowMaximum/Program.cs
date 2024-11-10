// https://leetcode.com/problems/sliding-window-maximum/

using Shared.Helpers;
using SlidingWindowMaximum;

var testCase = new int[] { 1, 3, 1, 2, 0, 5 };
var windowSize = 3;

var output = Problem.Solve(testCase, windowSize);

output.Print();