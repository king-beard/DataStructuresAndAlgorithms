using DataStructuresAndAlgorithms.DataStructures.Dictionary;

namespace DataStructuresAndAlgorithms.Test.DataStructures.Dictionary
{
    public class FrecuencyCounterTest
    {
        [Fact]
        public void Returns_Dictionary_With_The_Frequency_Of_Each_Number()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3, 3, 3 };

            // Act
            Dictionary<int, int> frecuencies = FrecuencyCounter.Count(nums);
            frecuencies.TryGetValue(1, out int OneKeyValue);
            frecuencies.TryGetValue(2, out int TwoKeyValue);
            frecuencies.TryGetValue(3, out int ThreeKeyValue);

            // Assert
            Assert.Equal(1, OneKeyValue);
            Assert.Equal(2, TwoKeyValue);
            Assert.Equal(3, ThreeKeyValue);
        }
    }
}
