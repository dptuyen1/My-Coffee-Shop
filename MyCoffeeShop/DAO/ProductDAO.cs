using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ProductDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ProductDAO() { }

        #region Admin

        public List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            string query = "select * from dbo.Product";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Product product = new Product(row);
                products.Add(product);
            }

            return products;
        }

        public bool Insert(string name, float price, string img_path, int category_id)
        {
            string query = "EXEC dbo.USP_InsertProduct @name , @price , @img_path , @category_id";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price, img_path, category_id });

            return result > 0;
        }

        public bool Update(int product_id, string name, float price, string img_path, int category_id)
        {
            string query = "EXEC dbo.USP_UpdateProduct @product_id , @name , @price , @img_path , @category_id";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { product_id, name, price, img_path, category_id });

            return result > 0;
        }

        public bool Delete(int product_id)
        {
            string query = "delete from dbo.Product where id = '" + product_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int isInDetails(int product_id)
        {
            string query = "select count(*) from dbo.Details where product_id = '" + product_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        #endregion

        #region Pos

        public List<Product> GetProductList(int id)
        {
            List<Product> products = new List<Product>();

            string query = "select * from dbo.Product where category_id = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Product product = new Product(row);
                products.Add(product);
            }

            return products;
        }

        public int GetProductId(string name)
        {
            string query = "select * from dbo.Product where name = N'" + name + "'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                Product product = new Product(dt.Rows[0]);
                return product.Id;
            }

            return -1;
        }

        #endregion
    }
}
