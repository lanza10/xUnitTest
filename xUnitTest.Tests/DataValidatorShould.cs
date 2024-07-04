using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

namespace xUnitTest.Tests
{
    public class DataValidatorShould
    {
        [Fact]
        public void ValidateValidNifs()
        {
            //Arrange
            DataValidator validator = new DataValidator();
            String nif = "12345678A";
            //Act
            bool isValidNif = validator.IsValidNif(nif);
            //Assert
            Assert.True(isValidNif, $"The nif {nif} isn´t valid");
        }

        [Fact]
        public void InvalidateInvalidNif()
        {
            //Arrange
            DataValidator validator = new DataValidator();
            String nif = "123456789";
            //Act
            bool isValidNif = validator.IsValidNif(nif);
            //Assert
            Assert.False(isValidNif, $"The nif {nif} shouldn't be valid");
        }

        [Theory]
        [InlineData("12345678Z", true)]
        [InlineData("12345678z", false)]
        [InlineData("1234", false)]
        [InlineData("12365234353253763", false)]
        [InlineData("AAAAAAAAA", false)]
        public void ValidateNif(string nif, bool expected)
        {
            //Arrange
            DataValidator validator = new DataValidator();
            //Act
            bool isValidNif = validator.IsValidNif(nif);
            //Assert
            Assert.Equal(expected, isValidNif);
        }

        [Fact]
        public void RaiseErrorWhenNifIsNull()
        {
            //Arrange
            DataValidator validator = new DataValidator();
            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => validator.IsValidNif(null));

        }
        [Fact]
        public void RaiseErrorWhenNifIsEmpty()
        {
            //Arrange
            DataValidator validator = new DataValidator();
            //Act
            
            //Assert
            Assert.Throws<ArgumentNullException>(() => validator.IsValidNif(""));

        }

        
    }
}
