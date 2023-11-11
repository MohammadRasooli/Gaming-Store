using System;

namespace Gaming_Store.Data
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Discription { get; set; }

        public double Price { get; set; }

        public int Inventory { get; set; }

        public string Image { get; set; }

        public int Category { get; set; }

        public DateTimeOffset CreationDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

    }
}
