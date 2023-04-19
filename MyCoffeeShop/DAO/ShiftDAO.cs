using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class ShiftDAO
    {
        private static ShiftDAO instance;

        public static ShiftDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShiftDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ShiftDAO() { }

        public List<Shift> GetShiftListById(int id)
        {
            List<Shift> shifts = new List<Shift>();

            string query = "select * from dbo.ShiftInfo where id = '" + id + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Shift shift = new Shift(row);
                shifts.Add(shift);
            }

            return shifts;
        }

        #region Admin

        public List<Shift> GetShiftList()
        {
            List<Shift> shifts = new List<Shift>();

            string query = "select * from dbo.ShiftInfo";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Shift shift = new Shift(row);
                shifts.Add(shift);
            }

            return shifts;
        }

        #endregion
    }
}
