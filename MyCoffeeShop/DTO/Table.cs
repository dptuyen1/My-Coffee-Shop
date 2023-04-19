using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Table
    {
        private int id;
        private string name;
        private bool status;

        public Table(int id, string name, bool status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
            this.status = (bool)row["status"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Status { get => status; set => status = value; }
    }
}
