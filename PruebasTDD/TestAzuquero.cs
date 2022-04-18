using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Preparativos;

namespace PruebasTDD
{
    [TestClass]
    public class TestAzuquero
    {
        Azuquero azuquero;

        [TestInitialize]
        public void setUp()
        {
            azuquero = new Azuquero(10);
        }
        [TestMethod]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(5);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(15);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarAzucarAlAzuquero()
        {
            azuquero.giveAzucar(5);
            Assert.AreEqual(5, azuquero.getCantidadAzucar());
        }

    }
}
