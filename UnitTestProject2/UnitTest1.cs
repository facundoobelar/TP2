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
           double mImaginario = 2;
            double mReal =2;
            double mmReal = 5;
            double mmImaginario = 6;
           
           double mResultadoEsperado=3;
            //mResultado= Es
                Complejo pruComple = new Complejo(mReal,mImaginario);
            Complejo pru2Comple = new Complejo(mmReal, mmImaginario);
            Complejo mResultado;
            //double mResultadoEsperado = 6;
            double mResultadoImaginarioEsperado = 6;
            double mResultadoReal = mResultado.Real;
            double mResultadoImaginario = mResultado.Imaginario;
            Assert.AreEqual(mResultadoEsperado, mResultadoReal);


        }
    }
}
