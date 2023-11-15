using System;

namespace Gaming_Store.Models
{
    public class CreateProductDto
    {
        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public int Inventory { get; set; }

        public string Image { get; set; }

        public int Category { get; set; }
    }
}
