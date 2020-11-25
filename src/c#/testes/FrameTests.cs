using consoleapp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testes
{
    [TestClass]
    public class FrameTests
    {
        [TestMethod]
        public void NumeroArremessosValido()
        {
            // Arrange
            var frame1 = new Frame();

            // Act
            frame1.DefinirQuantArremessos(2);

            // Assert
            Assert.IsTrue(frame1.Valido);
        }

        [TestMethod]
        public void NumeroArremessosInvalido()
        {
            // Arrange
            var frame1 = new Frame();
            var frame2 = new Frame();

            // Act
            frame1.DefinirQuantArremessos(0);
            frame2.DefinirQuantArremessos(1);

            // Assert
            Assert.IsFalse(frame1.Valido);
            Assert.IsFalse(frame2.Valido);
        }

        [TestMethod]
        public void QuantidadePinosPorFrameValido()
        {
            // Arrange
            var frame1 = new Frame();

            // Act
            frame1.DefinirQuantPinosPorFrame(10);

            // Assert
            Assert.IsTrue(frame1.Valido);
        }

        [TestMethod]
        public void QuantidadePinosPorFrameInvalido()
        {
            // Arrange
            var frame1 = new Frame();
            var frame2 = new Frame();

            // Act
            frame1.DefinirQuantArremessos(0);
            frame2.DefinirQuantArremessos(11);

            // Assert
            Assert.IsFalse(frame1.Valido);
            Assert.IsFalse(frame2.Valido);
        }
    }
}