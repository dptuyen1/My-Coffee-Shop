using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Account
    {
        private int staff_id;
        private string username, password;
        private bool type;

        public Account(int staff_id, string username, string password, bool type)
        {
            this.Staff_id = staff_id;
            this.Username = username;
            this.Password = password;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.Staff_id = (int)row["staff_id"];
            this.Username = (string)row["username"];
            this.Password = (string)row["password"];
            this.Type = (bool)row["type"];
        }

        public int Staff_id { get => staff_id; set => staff_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool Type { get => type; set => type = value; }
    }
}
