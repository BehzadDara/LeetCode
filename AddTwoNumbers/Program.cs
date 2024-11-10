// https://leetcode.com/problems/add-two-numbers/

using AddTwoNumbers;
using Shared.Classes;
using Shared.Helpers;

var testCase1 = new ListNode(2, new ListNode(4, new ListNode(3)));
var testCase2 = new ListNode(5, new ListNode(6, new ListNode(4)));

var output = Problem.Solve(testCase1, testCase2);

output.Print();