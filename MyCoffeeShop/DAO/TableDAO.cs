using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private TableDAO() { }

        public static int height = 100, width = 100;

        #region Pos

        public void SwitchTable(int first_id, int second_id, int shift_id)
        {
            string query = "EXEC dbo.USP_SwitchTable @first_table_id , @second_table_id , @shift_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { first_id, second_id, shift_id });
        }

        #endregion

        #region Admin

        public List<Table> GetTableList()
        {
            List<Table> tables = new List<Table>();

            string query = "select * from dbo.TableInfo";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Table table = new Table(row);
                tables.Add(table);
            }

            return tables;
        }

        public bool Insert(string name, bool status)
        {
            string query = "EXEC dbo.USP_InsertTable @name , @status";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, status });

            return result > 0;
        }

        public bool Update(int table_id, string name, bool status)
        {
            string query = "EXEC dbo.USP_UpdateTable @table_id , @name , @status";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { table_id, name, status });

            return result > 0;
        }

        public bool Delete(int table_id)
        {
            string query = "delete from dbo.TableInfo where id = '" + table_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int isInInvoice(int table_id)
        {
            string query = "select count(*) from dbo.Invoice where table_id = '" + table_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        #endregion
    }
}
