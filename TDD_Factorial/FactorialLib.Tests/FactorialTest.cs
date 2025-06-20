using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialLib;

namespace FactorialLib.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void Factorial_DeCero_DeberiaRetornarUno()
        {
            var calc = new Calculadora();
            int resultado = calc.Factorial(0);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void Factorial_DeUno_DeberiaRetornarUno()
        {
            var calc = new Calculadora();
            int resultado = calc.Factorial(1);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void Factorial_De5_DeberiaRetornar120()
        {
            var calc = new Calculadora();
            int resultado = calc.Factorial(5);
            Assert.AreEqual(120, resultado);
        }

        [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void Factorial_De3Negativo()
        {
            var calc = new Calculadora();
            int resultado = calc.Factorial(-3);
        }
  } }
    
    
