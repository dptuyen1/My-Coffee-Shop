using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class DiscountDAO
    {
        private static DiscountDAO instance;

        public static DiscountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DiscountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private DiscountDAO() { }

        #region Pos
        public List<Discount> GetDiscountList(string phone)
        {
            List<Discount> discounts = new List<Discount>();

            string query = "EXEC USP_GetDiscountListByPhone @phone";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });

            foreach (DataRow row in data.Rows)
            {
                Discount discount = new Discount(row);
                discounts.Add(discount);
            }

            return discounts;
        }

        #endregion

        #region Admin

        public List<Discount> GetDiscountList()
        {
            List<Discount> discounts = new List<Discount>();

            string query = "select * from dbo.Discount";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Discount discount = new Discount(row);
                discounts.Add(discount);
            }

            return discounts;
        }

        #endregion
    }
}
