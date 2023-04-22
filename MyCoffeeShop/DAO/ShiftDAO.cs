using MyCoffeeShop.DTO;
using System;
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

        public bool Insert(string name, TimeSpan opening_time, TimeSpan closing_time)
        {
            string query = "EXEC dbo.USP_InsertShift @name , @opening_time , @closing_time";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, opening_time, closing_time });

            return result > 0;
        }

        public bool Update(int shift_id, string name, TimeSpan opening_time, TimeSpan closing_time)
        {
            string query = "EXEC dbo.USP_UpdateShift @shift_id , @name , @opening_time , @closing_time";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { shift_id, name, opening_time, closing_time });

            return result > 0;
        }

        public bool Delete(int shift_id)
        {
            string query = "delete from dbo.ShiftInfo where id = '" + shift_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int isInInvoice(int shift_id)
        {
            string query = "select count(*) from dbo.Invoice where shift_id = '" + shift_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public int isInWorking(int shift_id)
        {
            string query = "select count(*) from dbo.Working where shift_id = '" + shift_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        #endregion
    }
}
