using System;
using System.Data;

namespace MyCoffeeShop.DTO
{
    public class Shift
    {
        private int id;
        private string name;
        private TimeSpan opening_time, closing_time;

        public Shift(int id, string name, TimeSpan opening_time, TimeSpan closing_time)
        {
            this.id = id;
            this.name = name;
            this.opening_time = opening_time;
            this.closing_time = closing_time;
        }

        public Shift(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = (string)row["name"];
            this.opening_time = (TimeSpan)row["opening_time"];
            this.closing_time = (TimeSpan)row["closing_time"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public TimeSpan Opening_time { get => opening_time; set => opening_time = value; }
        public TimeSpan Closing_time { get => closing_time; set => closing_time = value; }
    }
}
