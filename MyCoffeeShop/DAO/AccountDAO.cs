using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        #region Pos

        public bool Login(string username, string password)
        {
            string query = "EXEC dbo.USP_Login @username , @password";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return dt.Rows.Count > 0;
        }

        public bool isAdmin(int staff_id)
        {
            string query = "select * from dbo.Account where staff_id = '" + staff_id + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(@query);

            if (dt.Rows.Count > 0)
            {
                Account account = new Account(dt.Rows[0]);
                return account.Type;
            }

            return false;
        }

        public int GetIdByUsername(string username)
        {
            string query = "select * from dbo.Account where username = '" + username + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(@query);

            if (dt.Rows.Count > 0)
            {
                Account account = new Account(dt.Rows[0]);
                return account.Staff_id;
            }

            return 0;
        }

        #endregion

        #region Admin

        public List<Account> GetAccountList()
        {
            List<Account> accounts = new List<Account>();

            string query = "select * from dbo.Account";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Account account = new Account(row);
                accounts.Add(account);
            }

            return accounts;
        }

        public bool Insert(string username, string password, bool type, int staff_id)
        {
            string query = "EXEC dbo.USP_InsertAccount @username , @password , @type , @staff_id";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, type, staff_id });

            return result > 0;
        }

        public bool Update(string username, string password, bool type, int staff_id)
        {
            string query = "EXEC dbo.USP_UpdateAccount @username , @password , @type , @staff_id";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, type, staff_id });

            return result > 0;
        }

        public bool Delete(int staff_id)
        {
            string query = "delete from dbo.Account where staff_id = '" + staff_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        #endregion
    }
}
