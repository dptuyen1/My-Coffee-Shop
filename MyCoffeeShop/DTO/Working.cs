using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Working
    {
        private int id, staff_id, shift_id;
        private TimeSpan login_time;

        public Working(int id, int staff_id, int shift_id, TimeSpan login_time)
        {
            this.id = id;
            this.staff_id = staff_id;
            this.shift_id = shift_id;
            this.login_time = login_time;
        }

        public Working(DataRow row)
        {
            this.id = (int)row["id"];
            this.staff_id = (int)row["staff_id"];
            this.shift_id = (int)row["shift_id"];
            this.login_time = (TimeSpan)row["login_time"];
        }

        public int Id { get => id; set => id = value; }
        public int Staff_id { get => staff_id; set => staff_id = value; }
        public int Shift_id { get => shift_id; set => shift_id = value; }
        public TimeSpan Login_time { get => login_time; set => login_time = value; }
    }
}
