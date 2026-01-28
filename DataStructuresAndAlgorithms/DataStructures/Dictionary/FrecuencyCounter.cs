namespace DataStructuresAndAlgorithms.DataStructures.Dictionary
{
    public static class FrecuencyCounter
    {
        /// <summary>
        /// Tthe frequency of each number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Dictionary<int,int> with the frequency of each number</returns>
        public static Dictionary<int, int> Count(int[] nums)
        {
            Dictionary<int, int> frecuencies = [];

            for (int i = 0; i < nums.Length; i++) 
                if (frecuencies.TryGetValue(nums[i], out int value))
                    frecuencies[nums[i]] = ++value;
                else
                    frecuencies[nums[i]] = 1;

            return frecuencies;
        }

        /// <summary>
        /// Tthe frequency of each number.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>Dictionary<int,int> with the frequency of each number</returns>
        public static Dictionary<int, int> CountOptimized(int[] nums)
        {
            var frequencies = new Dictionary<int, int>();

            foreach (int num in nums)
                frequencies[num] = frequencies.GetValueOrDefault(num) + 1;

            return frequencies;
        }
    }
}
