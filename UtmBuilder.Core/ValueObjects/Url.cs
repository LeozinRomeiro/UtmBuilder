using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        /// <summary>
        /// Criar nova URL
        /// </summary>
        /// <param name="address">Endereço da URL</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }
        /// <summary>
        /// Endereço da URL 
        /// </summary>
        public string Address { get; }
    }
}
