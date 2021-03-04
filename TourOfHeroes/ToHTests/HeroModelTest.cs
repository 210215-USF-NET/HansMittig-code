using System;
using Xunit;
using ToHModels;
// note that models aren't really supposed to be unit tested
// because they mainly hold data
// you should focus on unit testing logic, like BL or DL
// Also, don't unit test UI
namespace ToHTests
{
    public class HeroModelTest
    {
        // 3 parts of a unit test: arrange, act, assert
        // Arrange is all about setting up the things you need for the unit test
        // Act is doing the thing you want to test
        // Assert is comparing the actual results to the expected outcome

        //Arrange
        private Hero testHero = new Hero();
        
        [Fact]
        public void HeroNameShouldBeSet()
        {
            string testName = "the tick";
            //Act
            testHero.HeroName = testName;
            //Assert
            Assert.Equal(testName, testHero.HeroName);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]

        public void HeroNameShouldNotBeEmpty(string testName)
        {
            //Act and Assert
            Assert.Throws<ArgumentNullException>(() => testHero.HeroName = testName);
        }


    }
}
