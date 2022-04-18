using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Preparativos;
using TDD;
using System;

namespace PruebasTDD
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azuquero azuquero;
        MaquinaCafe maquinaCafe;

        [TestInitialize]
        public void setUp()
        {
            cafetera = new Cafetera(50);
            vasosPequenos = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azuquero = new Azuquero(20);

            maquinaCafe = new MaquinaCafe();
            maquinaCafe.setCafetera(cafetera);
            maquinaCafe.setVasosPequenos(vasosPequenos);
            maquinaCafe.setVasosMediano(vasosMediano);
            maquinaCafe.setVasosGrande(vasosGrande);
            maquinaCafe.setAzucarero(azuquero);
        }

        [TestMethod]
        public void deveriaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            Assert.AreEqual(maquinaCafe.getVasosPequenos(), vaso);
        }

        [TestMethod]
        public void deveriaDevolverUnVasoMediano()
        {
            MaquinaCafe maquinaCafe = new MaquinaCafe();
            Vaso vaso = maquinaCafe.getTipoVaso("mediano");

            Assert.AreEqual(maquinaCafe.getVasosMediano(), vaso);
        }

        [TestMethod]
        public void deveriaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("grande");

            Assert.AreEqual(maquinaCafe.getVasosGrande(), vaso);
        }

        [TestMethod]
        public void deveriaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            string resultado = maquinaCafe.getVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No hay vasos", resultado);
        }

        [TestMethod]
        public void deveriaDevolverNoHayAzucar()
        {
            azuquero = new Azuquero(2);
            maquinaCafe.setAzucarero(azuquero);
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");


            string resultado = maquinaCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void deveriaRestarCafe()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            maquinaCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaCafe.getCafetera().getCantidadDeCafe();

            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void deveriaRestarVaso()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            maquinaCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaCafe.getVasosPequenos().getCantidadVasos();

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void deveriaRestarAzucar()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            maquinaCafe.getVasoDeCafe(vaso, 1, 3);

            int resultado = maquinaCafe.getAzuquero().getCantidadAzucar();

            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void deveriaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaCafe.getTipoVaso("pequeno");

            string resultado = maquinaCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
}
