using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Details
    {
        private int id, product_id, invoice_id, quantity;
        private float unit_price;

        public Details(int id, int product_id, int invoice_id, int quantity, float unit_price)
        {
            this.id = id;
            this.product_id = product_id;
            this.invoice_id = invoice_id;
            this.quantity = quantity;
            this.unit_price = unit_price;
        }

        public Details(DataRow row)
        {
            this.id = (int)row["id"];
            this.product_id = (int)row["product_id"];
            this.invoice_id = (int)row["invoice_id"];
            this.quantity = (int)row["quantity"];
            this.unit_price = (float)Convert.ToDouble(row["unit_price"]);
        }

        public int Id { get => id; set => id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Invoice_id { get => invoice_id; set => invoice_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Unit_price { get => unit_price; set => unit_price = value; }
    }
}
