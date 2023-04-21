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

        public Staff GetStaffByID(int id)
        {
            Staff staff = null;

            string query = "SELECT * FROM dbo.Staff WHERE id = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                staff = new Staff(row);
            }

            return staff;
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

        public bool Insert(string name, string phone, string address)
        {
            string query = "EXEC dbo.USP_InsertStaff @name , @phone , @address";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, phone, address });

            return result > 0;
        }

        public bool Update(int staff_id, string name, string phone, string address)
        {
            string query = "EXEC dbo.USP_UpdateStaff @staff_id , @name , @phone , @address";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { staff_id, name, phone, address });

            return result > 0;
        }

        public bool Delete(int staff_id)
        {
            AccountDAO.Instance.Delete(staff_id);

            string query = "delete from dbo.Staff where id = '" + staff_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
