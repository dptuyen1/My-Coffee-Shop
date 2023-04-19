using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Invoice
    {
        private int id, table_id, shift_id, total_quantity;
        private string staff_name;
        private float total_price, discount_price;
        private DateTime created_date;
        private bool status;

        public Invoice(int id, int table_id, int shift_id, int total_quantity, string staff_name, float total_price, float discount_price, DateTime created_date, bool status)
        {
            this.id = id;
            this.table_id = table_id;
            this.shift_id = shift_id;
            this.total_quantity = total_quantity;
            this.staff_name = staff_name;
            this.total_price = total_price;
            this.discount_price = discount_price;
            this.created_date = created_date;
            this.status = status;
        }

        public Invoice(DataRow row)
        {
            this.id = (int)row["id"];
            this.table_id = (int)row["table_id"];
            this.shift_id = (int)row["shift_id"];
            this.total_quantity = (int)row["total_quantity"];
            this.staff_name = (row["staff_name"] == DBNull.Value) ? null : (string)row["staff_name"];
            this.total_price = (float)Convert.ToDouble(total_price);
            this.discount_price = (float)Convert.ToDouble(discount_price);
            this.created_date = (DateTime)row["created_date"];
            this.status = (bool)row["status"];
        }

        public int Id { get => id; set => id = value; }
        public int Table_id { get => table_id; set => table_id = value; }
        public int Shift_id { get => shift_id; set => shift_id = value; }
        public int Total_quantity { get => total_quantity; set => total_quantity = value; }
        public string Staff_name { get => staff_name; set => staff_name = value; }
        public float Total_price { get => total_price; set => total_price = value; }
        public float Discount_price { get => discount_price; set => discount_price = value; }
        public DateTime Created_date { get => created_date; set => created_date = value; }
        public bool Status { get => status; set => status = value; }
    }
}
