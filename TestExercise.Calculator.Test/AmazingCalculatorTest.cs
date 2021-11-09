using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TestExercise.Calculator.Services;

namespace TestExercise.Calculator.Test
{
    [TestClass]
    public class AmazingCalculatorTest
    {
        [TestMethod]
        public void MultiplyOf_Number1IsZero_Number2IsNotZero_CloudIsFalse_ShouldReturnZero()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(0, 10, false);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsNotZero_Number2IsZero_ShouldReturnZero()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(10, 0, false);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsAnyNumber_Number2IsOne_CloudIsFalse_ShouldReturnNumber1()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(10, 1, false);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsAnyNumber_Number2IsOne_CloudIsTrue_ShouldReturnNumber1()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(10,1).Returns(10);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(10, 1, true);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsOne_Number2IsAnyNumber_CloudIsFalse_ShouldReturnNumber1()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(1, 10, false);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsOne_Number2IsAnyNumber_CloudIsTrue_ShouldReturnNumber1()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(1, 10).Returns(10);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(1, 10, true);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsEight_Number2IsSeven_CloudIsFalse_ShouldReturn56()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(8, 7, false);

            // Assert
            Assert.AreEqual(56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsEight_Number2IsSeven_CloudIsTrue_ShouldReturn56()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(8, 7).Returns(56);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(8, 7, true);

            // Assert
            Assert.AreEqual(56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsNegativeEight_Number2IsSeven_CloudIsFalse_ShouldReturnNegative56()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(-8, 7, false);

            // Assert
            Assert.AreEqual(-56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsEight_Number2IsNegativeSeven_CloudIsFalse_ShouldReturnNegative56()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(8, -7, false);

            // Assert
            Assert.AreEqual(-56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsNegativeEight_Number2IsNegativeSeven_CloudIsFalse_ShouldReturn56()
        {
            // Arrange
            var calc = new AmazingCalculator();

            // Act
            int result = calc.MultiplyMe(-8, -7, false);

            // Assert
            Assert.AreEqual(56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsNegativeEight_Number2IsSeven_CloudIsTrue_ShouldReturnNegative56()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(-8, 7).Returns(-56);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(-8, 7, true);

            // Assert
            Assert.AreEqual(-56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsEight_Number2IsNegativeSeven_CloudIsTrue_ShouldReturnNegative56()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(8, -7).Returns(-56);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(8, -7, true);

            // Assert
            Assert.AreEqual(-56, result);
        }

        [TestMethod]
        public void MultiplyOf_Number1IsNegativeEight_Number2IsNegativeSeven_CloudIsTrue_ShouldReturn56()
        {
            // Arrange
            var cloudService = Substitute.For<ICloudService>();
            cloudService.RunCloudBasedMultiplication(-8, -7).Returns(56);
            var calc = new AmazingCalculator(cloudService);

            // Act
            int result = calc.MultiplyMe(-8, -7, true);

            // Assert
            Assert.AreEqual(56, result);
        }

    }
}