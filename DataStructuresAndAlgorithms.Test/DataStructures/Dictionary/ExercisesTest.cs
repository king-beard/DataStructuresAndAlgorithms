using DataStructuresAndAlgorithms.DataStructures.Dictionary;

namespace DataStructuresAndAlgorithms.Test.DataStructures.Dictionary
{
    public class ExercisesTest
    {
        [Fact]
        public void CountFrequencies()
        {
            // Arrange
            int[] nums = { 1, 2, 2, 3, 3, 3 };

            // Act
            Dictionary<int, int> frecuencies = Exercises.CountFrequencies(nums);
            frecuencies.TryGetValue(3, out int ThreeKeyValue);

            // Assert
            Assert.Equal(3, ThreeKeyValue);
        }
    }
}
