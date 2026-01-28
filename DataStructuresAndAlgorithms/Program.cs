using DataStructuresAndAlgorithms.DataStructures.Arrays;
using DataStructuresAndAlgorithms.DataStructures.Dictionary;

int[] nums = { 2, 7, 11, 15 };
int target = 9;

int[] index = SolutionTwoSum.TwoSumOptimized(nums, target);

Console.WriteLine($"[{index[0]}, {index[1]}]");

int[] numss = { 1, 2, 2, 3, 3, 3 };

Exercises.CountFrequencies(numss);