﻿using MyCoffeeShop.DTO;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class DetailsDAO
    {
        private static DetailsDAO instance;

        public static DetailsDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DetailsDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private DetailsDAO() { }

        #region Pos
        public void Insert(int invoice_id, int product_id)
        {
            string query = "EXEC dbo.USP_InsertDetails @invoice_id , @product_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { invoice_id, product_id });
        }

        public void Delete(int invoice_id, int product_id)
        {
            string query = "EXEC dbo.USP_DeleteDetails @invoice_id , @product_id";

            DataProvider.Instance.ExecuteNonQuery(query, new object[] { invoice_id, product_id });
        }

        public void Delete(int invoice_id)
        {
            string first_query = "DELETE FROM dbo.Details WHERE invoice_id = '" + invoice_id + "'";
            string second_query = "DELETE FROM dbo.Invoice WHERE id = '" + invoice_id + "'";

            string[] query = {first_query, second_query};

            foreach (string s in query)
                DataProvider.Instance.ExecuteNonQuery(s);
        }

        public int GetQuantity(int invoice_id, int product_id)
        {
            string query = "SELECT * FROM dbo.Details WHERE invoice_id = '" + invoice_id + "' and product_id = '" + product_id + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                Details details = new Details(dt.Rows[0]);
                return details.Quantity;
            }

            return -1;
        }

        public int SumQuantity(int invoice_id)
        {
            string query = "SELECT SUM(quantity) AS total_quantity FROM dbo.Details WHERE invoice_id = '" + invoice_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        #endregion
    }
}