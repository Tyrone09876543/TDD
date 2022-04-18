using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Preparativos;

namespace PruebasTDD
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(5);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.hasCafe(11);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarcafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadDeCafe());
        }

    }
}
