using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private StaffDAO() { }

        public List<Staff> GetStaffListById(int id)
        {
            List<Staff> staffs = new List<Staff>();

            string query = "select * from dbo.Staff where id = '" + id + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff(row);
                staffs.Add(staff);
            }

            return staffs;
        }

        #region Admin

        public List<Staff> GetStaffList()
        {
            List<Staff> staffs = new List<Staff>();

            string query = "select * from dbo.Staff";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Staff staff = new Staff(row);
                staffs.Add(staff);
            }

            return staffs;
        }

        #endregion
    }
}
