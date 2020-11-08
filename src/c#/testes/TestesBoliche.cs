using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class TestesBoliche
    {
        [TestMethod]
        public void TestaStrike_True()
        {
            // Arrange
            var arremesso = 1;
            var quantidadePinosDerrubados = 10;
            var quantidadePinosPorFrame = 10;

            var foiStrike = Program.FoiStrike(arremesso, quantidadePinosDerrubados, quantidadePinosPorFrame);

            // Assert
            Assert.IsTrue(foiStrike);

        }

        [TestMethod]
        public void TestaStrikeArremesso2_False()
        {
            // Arrange
            var arremesso = 2;
            var quantidadePinosDerrubados = 10;
            var quantidadePinosPorFrame = 10;

            var foiStrike = Program.FoiStrike(arremesso, quantidadePinosDerrubados, quantidadePinosPorFrame);

            // Assert
            Assert.IsFalse(foiStrike);

        }

        [TestMethod]
        public void TestaStrikePinosNaoDerrubados_False()
        {
            // Arrange
            var arremesso = 1;
            var quantidadePinosDerrubados = 5;
            var quantidadePinosPorFrame = 10;

            var foiStrike = Program.FoiStrike(arremesso, quantidadePinosDerrubados, quantidadePinosPorFrame);

            // Assert
            Assert.IsFalse(foiStrike);

        }
    }
}
