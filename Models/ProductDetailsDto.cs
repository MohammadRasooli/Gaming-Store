using System;

namespace Gaming_Store.Models
{
    public class ProductDetailsDto
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public int Inventory { get; set; }

        public string Image { get; set; }

        public int Category { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
