using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Splendor.Domain;

namespace Splendor.Blazor.Model
{
    public interface ISelectableDevelopment
    {
        public Development Development { get; set; }
        public bool Selected { get; set; }
    }
}
