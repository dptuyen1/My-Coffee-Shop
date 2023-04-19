using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Category
    {
        private int id;
        private string name;

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Category(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
