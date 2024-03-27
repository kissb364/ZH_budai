using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Masodfoku;

namespace Unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NemMasodfoku()
        {
            string ered = Program.MfEgyenlet(0,-12,10);
        }
        [TestMethod]
        public void NincsValosGyok()
        {
            Assert.AreEqual("Nincs valós gyök!", Program.MfEgyenlet(1,1,1));
        }
        [TestMethod]
        public void KetazonosGyok()
        {
            double a = 1;
            double b = 2;
            double c = 1;
            Assert.AreEqual("-1.00 -1.00", Program.MfEgyenlet(a, b, c));
        }
        [TestMethod]
        public void KetKulombozoGyok()
        {
            double a = 1;
            double b = -7;
            double c = 12;
            Assert.AreEqual("4.00 3.00", Program.MfEgyenlet(a, b, c));
        }
        [TestMethod]
        public void KetKulombozoValosGyok()
        {
            double a = 1;
            double b = 1.5;
            double c = -2.5;
            Assert.AreEqual("1.00 -2.50", Program.MfEgyenlet(a, b, c));
        }
    }
}
