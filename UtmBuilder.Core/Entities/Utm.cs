using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Entities
{
    public class Utm
    {
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
    }
}
