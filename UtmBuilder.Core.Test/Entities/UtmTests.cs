using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.Entities;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Test.Entities
{
    [TestClass]
    public class UtmTests
    {
        private const string _link = "https://chat.openai.com/?utm_source=linkedin&utm_medium=post&utm_campaign=code&utm_id=1&utm_term=network&utm_content=utm";
        private readonly Url _url = new("https://chat.openai.com/");
        private readonly Campaign _campaign= new("linkedin", "post", "code", "1", "network", "utm");
        [TestMethod]
        public void DeveRetornarUrlDeUtm() 
        {
            var utm = new Utm(_url, _campaign);
            Assert.AreEqual(_link, utm.ToString());
            Assert.AreEqual(_link, (string)utm);
        }

        [TestMethod]
        public void DeveRetornarUtmDeUrl()
        {
            Utm utm = _link;
            Assert.AreEqual(_url.Address, utm.Url.Address);
            Assert.AreEqual(_campaign.Source, utm.Campaign.Source);
            Assert.AreEqual(_campaign.Medium, utm.Campaign.Medium);
            Assert.AreEqual(_campaign.Name, utm.Campaign.Name);
            Assert.AreEqual(_campaign.Id, utm.Campaign.Id);
            Assert.AreEqual(_campaign.Term, utm.Campaign.Term);
            Assert.AreEqual(_campaign.Content, utm.Campaign.Content);
        }
    }
}
