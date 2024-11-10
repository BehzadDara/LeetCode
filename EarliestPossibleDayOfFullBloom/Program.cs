// https://leetcode.com/problems/earliest-possible-day-of-full-bloom/

using EarliestPossibleDayOfFullBloom;
using Shared.Helpers;

var testCase1 = new int[] { 1, 2, 3, 2 };
var testCase2 = new int[] { 2, 1, 2, 1 };

var output = Problem.Solve(testCase1, testCase2);

output.Print();