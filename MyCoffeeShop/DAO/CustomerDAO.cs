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

        #endregion
    }
}
