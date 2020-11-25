using consoleapp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testes
{
    [TestClass]
    public class PartidaTests
    {
        [TestMethod]
        public void QuantRodadasValido()
        {
            // Arrange
            var partida1 = new Partida();

            // Act
            partida1.DefinirQuantRodadas(10);

            // Assert
            Assert.IsTrue(partida1.Valido);
        }

        [TestMethod]
        public void QuantRodadasInvalido()
        {
            // Arrange
            var partida1 = new Partida();
            var partida2 = new Partida();

            // Act
            partida1.DefinirQuantRodadas(0);
            partida2.DefinirQuantRodadas(5);

            // Assert
            Assert.IsFalse(partida1.Valido);
            Assert.IsFalse(partida2.Valido);
        }

        [TestMethod]
        public void QuantJogadoresValido()
        {
            // Arrange
            var partida1 = new Partida();
            var partida2 = new Partida();

            // Act
            partida1.DefinirQuantJogadores(1);
            partida2.DefinirQuantJogadores(4);

            // Assert
            Assert.IsTrue(partida1.Valido);
            Assert.IsTrue(partida2.Valido);
        }

        [TestMethod]
        public void QuantJogadoresInvalido()
        {
            // Arrange
            var partida1 = new Partida();
            var partida2 = new Partida();

            // Act
            partida1.DefinirQuantJogadores(0);
            partida2.DefinirQuantJogadores(5);

            // Assert
            Assert.IsFalse(partida1.Valido);
            Assert.IsFalse(partida2.Valido);
        }
    }
}