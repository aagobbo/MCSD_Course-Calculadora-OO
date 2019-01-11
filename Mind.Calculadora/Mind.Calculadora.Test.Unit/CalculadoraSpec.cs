using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Calculadora.Dominio;

namespace Mind.Calculadora.Test.Unit
{
    [TestClass]
    public class CalculadoraSpec
    {
        [TestMethod]
        public void DeveSomarDoisNumerosInteiros()
        {
            //Arrange
            Operadora operadora = new Soma();

            //Act
            var resultado = operadora.RealizarOperacao(1, 2);

            //Assert
            Assert.AreEqual(resultado, 3);
        }

        [TestMethod]
        public void DeveSubtrairDoisNumerosInteiros()
        {
            //Arrange
            Operadora operadora = new Subtracao();

            //Act
            var resultado = operadora.RealizarOperacao(2, 1);

            //Assert
            Assert.AreEqual(resultado, 1);
        }

        [TestMethod]
        public void DeveMultiplicarDoisNumerosInteiros()
        {
            //Arrange
            Operadora operadora = new Multiplicacao();

            //Act
            var resultado = operadora.RealizarOperacao(2, 1);

            //Assert
            Assert.AreEqual(resultado, 2);
        }

        [TestMethod]
        public void DeveDividirDoisNumerosInteiros()
        {
            //Arrange
            Operadora operadora = new Divisao();

            //Act
            var resultado = operadora.RealizarOperacao(1, 2);

            //Assert
            Assert.AreEqual(resultado, 0.5d);            
        }
    }
}
