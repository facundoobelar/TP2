using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejerc4;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumar()
        {
            double nroReal1 = 2;
            double nroImag1 = 4;
            double nroReal2 = 4;
            double nroImag2 = 8;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            Complejo compl2 = new Complejo(nroReal2, nroImag2);
            Complejo resultEsperado = new Complejo(6,12);
            Complejo mResultado;
            mResultado = compl1.Sumar(compl2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(resultEsperado.Real, mResultado.Real);
            Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
        [TestMethod]
        public void TestRestar()
        {
            double nroReal1 = 6;
            double nroImag1 = 4;
            double nroReal2 = 4;
            double nroImag2 = 8;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            Complejo compl2 = new Complejo(nroReal2, nroImag2);
            Complejo resultEsperado = new Complejo(2,-4);
            Complejo mResultado;
            mResultado = compl1.Restar(compl2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(resultEsperado.Real, mResultado.Real);
            Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
        [TestMethod]
        public void TestMultiplicar()
        {
            double nroReal1 = 5;
            double nroImag1 = 2;
            double nroReal2 = 2;
            double nroImag2 = -3;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            Complejo compl2 = new Complejo(nroReal2, nroImag2);
            Complejo resultEsperado = new Complejo(16, -11);
            Complejo mResultado;
            mResultado = compl1.Multiplicar(compl2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(resultEsperado.Real, mResultado.Real);
            Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
        [TestMethod]
        public void TestDividir()
        {
            double nroReal1 = 3;
            double nroImag1 = 2;
            double nroReal2 = 1;
            double nroImag2 = -2;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            Complejo compl2 = new Complejo(nroReal2, nroImag2);
            Complejo resultEsperado = new Complejo(-0.2, 1.6);
            Complejo mResultado;
            mResultado = compl1.DividirPor(compl2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(resultEsperado.Real, mResultado.Real);
            Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
        [TestMethod]
        public void TestEsImaginario()
        {
            double nroReal1 = 0;
            double nroImag1 = 4;
            Complejo compl1 = new Complejo(nroReal1,nroImag1);
            bool mResultado;
            bool esImaginario = true;
            mResultado = compl1.EsImaginario();
            Assert.AreEqual(esImaginario, mResultado);
          //  Assert.IsTrue(mResultado);
       
        }
        [TestMethod]
        public void TestEsReal()
        {
            double nroReal1 = 0;
            double nroImag1 = 0;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            bool mResultado;
            bool esReal = true;
            mResultado = compl1.EsReal();
            Assert.AreEqual(esReal, mResultado);
            //  Assert.IsTrue(mResultado);

        }
        [TestMethod]
        public void TestEsigual()
        {
            double nroReal1 = 3;
            double nroImag1 = 2;
            double nroReal2 = 3;
            double nroImag2 = 2;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            Complejo compl2 = new Complejo(nroReal2, nroImag2);
            //Complejo resultEsperado = new Complejo(-0.2, 1.6);
            bool mResultado;
            bool esIgual = true;
            mResultado = compl1.EsIgual(compl2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(esIgual, mResultado);
            //Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
        [TestMethod]
        public void TestEsiguaaal2()
        {
            double nroReal1 = 3;
            double nroImag1 = 2;
            double nroReal2 = 3;
            double nroImag2 = 2;
            Complejo compl1 = new Complejo(nroReal1, nroImag1);
            //Complejo compl1 = new Complejo(nroReal1, nroImag1);
            //Complejo compl2 = new Complejo(nroReal2, nroImag2);
            //Complejo resultEsperado = new Complejo(-0.2, 1.6);
            bool mResultado;
            bool esIgual = true;
            mResultado = compl1.EsIgual(nroReal2,nroImag2);
            // Assert.AreEqual(resultEsperado,mResultado);
            Assert.AreEqual(esIgual, mResultado);
            //Assert.AreEqual(resultEsperado.Imaginario, mResultado.Imaginario);
        }
    }
}
