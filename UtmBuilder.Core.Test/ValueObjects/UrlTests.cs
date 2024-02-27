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
    public class UrlTests
    {
        private const string _url = "https://github.com/";
        private const string _invalidUrl = "";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void DadoUmaUrlInvalidaDeveRetornarUmaExcecao()
        {
            var url = new Url(_invalidUrl);
        }
        
        [TestMethod]
        public void DadoUmaUrlValidaDeveRetornarUmaUrl()
        {
            var url = new Url(_url);
            Assert.IsInstanceOfType(url, typeof(Url));
        }

        [TestMethod]
        [DataRow("", false)] // Link vazio
        [DataRow("not a link", false)] // Texto não é um link
        [DataRow("www.google.com", false)] // Link sem protocolo
        [DataRow("http://", false)] // Link com protocolo vazio
        [DataRow("http://localhost", false)] // Link para localhost
        [DataRow("file:///C:/example/file.txt", false)] // Link para um arquivo local
        [DataRow("javascript:alert('Hello, world!');", false)] // Link para um script JavaScript
        [DataRow("data:text/plain;base64,SGVsbG8sIFdvcmxkIQ%3D%3D", false)] // Link de dados codificados em base64
        [DataRow("https://youtube.com", true)] // Link válido: site popular
        [DataRow("http://example.com", true)] // Link válido: site de exemplo
        [DataRow("https://www.wikipedia.org/", true)] // Link válido: site popular
        [DataRow("https://www.amazon.com/dp/B08HM6XVY2", true)] // Link válido: produto na Amazon
        public void TesteValidaçãoDeUrls( string link, bool isValid)
        {
            try
            {
                var url = new Url(link);
                Assert.IsTrue(isValid);
            }
            catch (InvalidUrlException)
            {
                Assert.IsFalse(isValid);
            }
        }
    }
}
