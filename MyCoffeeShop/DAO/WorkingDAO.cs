using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class WorkingDAO
    {
        private static WorkingDAO instance;

        public static WorkingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkingDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private WorkingDAO() { }

        #region Admin

        public List<Working> GetWorkingList()
        {
            List<Working> works = new List<Working>();

            string query = "select * from dbo.Working";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Working working = new Working(row);
                works.Add(working);
            }

            return works;
        }

        #endregion

        #region Pos

        public void Insert(int staff_id, int shift_id)
        {

            string query = "EXEC dbo.USP_InsertWorking @staff_id , @shift_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { staff_id, shift_id });
        }
        #endregion
    }
}
