using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Staff
    {
        private int id;
        private string name, phone, address;

        public Staff(int id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public Staff(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (row["name"] == DBNull.Value) ? null : (string)row["name"];
            this.Phone = (row["phone"] == DBNull.Value) ? null : (string)row["phone"];
            this.Address = (row["address"] == DBNull.Value) ? null : (string)row["address"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
