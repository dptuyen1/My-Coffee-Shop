using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Discount
    {
        private int customer_id, value;
        private string name;

        public Discount(int customer_id, int value, string name)
        {
            this.customer_id = customer_id;
            this.value = value;
            this.name = name;
        }

        public Discount(DataRow row)
        {
            this.customer_id = (int)row["customer_id"];
            this.value = (int)row["value"];
            this.name = (string)row["name"];
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Value { get => value; set => this.value = value; }
        public string Name { get => name; set => name = value; }
    }
}
