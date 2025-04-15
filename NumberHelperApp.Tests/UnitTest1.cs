namespace NumberHelperApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsEven_ReturnTrue()
        {
            // Arrange
            var numberHelper = new NumberHelper();
            int number = 4;
            // Act
            bool result = numberHelper.IsEven(number);
            // Assert
            Assert.True(result);

        }
        [Fact]
        public void IsPrime_ReturnTrue()
        {
            // Arrange
            var numberHelper = new NumberHelper();
            int number = 7;
            // Act
            bool result = numberHelper.IsPrime(number);
            // Assert
            Assert.True(result);
        }
        [Fact]
        public void IsDouble_ReturnTrue()
        {
            // Arrange
            var numberHelper = new NumberHelper();
            int number = 5;
            // Act
            int result = numberHelper.DoubleIt(number);
            // Assert
            Assert.Equal(10, result);
        }
    }
}