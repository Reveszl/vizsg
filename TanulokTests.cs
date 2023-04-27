using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iskola1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola1.Tests
{
    [TestClass()]
    public class TanulokTests
    {
        [TestMethod()]
        public void KodTestJo()
        {
            Assert.AreEqual("6cbodszi", Tanulok.Kod(2006, "c", "Bodnar Szilvia"));
        }

        [TestMethod()]
        public void KodTestRossz()
        {
            Assert.AreEqual("5abodszi", Tanulok.Kod(2006, "c", "Bodnar Szilvia"));
        }
    }
}