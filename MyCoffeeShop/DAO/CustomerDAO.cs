using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomerDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CustomerDAO() { }

        #region Admin

        public List<Customer> GetCustomerList()
        {
            List<Customer> customers = new List<Customer>();

            string query = "select * from dbo.Customer";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Customer customer = new Customer(row);
                customers.Add(customer);
            }

            return customers;
        }

        public Customer GetCustomerByID(int id)
        {
            Customer Customer = null;

            string query = "SELECT * FROM dbo.Customer WHERE id = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Customer = new Customer(row);
            }

            return Customer;
        }

        public bool Insert(string name, string phone, string address)
        {
            string query = "EXEC dbo.USP_InsertCustomer @name , @phone , @address";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, phone, address });

            return result > 0;
        }

        public bool Update(int customer_id, string name, string phone, string address)
        {
            string query = "EXEC dbo.USP_UpdateCustomer @customer_id , @name , @phone , @address";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { customer_id, name, phone, address });

            return result > 0;
        }

        public bool Delete(int customer_id)
        {
            DiscountDAO.Instance.Delete(customer_id);

            string query = "delete from dbo.Customer where id = '" + customer_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        #endregion
    }
}
