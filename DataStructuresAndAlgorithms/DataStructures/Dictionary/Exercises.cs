namespace DataStructuresAndAlgorithms.DataStructures.Dictionary
{
    public static class Exercises
    {
        public static void CountFrequencies(int[] nums)
        {
            Dictionary<int, int> frecuencies = [];

            for (int i = 0; i < nums.Length; i++) 
                if (frecuencies.TryGetValue(nums[i], out int value))
                    frecuencies[nums[i]] = ++value;
                else
                    frecuencies[nums[i]] = 1;

            foreach (KeyValuePair<int, int> num in frecuencies)
                Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}
