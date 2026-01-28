using DataStructuresAndAlgorithms.DataStructures.Arrays;

namespace DataStructuresAndAlgorithms.Test.DataStructures.Arrays
{
    public class TwoSumTest
    {
        [Fact]
        public void TwoSum()
        {
            // Arrange
            int[] nums = [15, 2, 11, 7];
            int target = 9;

            // Act
            int[] index = TwoSumResolver.TwoSum(nums, target);

            // Assert
            Assert.Equal(1, index[0]);
            Assert.Equal(3, index[1]);
        }

        [Fact]
        public void TwoSumOptimized()
        {
            // Arrange
            int[] nums = [15, 2, 11, 7];
            int target = 9;

            // Act
            int[] index = TwoSumResolver.TwoSumOptimized(nums, target);

            // Assert
            Assert.Equal(1, index[0]);
            Assert.Equal(3, index[1]);
        }
    }
}
