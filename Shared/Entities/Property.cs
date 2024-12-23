using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    public class Property : BaseEntity
    {
        public string? Name { get; set; }

        public double? Rent { get; set; }

        public int? Rooms { get; set; }

        public int? Bathrooms { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
    }
}
