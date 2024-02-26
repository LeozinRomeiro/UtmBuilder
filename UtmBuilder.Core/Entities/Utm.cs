using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Entities
{
    public class Utm
    {
        /// <summary>
        /// Criar o Utm
        /// </summary>
        /// <param name="url">URL (WebSite link)</param>
        /// <param name="campaign">Detalhes da campanha</param>
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }

        /// <summary>
        /// URL (WebSite link)
        /// </summary>
        public Url Url { get; set; }
        /// <summary>
        /// Detalhes da campanha
        /// </summary>
        public Campaign Campaign { get; set; }
        public static implicit operator string(Utm utm) => utm.ToString();
        public static implicit operator Utm(string link)
        {
            if (string.IsNullOrEmpty(link))
            {
                throw new InvalidUrlException();
            }

            var url = new Url(link);
            var segments = url.Address.Split('?');
            if (segments.Length == 1) { throw new InvalidUrlException("Nenhum segmento reconhecido"); }


            return utm;
        }

        public override string ToString()
        {
            var segments = new List<string>();
            segments.AddIfNotNull("utm_sourne", Campaign.Source);
            segments.AddIfNotNull("utm_medium", Campaign.Medium);
            segments.AddIfNotNull("utm_campaign", Campaign.Name);
            segments.AddIfNotNull("utm_id", Campaign.Id);
            segments.AddIfNotNull("utm_term", Campaign.Term);
            segments.AddIfNotNull("utm_content", Campaign.Content);
            return $"{Url.Address}?{string.Join("&",segments)}";
        }
    }
}
