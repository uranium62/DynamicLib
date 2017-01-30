namespace DynamicLib.Test
{
    using NUnit.Framework;
    using Parser;

    [TestFixture]
    public class DynamicParseExceptionTest
    {
        [Test]
        public void CheckMessageFormat()
        {
            // Arrange
            var exception = new DynamicParseException("#error", 255);

            // Act
            var message = exception.ToString();

            // Assert
            Assert.That(message, Is.EqualTo("#error (at index 255)"));
        }
    }
}
