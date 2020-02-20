using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rapnetApi.Models
{
    public class Diamond
    {
        public string Shape { get; set; }
        public decimal Size { get; set; }
        public string Color { get; set; }
        public string Clarity { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }
        public int Id { get; set; }

    }
}
