using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Menu
    {
        private string name;
        private int quantity;
        private float price, unit_price;

        public Menu(string name, int quantity, float price, float unit_price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.unit_price = unit_price;
        }

        public Menu(DataRow row)
        {
            this.name = (string)row["name"];
            this.quantity = (int)row["quantity"];
            this.price = (float)Convert.ToDouble(row["price"]);
            this.unit_price = (float)Convert.ToDouble(row["unit_price"]);
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Unit_price { get => unit_price; set => unit_price = value; }
    }
}
