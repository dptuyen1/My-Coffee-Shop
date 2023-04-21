using MyCoffeeShop.DTO;
using System.Collections.Generic;
using System.Data;

namespace MyCoffeeShop.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public static int height = 100, width = 100;

        #region Admin

        public List<Category> GetCategoryList()
        {
            List<Category> categories = new List<Category>();

            string query = "select * from dbo.Category";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                Category category = new Category(row);
                categories.Add(category);
            }

            return categories;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM dbo.Category WHERE id = '" + id + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                category = new Category(row);
            }

            return category;
        }

        public bool Insert(string name)
        {
            string query = "EXEC dbo.USP_InsertCategory @name";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });

            return result > 0;
        }

        public bool Update(int category_id, string name)
        {
            string query = "EXEC dbo.USP_UpdateCategory @category_id , @name";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { category_id, name });

            return result > 0;
        }

        public bool Delete(int category_id)
        {
            string query = "delete from dbo.Category where id = '" + category_id + "'";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int doesHaveProduct(int category_id)
        {
            string query = "select count(*) from dbo.Product where category_id = '" + category_id + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        #endregion
    }
}
