using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Product
    {
        private int id, category_id;
        private string name, path;
        private float price;
        private byte[] photo;

        public Product(int id, int category_id, string name, string path, float price, byte[] photo)
        {
            this.id = id;
            this.category_id = category_id;
            this.name = name;
            this.path = path;
            this.price = price;
            this.photo = photo;
        }

        public Product(DataRow row)
        {
            this.id = (int)row["id"];
            this.category_id = (int)row["category_id"];
            this.name = (string)row["name"];
            this.path = (row["path"] == DBNull.Value) ? null : (string)row["path"];
            this.price = (float)Convert.ToDouble(row["price"]);
            this.photo = (row["photo"] == DBNull.Value) ? null : (byte[])row["photo"];
        }

        public int Id { get => id; set => id = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public float Price { get => price; set => price = value; }
        public byte[] Photo { get => photo; set => photo = value; }
    }
}
