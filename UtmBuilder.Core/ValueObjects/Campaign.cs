using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        /// <summary>
        /// Gerar a nova camp
        /// </summary>
        /// <param name="source">O referenciador (por exemplo, google, newsletter)</param>
        /// <param name="medium">Meio de marketing (por exemplo, cpc, banner, e-mail)</param>
        /// <param name="name">Produto, código promocional ou slogan (por exemplo, spring_sale) É necessário um nome de campanha ou ID de campanha.</param>
        /// <param name="id">O ID da campanha de anúncios.</param>
        /// <param name="term">Identificar as palavras-chave pagas</param>
        /// <param name="content">Use para diferenciar anúncios</param>
        public Campaign(string source, string medium, string name, string? id=null, string? term = null, string? content=null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
        }
        public string Source { get;}
        public string Medium { get;}
        public string Name { get; }
        public string? Id { get; }
        public string? Term { get; }
        public string? Content { get; }
    }
}
