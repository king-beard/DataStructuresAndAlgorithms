namespace DataStructuresAndAlgorithms.DataStructures.Dictionary
{
    public static class FirstNonRepeatingCharacterResolver
    {
        /// <summary>
        ///  first non-repeating character in string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static char FindCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("String is empty");

            Dictionary<char, int> frequencies = [];

            // 1. Count frequencies
            foreach (char c in str)
                frequencies[c] = frequencies.GetValueOrDefault(c) + 1;

            // 2. Find first non-repeating
            foreach (char c in str)
                if (frequencies[c] == 1)
                    return c;

            throw new ArgumentException("No non-repeating character found");
        }
    }
}
