// https://leetcode.com/problems/basic-calculator/description/

using BasicCalculator;
using Shared.Helpers;

var testCase = "1 +(3) + 1-5+  12 -(3+6 - ((-10)))";

var output = Problem.Solve(testCase);

output.Print();