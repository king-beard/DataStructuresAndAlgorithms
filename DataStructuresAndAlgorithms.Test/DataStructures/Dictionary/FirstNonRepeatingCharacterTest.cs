using DataStructuresAndAlgorithms.DataStructures.Dictionary;

namespace DataStructuresAndAlgorithms.Test.DataStructures.Dictionary
{
    public class FirstNonRepeatingCharacterTest
    {
        [Fact]
        public void Returns_First_Non_Repeating_Character()
        {
            string str = "aabbcde";
            char result = FirstNonRepeatingCharacterResolver.FindCharacter(str);
            Assert.Equal('c', result);
        }

        [Fact]
        public void Returns_First_When_All_Are_Unique()
        {
            string str = "abc";
            char result = FirstNonRepeatingCharacterResolver.FindCharacter(str);
            Assert.Equal('a', result);
        }

        [Fact]
        public void Throws_Exception_When_No_Unique_Character()
        {
            Assert.Throws<ArgumentException>(() =>
                FirstNonRepeatingCharacterResolver.FindCharacter("aabbcc"));
        }

        [Fact]
        public void Throws_Exception_On_Empty_String()
        {
            Assert.Throws<ArgumentException>(() =>
                FirstNonRepeatingCharacterResolver.FindCharacter(""));
        }
    }
}
