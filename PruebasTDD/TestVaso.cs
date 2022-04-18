using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Preparativos;

namespace PruebasTDD
{
    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasoPequenos = new Vaso(2, 10);

            bool resultado = vasoPequenos.hasVasos(1);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void deberiaDevolverFalsosSiNoExistenVasos()
        {
            Vaso vasoPequenos = new Vaso(1, 10);

            bool resultado = vasoPequenos.hasVasos(2);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void deberiaRestarCantidadDeVaso()
        {
            Vaso vasoPequenos = new Vaso(5, 10);

            vasoPequenos.giveVasos(1);
            Assert.AreEqual(4, vasoPequenos.getCantidadVasos());
        }
    }
}