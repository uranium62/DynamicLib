
namespace DynamicLib.Test
{
    using NUnit.Framework;
    using Parser;

    [TestFixture]
    public class DynamicClassTest
    {
        [Test]
        public void ValidateToString()
        {
            // Arrange
            DynamicA obj = new DynamicA
            {
                A = 10,
                B = "test"
            };

            // Act
            var str = obj.ToString();

            // Assert
            Assert.That(str, Is.EqualTo("{A=10, B=test}"));
        }

        private class DynamicA : DynamicClass
        {
            public int A { get; set; }
            public string B { get; set; }
        }

    }

    
}
