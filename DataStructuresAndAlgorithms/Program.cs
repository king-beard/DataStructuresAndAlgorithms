using DataStructuresAndAlgorithms.DataStructures.Arrays;

int[] nums = [2, 7, 11, 15];
int target = 9;

int[] index = SolutionTwoSum.TwoSumOptimized(nums, target);

Console.WriteLine($"[{index[0]}, {index[1]}]");