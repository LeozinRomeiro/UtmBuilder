using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.Extensions;

namespace UtmBuilder.Core.Test.Extensions
{
    [TestClass]
    public class ListExtensionsTests
    {
        [TestMethod]
        public void NaoAdicionaNaListaQuandoValorNulo()
        {
            var list = new List<string>();
            list.AddIfNotNull("utm_sourne", null);
            Assert.AreEqual(0, list.Count);
        }
        [TestMethod]
        public void AdicionaNaLista()
        {
            var list = new List<string>();
            list.AddIfNotNull("utm_sourne", "sourne");
            Assert.AreEqual(1, list.Count);
        }
    }
}
