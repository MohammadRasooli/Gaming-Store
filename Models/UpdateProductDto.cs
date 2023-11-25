using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gaming_Store.Models
{
    public class UpdateProductDto
    {
        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public int Inventory { get; set; }

        public string Image { get; set; }

        public int Category { get; set; }
        public DateTimeOffset UpdateDate = DateTimeOffset.UtcNow;
    }
}