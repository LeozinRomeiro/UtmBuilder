using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

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

            InvalidCampaignException.ThrowIfNull(source, "Source invalido");
            InvalidCampaignException.ThrowIfNull(medium, "Medium invalido");
            InvalidCampaignException.ThrowIfNull(name, "Nome invalido");
        }
        /// <summary>
        /// O referenciador (por exemplo, google, newsletter)
        /// </summary>
        public string Source { get;}
        /// <summary>
        /// Meio de marketing (por exemplo, cpc, banner, e-mail)
        /// </summary>
        public string Medium { get;}
        /// <summary>
        /// Produto, código promocional ou slogan (por exemplo, spring_sale) É necessário um nome de campanha ou ID de campanha.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// O ID da campanha de anúncios.
        /// </summary>
        public string? Id { get; }
        /// <summary>
        /// Identificar as palavras-chave pagas
        /// </summary>
        public string? Term { get; }
        /// <summary>
        /// Use para diferenciar anúncios
        /// </summary>
        public string? Content { get; }
    }
}
