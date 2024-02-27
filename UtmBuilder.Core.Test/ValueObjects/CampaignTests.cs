using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Test.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        [DataRow("","","",false)]
        [DataRow("src","","",false)]
        [DataRow("src","","na",false)]
        [DataRow("src","med","na",true)]
        [DataRow("","med","",false)]
        public void TestCampaign(string source, string medium, string name, bool isValid) {
            try
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(isValid);
            }
            catch (InvalidCampaignException)
            {
                Assert.IsFalse(isValid);
            }
        }

        [TestMethod]
        [DataRow("", "med", "name", false)]
        public void TestSourceCampaign(string source, string medium, string name, bool isValid)
        {
            try
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(isValid);
            }
            catch (InvalidCampaignException e)
                when(e.Message == "Source invalido")
            {
                Assert.IsFalse(isValid);
            }
        }
    }
}
