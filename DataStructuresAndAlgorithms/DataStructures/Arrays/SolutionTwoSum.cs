namespace DataStructuresAndAlgorithms.DataStructures.Arrays
{
    public static class SolutionTwoSum
    {
        /// <summary>
        /// Indices of the two numbers such that they add up to target.
        /// </summary>
        /// <param name="nums">array of integers</param>
        /// <param name="target">an integer</param>
        /// <returns>indices of the two numbers.</returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) 
                for (int j =  i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target) 
                        return [i, j];

            throw new ArgumentException("No solution found");
        }

        /// <summary>
        /// Indices of the two numbers such that they add up to target. Dictionary (HashMap).
        /// </summary>
        /// <param name="nums">array of integers</param>
        /// <param name="target">an integer</param>
        /// <returns>indices of the two numbers.</returns>
        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int complemento = target - nums[i];

                if (map.TryGetValue(complemento, out int value))
                {
                    return [value, i];
                }

                map[nums[i]] = i;
            }

            throw new ArgumentException("No solution found");
        }
    }
}
