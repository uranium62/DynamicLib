namespace DynamicLib.Test
{
    using System.Text;
    using NUnit.Framework;
    using Parser;

    [TestFixture]
    public class DynamicSignatureTest
    {
        [Test]
        public void CheckTwoSameSignatures()
        {
            // Arrange
            var sign1 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),  
            });
            var sign2 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),
            });

            // Act
            var isEquals = sign1.Equals(sign2);

            // Assert
            Assert.IsTrue(isEquals);
        }

        [Test]
        public void CheckTwoSignaturesWithDifferentLength()
        {
            // Arrange
            var sign1 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),
            });
            var sign2 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),
                new DynamicProperty("Age", typeof(int)),
            });

            // Act
            var isEquals = sign1.Equals(sign2);

            // Assert
            Assert.IsFalse(isEquals);
        }

        [Test]
        public void CheckTwoSignaturesWithDifferentType()
        {
            // Arrange
            var sign1 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),
            });
            var sign2 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(StringBuilder)),
                new DynamicProperty("SecondName", typeof(StringBuilder)),
            });

            // Act
            var isEquals = sign1.Equals(sign2);

            // Assert
            Assert.IsFalse(isEquals);
        }

        [Test]
        public void CheckTwoSignaturesWithDifferentName()
        {
            // Arrange
            var sign1 = new DynamicSignature(new[]
            {
                new DynamicProperty("FirstName", typeof(string)),
                new DynamicProperty("SecondName", typeof(string)),
            });
            var sign2 = new DynamicSignature(new[]
            {
                new DynamicProperty("FName", typeof(string)),
                new DynamicProperty("SName", typeof(string)),
            });

            // Act
            var isEquals = sign1.Equals(sign2);

            // Assert
            Assert.IsFalse(isEquals);
        }
    }
}
